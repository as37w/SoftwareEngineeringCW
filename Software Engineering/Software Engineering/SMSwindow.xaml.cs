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

            SMS sms = new SMS();
            sms.Sender = sendernum.Text;
            sms.messageText = smsmsg.Text;

            Methods lol = new Methods();
            List<string> abbreviations = lol.loadCsvFile(@"C:\Users\Alex\source\repos\Software Engineering\textwords.csv");
            List<string> input = new List<string>(sms.messageText.Split(null));
           
            if (Regex.Match(sms.Sender, @"^(?([0-9]{3}))?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$").Success)
            {
                sms.Sender = sms.Sender;
            }
            else
            {
                MessageBox.Show("Invalid Phone Number, Invalid");
            }

            
            
            int counter = input.Count;

           

            for (int i = 0; i < sms.messageText.Length; i++)
            {

                if (counter == i)
                {
                    break;
                }

                

            }

            smslstbox.Items.Add(input);


        }
    }

}