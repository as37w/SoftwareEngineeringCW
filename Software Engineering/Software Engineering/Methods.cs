using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Business;
using System.Collections.ObjectModel;





namespace Software_Engineering
{
    public class Methods
    {
        string filepath = "textwords.csv";

        //This method loads the abreviations file containing the abreviations to be expanded into a list of strings named abreviations.
        public List<string> loadCsvFile(string filePath)
        {
            var reader = new StreamReader(File.OpenRead(filepath));
            List<string> abbreviations = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                line.Split(',');
                abbreviations.Add(line);
            }
            return abbreviations;
            
        }

        
    
        //Several obesrvable collections created to hold relevant data to be kept tracked of and displayed to the users.
        public static ObservableCollection<SIR> SIRlist = new ObservableCollection<SIR>();
        public static ObservableCollection<hashtag> hashtagList = new ObservableCollection<hashtag>();
        public static ObservableCollection<mentions> mentionList = new ObservableCollection<mentions>();
        public static ObservableCollection<string> trendingList = new ObservableCollection<string>();

        //Method to add an object of type SIR to the observable collection SIRlist.
        public static void addSir(SIR sirList)
        {
            SIRlist.Add(sirList);
        }  

        //method to retrieve the observable collection SIRlist
        public static ObservableCollection<SIR> getsir()
        {
            return SIRlist;
        }

        //Method to add an object of type hashtag to the observable collection hashList
        public static void addHash(hashtag hashlist)
        {
            hashtagList.Add(hashlist);
        }

        //Method to retrieve the observable collection hashList
        public static ObservableCollection<hashtag> gethash()
        {
            return hashtagList;
        }

        //Method to add an object of type mentions to the observable collection mentionList
        public static void addMention(mentions mentionlist)
        {
            mentionList.Add(mentionlist);
        }

        //Method to retrieve the observable collection mentionList
        public static ObservableCollection<mentions> getmentions()
        {
            return mentionList;
        }

        //Method to return the observable collection trendingList
        public static ObservableCollection<string> gettrending()
        {
            return trendingList;
        }

    }
}
