using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Software_Engineering
{
    /// <summary>
    /// Interaction logic for SMS.xaml
    /// </summary>
    public partial class SMSwindow : Window
    {
        public List<String> phonenumbers = new List<string>();

        public SMSwindow()
        {
            InitializeComponent();
        }

        private void smssubmit_Click(object sender, RoutedEventArgs e)
        {
            //Creates new instance of the SMS class
            SMS sms = new SMS();
            sms.messageHeader = ((MainWindow)Application.Current.MainWindow).smsid.messageHeader;
            sms.Sender = sendernum.Text;
            sms.messageText = smsmsg.Text;

            //creates new instance of the Method Class
            Methods methods = new Methods();
            //loads in all of the abreviations using the loadCsvFile method from within the methods class to the list abbreviations.
            List<string> abbreviations = methods.loadCsvFile("textwords.csv");
            //Creates the string abrev which turns the list abbreviations to array and joins the abbreviations by comma.
            string abrev = string.Join(",", abbreviations.ToArray());
            //creates a new list of type string split which splits the string abrev by comma creating a list in which each instance is one abbreviation.
            List<string> split = abrev.Split(',').ToList();
            //creates a list input which contatins the sms message text split by null
            List<string> input = new List<string>(sms.messageText.Split(null));
            
            //Checks that the phonenumber is valid
            if (Regex.Match(sms.Sender, @"^(?([0-9]{3}))?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$").Success)
            {
                sms.Sender = sms.Sender;
            }
            else
            {
                MessageBox.Show("Invalid Phone Number, Invalid");
            }

            
            
            int counter1 = input.Count;
            int counter2 = split.Count;


            for (int i = 0; i < sms.messageText.Length; i++)
            {

                if (counter1 == i)
                {
                    break;
                }
            for (int j = 0; j < split.Count; j++)
                {

                    if (counter2 == j)
                    {
                        break;
                    }
                    //checks to see if the current word is an abbreviation that needs to be expanded and if it is it expands it in the required format.
                    if (split[j].Equals(input[i]))
                    {
                        string original = input[i];
                        string word = split[j+1];
                        word = "<" + word + ">";
                        input[i] = original + word;
                        j = -1;
                        j++;
                    }

                }
             
                

            }

            //creates a new instance of the SMS class to be saved.
            SMS serealise = new SMS();
            serealise.messageHeader = ((MainWindow)Application.Current.MainWindow).smsid.messageHeader;
            serealise.Sender = sendernum.Text;
            serealise.messageText = string.Join(" ", input.ToArray());

            //appends the serealise object to the JSON file "output.json".
            using (StreamWriter writer = File.AppendText(@"output.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, serealise);
            }

            smslstbox.Items.Add(string.Join(" ", input));


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