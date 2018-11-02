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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            string messageid = msgid.Text;
            string messagetype;
            

            

            switch (messageid[0])
            {
                case 'E':
                    {
                        messagetype = "Email";
                        Emailwindow win2 = new Emailwindow();
                        win2.Show();
                        this.Close();
                        break;
                    }

                case 'S':
                    {
                        messagetype = "SMS";
                        SMSwindow win2 = new SMSwindow();
                        win2.Show();
                        this.Close();
                        break;
                    }

                case 'T':
                    {
                        messagetype = "Tweet";
                        Tweetwindow win2 = new Tweetwindow();
                        win2.Show();
                        this.Close();
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
