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
namespace Software_Engineering
{
    /// <summary>
    /// Interaction logic for Email.xaml
    /// </summary>
    public partial class Emailwindow : Window
    {
        public List<Email> emails = new List<Email>();
        public Emailwindow()
        {
            InitializeComponent();
        }

        private void emailsubmit_Click(object sender, RoutedEventArgs e)
        {
            Email email = new Email();
            email.Sender = senderemail.Text;
            email.messageText = emailmsg.Text;
            email.Subject = subject.Text;

            List<string> input = new List<string>(email.messageText.Split(null));
            List<string> inputsubject = new List<string>(email.Subject.Split(null));
            ObservableCollection<SIR> SIRlist = new ObservableCollection<SIR>();
            if (email.messageText.Contains('@') && email.messageText.Contains('.'))
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

                if (input[i].Contains("https://") || input[i].Contains("http://") || input[i].Contains("www."))
                {
                    string url = input.ToString();
                    url = "<" + "URL Quarantined" + ">";
                    input.Insert(i + 1, url);
                    input.RemoveAt(i);
                    emaillstbox.Items.Add(string.Join("", input));
                }


            }
            bool hasdate;
            for (int i = 0; i < email.Subject.Length; i++)
            {

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
            if (hasdate = true)
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

                    if (input[7].Equals("Attack") || input[7].Equals("Theft") || input[7].Equals("Abuse") || input[7].Equals("Threat") || input[7].Equals("Incident") || input[7].Equals("Loss"))
                    {
                        sir.incidentName = input[6].ToString() + " " + input[7].ToString();
                        emaillstbox.Items.Add(string.Join(" ", input));

                    }




                }

                Methods.addSir(sir);
                datagrid.ItemsSource = Methods.getsir();


            }
        }
    }
}

