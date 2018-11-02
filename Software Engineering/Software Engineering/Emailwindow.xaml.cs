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
            if (email.messageText.Contains('@') && email.messageText.Contains('.'))
            {
                emails.Add(email);
            }

            for (int i=0; i < email.messageText.Length; i++)
            {
                if (input[i].Contains("https://") || input[i].Contains("http://") || input[i].Contains("www."))
                {
                    string url = input.ToString();
                    url = "<" + "URL Quarantined" + ">";
                    input.Insert(i + 1, url);
                    input.RemoveAt(i);
                }
            }

            emaillstbox.Items.Add(string.Join("",input));
        }
           



    }
}
