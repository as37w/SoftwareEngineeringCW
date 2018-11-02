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
            string phonenum = sendernum.Text;
            string smsmessage = smsmsg.Text;
            if (Regex.Match(phonenum, @"^(?([0-9]{3}))?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$").Success)
            {
                phonenumbers.Add(phonenum);
            }
        }
    }
}
