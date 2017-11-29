using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sentence_Generator.Logic
{
    class UserInterface
    {

        private int _choice;

        public int Choice { get => _choice; set => _choice = value; }

        public Sentence Sent { get => _sent; set => _sent = value; }

        private Sentence _sent;

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
                              $"5. Subject + Verb + Object\n" +
                              $"6. Connect");

            while (!int.TryParse(Console.ReadLine(), out consoleInput))
                Console.Write("The value must be of integer type, try again: ");
            Choice = consoleInput;

            switch(Choice)
            {
                case 1:
                    Sent = new Sentence(1);
                    break;
                case 2:
                    Sent = new Sentence(2);
                    break;
                case 3:
                    Sent = new Sentence(3);
                    break;
                case 4:
                    Sent = new Sentence(4);
                    break;
                case 5:
                    Sent = new Sentence(5);
                    break;
            }
            Sent.Show();
        }
    }
}
