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
        string filepath = @"C:\Users\Alex\source\repos\Software Engineering\textwords.csv";

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
    
        
        public static ObservableCollection<SIR> SIRlist = new ObservableCollection<SIR>();

        public static void addSir(SIR sirList)
        {
            SIRlist.Add(sirList);
        }  

        public static ObservableCollection<SIR> getsir()
        {
            return SIRlist;
        }

        
    }
}
