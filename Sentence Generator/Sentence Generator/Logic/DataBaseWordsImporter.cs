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
        public List<List<string>> listOfWordsLists;

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
                List<string> temp = new List<string>();
                string commandText = $"Select {WordType(i).Remove(WordType(i).Length - 1)} from {WordType(i)}";
                MySqlCommand Command = new MySqlCommand(commandText, Conn);
                MySqlDataReader reader = Command.ExecuteReader();

                while (reader.Read())
                {
                    temp.Add(reader[WordType(i).Remove(WordType(i).Length - 1)].ToString());
                }

                listOfWordsLists.Add(temp);
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
            foreach(var el in listOfWordsLists)
            {
                foreach(var s in el)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
