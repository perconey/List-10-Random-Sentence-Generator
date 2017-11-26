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
        private string _importedString;
        private MySqlConnection _conn = new MySqlConnection("server=localhost; userid=root; database=sentencegeneratorresources; password=sqlmc123");
        public MySqlConnection Conn { get => _conn; set => _conn = value; }
        public string ImportedString { get => _importedString; set => _importedString = value; }

        public DataBaseWordsImporter()
        {
            
            try
            {
            Conn.Open();

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            string commandText = "Select verb from verbs where id=2";
            MySqlCommand Command = new MySqlCommand(commandText, Conn);
            MySqlDataReader reader = Command.ExecuteReader();
            while(reader.Read())
            {
                ImportedString = reader["verb"].ToString();
            }

        }


    }
}
