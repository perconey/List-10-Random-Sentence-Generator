using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sentence_Generator.Logic
{
    public class DataBaseWordsImporter
    {
        public enum Wordtypes
        {
            subject = 1,verb = 2,adverb = 3
        }
        private string _importedString;
        private MySqlConnection _conn = new MySqlConnection("server=localhost; userid=root; database=sentencegeneratorresources; password=sqlmc123");
        public MySqlConnection Conn { get => _conn; set => _conn = value; }
        public string ImportedString { get => _importedString; set => _importedString = value; }

        /// <summary>
        /// KeyValuePair legend:
        /// String stands for the actual word all in lower case
        /// Int stands for the type of word for further management, you can see allt he word type id's in 
        /// WordContainer class (enum WordType)
        /// </summary>
        public List<List<KeyValuePair<string,int>>> listOfVariousWordsStringIDpairs = new List<List<KeyValuePair<string, int>>>();


        public DataBaseWordsImporter()
        {

        }

        public void ConnectAndImport()
        {
            try
            {

                Conn.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            int i;
            for (i = 1; i < 4; i++)
            {
                List<KeyValuePair<string, int>> temp = new List<KeyValuePair<string, int>>();
                string commandText = $"Select {WordType(i).Remove(WordType(i).Length - 1)} from {WordType(i)}";
                MySqlCommand Command = new MySqlCommand(commandText, Conn);
                MySqlDataReader reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    temp.Add(new KeyValuePair<string,int>(reader[WordType(i).Remove(WordType(i).Length - 1)].ToString(), i));
                }

                listOfVariousWordsStringIDpairs.Add(temp);
                reader.Close();
            }
        }


        private string WordType(int i)
        {
            switch(i)
            {
                case 1:
                    return "subjects";
                case 2:
                    return "verbs";             
                case 3:
                    return "adverbs";
            }
            Console.WriteLine("something went wrong");
            return null;
        }

        public void ShowAllImportedWords()
        {
            foreach(var el in listOfVariousWordsStringIDpairs)
            {
                foreach(var s in el)
                {
                    Console.WriteLine(s.Key + " " + s.Value);
                }
            }
        }
    }
}
