using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Sentence_Generator.Logic
{
    // 1. Subject + Verb
    // 2. Subject + Verb + Adverb
    // 3. Subject + Verb + Noun
    // 4. Subject + Verb + Adjective
    // 5. Subject + Verb + Object
    class Sentence
    {
        private int _type;

        public int Type { get => _type; set => _type = value; }

        public Sentence()
        {
            

           
        }
    }
}
