using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentence_Generator.Logic
{
    /// <summary>
    /// Will be used in more advanced release, in which every word will be treated as separate object
    /// </summary>
    class WordContainer
    {
        public enum WordType
        {
            subject = 1, verb = 2 , adverb = 3, noun = 4, oobject = 5, other = 6
        }

        private string _word;

        public string Word { get => _word; set => _word = value; }

        public WordContainer()
        {

        }
    }
    
}   
    
    
    