using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentence_Generator.Logic
{
    class WordContainer
    {
        public enum WordType
        {
            subject, verb, adverb, noun, oobject
        }

        private string _word;

        public string Word { get => _word; set => _word = value; }

        public WordContainer()
        {

        }
    }
    
}   
    
    
    