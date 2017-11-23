using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentence_Generator.Logic
{
    class UserInterface
    {
        private int _choice;

        public int Choice { get => _choice; set => _choice = value; }

        public object ClassElement { get => _classElement; set => _classElement = value; }

        private object _classElement;

        public UserInterface()
        {
            Choice = 0;
        }

        public void BeginSentenceGenerator()
        {
            int consoleInput;

            Console.WriteLine("Welcome to the Random Sentence Generator (Console version) by Perki");
            Console.WriteLine("\n Choose on of the following types of sentence to generate");
            Console.WriteLine("\t\t AVAILABLE TYPES (press one of the numbers on keyboard to select)\n");

            Console.WriteLine($"1. Subject + Verb\n" +
                              $"2. Subject + Verb + Adverb\n" +
                              $"3. Subject + Verb + Noun\n" +
                              $"4. Subject + Verb + Adjective\n" +
                              $"5. Subject + Verb + Object\n");

            while (!int.TryParse(Console.ReadLine(), out consoleInput))
                Console.Write("The value must be of integer type, try again: ");
            Choice = consoleInput;

            switch(Choice)
            {
                case 1:
                    ClassElement = new Sentence();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
        }
    }
}
