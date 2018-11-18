using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Business;
using System.Collections.ObjectModel;
using System.IO;
using Newtonsoft.Json;

namespace Software_Engineering
{
    /// <summary>
    /// Interaction logic for Email.xaml
    /// </summary>
    public partial class Emailwindow : Window
    {
        //Create new list of type Email
        public List<Email> emails = new List<Email>();
        public Emailwindow()
        {
            InitializeComponent();
        }

        private void emailsubmit_Click(object sender, RoutedEventArgs e)
        {
            //Create new instance of the email class.
            Email email = new Email();
            //Retrieve the email message header from the startup window.
            email.messageHeader = ((MainWindow)Application.Current.MainWindow).emailid.messageHeader;
            email.Sender = senderemail.Text;
            email.messageText = emailmsg.Text;
            email.Subject = subject.Text;

            //creates a list input of type string which contains each word in the email message as a seperate entry.
            List<string> input = new List<string>(email.messageText.Split(null));
            //creates a list inputsubject of type string which contatins each word in the subject as a seperate entry.
            List<string> inputsubject = new List<string>(email.Subject.Split(null));
            //Creates new instance of the observable collection SIRlist.
            ObservableCollection<SIR> SIRlist = new ObservableCollection<SIR>();

            //If email is valid add email to the list emails.
            if (email.Sender.Contains('@') && email.Sender.Contains('.'))
            {
                emails.Add(email);
            }
            int counter = input.Count;



            for (int i = 0; i < email.messageText.Length; i++)
            {

                if (counter == i)
                {
                    break;
                }

                //This checks for any links contained within the email and replaces them with the required quarentine message. 
                if (input[i].Contains("https://") || input[i].Contains("http://") || input[i].Contains("www."))
                {
                    string url = input.ToString();
                    url = "<" + "URL Quarantined" + ">";
                    input.Insert(i + 1, url);
                    input.RemoveAt(i);
                    emaillstbox.Items.Add(string.Join("", input));
                }


            }
            bool hasdate = false;
            for (int i = 0; i < email.Subject.Length; i++)
            {
                //Checks if the email is a significant incident report and that it contains the date of the incident within the email subject
                try
                {
                    if (inputsubject.Contains("Sir"))
                    {
                        DateTime.Parse(inputsubject[1]);
                        hasdate = true;
                    }


                }

                catch
                {

                }



            }
            //If the email subject contains "SIR" followed by a valid date then the SIR sortcode and incident is saved.
            if (hasdate == true)
            {
                SIR sir = new SIR();
                sir.sortCode = input[2];
                bool hassix = false;
                if (input.Count == 7)
                {
                    sir.incidentName = input[6];
                    hassix = true;
                    emaillstbox.Items.Add(string.Join(" ", input));
                    
                }
                if (hassix == false)
                {
                    
                    //For any incident that contains 2 words it will correctly identify this and display the whole incident name.
                    if (input[7].Equals("Attack") || input[7].Equals("Theft") || input[7].Equals("Abuse") || input[7].Equals("Threat") || input[7].Equals("Incident") || input[7].Equals("Loss"))
                    {
                        sir.incidentName = input[6].ToString() + " " + input[7].ToString();
                        emaillstbox.Items.Add(string.Join(" ", input));

                    }




                }
                //Adds the incedent report to the SIR list.
                Methods.addSir(sir);
                //Displays the observable collection SIRlist in the datagrid.
                datagrid.ItemsSource = Methods.getsir();

                //Appends the email to the JSON file "output.json"
                Email serealise = new Email();
                serealise.messageHeader = ((MainWindow)Application.Current.MainWindow).emailid.messageHeader;
                serealise.Sender = senderemail.Text;
                serealise.messageText = string.Join(" ", input.ToArray());

                using (StreamWriter writer = File.AppendText(@"output.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(writer, serealise);
                }

            }
        }

        private void Finish_Click(object sender, RoutedEventArgs e)
        {
            Finish win2 = new Finish();
            win2.Show();
            this.Close();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            this.Close();
        }
    }
}

