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
    /// Interaction logic for Tweet.xaml
    /// </summary>
    public partial class Tweetwindow : Window
    {
        public Tweetwindow()
        {
            InitializeComponent();
        }

        private void tweetsubmit_Click(object sender, RoutedEventArgs e)
        {
            string username = tweetsender.Text;
            string tweet = tweetmsg.Text;
        }
    }
}
