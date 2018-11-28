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
using System.Linq;
using System.IO;
using Newtonsoft.Json;

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
          
            //Creates a new instance of the tweet class.
            Tweet tweet = new Tweet();
            tweet.messageHeader= ((MainWindow)Application.Current.MainWindow).tweetid.messageHeader;
            tweet.twitterId = tweetsender.Text;
            tweet.messageText = tweetmsg.Text;

            //creates a new instance of the methods class.
            Methods load = new Methods();
            //loads in all of the abreviations using the loadCsvFile method from within the methods class to the list abbreviations.
            List<string> abbreviations = load.loadCsvFile("textwords.csv");
            //Creates the string abrev which turns the list abbreviations to array and joins the abbreviations by comma.
            string abrev = string.Join(",", abbreviations.ToArray());
            //creates a new list of type string split which splits the string abrev by comma creating a list in which each instance is one abbreviation.
            List<string> split = abrev.Split(',').ToList();
            //creates a list input which contatins the sms message text split by null
            List<string> input = new List<string>(tweet.messageText.Split(null));
            //creates a new list contating all the values of the obesrvable collection hashList.
            List<hashtag> hashlist = Methods.hashtagList.ToList<hashtag>();
            hashtag hash_tag = new hashtag();
            mentions mention = new mentions();
            int counter1 = input.Count;
            int counter2 = split.Count;

            tweetlstbox.Items.Clear();
            Methods.trendingList.Clear();

            if (tweet.twitterId.Length > 16)
              
            {
                    MessageBox.Show("Invalid Twitter id please enter an id thats 16 characters or less, Invalid");
                
            }
            for (int i = 0; i < tweet.messageText.Length; i++)
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
                        string word = split[j + 1];
                        word = "<" + word + ">";
                        input[i] = original + word;
                        j = -1;
                        j++;
                    }
                }

                //checks to see if the current word is a mention or a hastag by checking the first char in each word.
                if (input[i].ToCharArray()[0] == '@')
                {
                    mention.Mention = input[i];
                    Methods.mentionList.Add(mention);
                }

                if (input[i].ToCharArray()[0] == '#')
                {
                    hash_tag.hashTags = input[i];
                    hashlist.Add(hash_tag);

                }


            }

            
            List<string> strings = hashlist.Select(c => c.hashTags).ToList();
            //creates a new dictionary called trending of type string, int.
            Dictionary<string, int> trending = new Dictionary<string, int>();


            //this method calculates the trending list by checking if the trending list contains the hashtag, if not it will be added with the count of 1, if not it will add 1 to the count of the hashtag.
            foreach (string hashtag in strings)
            {
                if (!trending.ContainsKey(hashtag))
                {
                    trending.Add(hashtag, 1);
                }
                else
                {
                    int count = 0;
                    trending.TryGetValue(hashtag, out count);
                    trending.Remove(hashtag);
                    trending.Add(hashtag, count + 1);
                }
            }

            foreach (KeyValuePair<string, int> entry in trending)
            {
                tweetlstbox.Items.Add(entry.Key + "  " + entry.Value);
                //adds the current hashtags and there values to the list trendingList.
                Methods.trendingList.Add(entry.Key + "  " + entry.Value);

            }

            


            //creates a new instance of the tweet class.
            Tweet serealise = new Tweet();
            serealise.messageHeader = ((MainWindow)Application.Current.MainWindow).tweetid.messageHeader;
            serealise.twitterId = tweetsender.Text;
            serealise.messageText = string.Join(" ", input.ToArray());

            //appends the searlise object to the JSON file "output.json"
            using (StreamWriter writer = File.AppendText(@"output.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, serealise);
            }


            //adds the object hash_tag to the observable collection hashList using the addHash method.
            Methods.addHash(hash_tag);
            
            
        }

        private void Finish_Click(object sender, RoutedEventArgs e)
        {
            Finish win2 = new Finish();
            win2.Show();
            this.Close();
        }

        private void Finish_Copy_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            this.Close();
        }
    }
}