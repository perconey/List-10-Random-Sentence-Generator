using Sentence_Generator.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentence_Generator
{
    class Program
    {
        public static UserInterface gui = new UserInterface();
        /// <summary>
        /// Are you sure abpur recreating whole language-o-algorythmic process?
        /// </summary>
        /// <param name="args"></param>
         
        static void Main(string[] args)
        {
            gui.BeginSentenceGenerator();



            Console.ReadLine();
        }
    }
}
