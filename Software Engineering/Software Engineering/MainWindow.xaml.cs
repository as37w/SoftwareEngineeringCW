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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Business;
namespace Software_Engineering
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        public MainWindow()
        {
            InitializeComponent();
        }
        //Initialise new instances of classes
        public Tweet tweetid = new Tweet();
        public Email emailid = new Email();
        public SMS smsid = new SMS();
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            string messageid = msgid.Text;
          
            //Case statement to determine which type of message is being entered and which window to load depending on which type is entered.
            switch (messageid[0])
            {
                case 'E':
                    {
                        emailid.messageHeader = msgid.Text;
                        Emailwindow win2 = new Emailwindow();
                        win2.Show();
                        this.Hide();
                        break;
                    }

                case 'S':
                    {
                        smsid.messageHeader=msgid.Text;
                        SMSwindow win2 = new SMSwindow();
                        win2.Show();
                        this.Hide();
                        break;
                    }

                case 'T':
                    {
                        tweetid.messageHeader =msgid.Text;
                        Tweetwindow win2 = new Tweetwindow();
                        win2.Show();
                        this.Hide();
                        break;
                    }
            }

            
            
            

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
