using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sentence_Generator.Logic
{
    class DataBaseWordsImporter
    {

        private MySqlConnection _conn = new MySqlConnection("server=localhost; userid=root; database=sentencegeneratorresources; password=sqlmc123");
        public MySqlConnection Conn { get => _conn; set => _conn = value; }

        public DataBaseWordsImporter()
        {
            Conn.Open();
            
        }

    }
}
