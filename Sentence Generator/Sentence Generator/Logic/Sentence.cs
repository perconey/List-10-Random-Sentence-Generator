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
        public enum WordType
        {
            subject = 1, verb = 2, adverb = 3, noun = 4, oobject = 5, other = 6
        }

        private int _type;

        public int Type { get => _type; set => _type = value; }
        internal WordContainer WordCont { get => _wordCont; set => _wordCont = value; }
        public string ReadySentence { get => _readySentence; set => _readySentence = value; }

        public StringBuilder sentenceBuild = new StringBuilder();
        private WordContainer _wordCont = new WordContainer();
        public DataBaseWordsImporter dbimp = new DataBaseWordsImporter();
        private string _readySentence;

        //Function to get random number
        private static readonly Random getrandom = new Random();
        private static readonly object syncLock = new object();
        public static int GetRandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return getrandom.Next(min, max);
            }
        }

        public static string FirstCharToUpper(string input)
        {
            switch (input)
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                default: return input.First().ToString().ToUpper() + input.Substring(1);
            }
        }

        public void BuildSentence(int type)
        {
            dbimp.ConnectAndImport();
            var sb = dbimp.listOfVariousWordsStringIDpairs;
            switch(type)
            {
                case 1:
                    var rand = GetRandomNumber(0, sb[0].Count - 1);
                    Console.WriteLine(rand);
                    string tempSubject = "", tempVerb = "";
                    foreach(var el in sb[0])
                    {
                        rand--;
                        if(rand == 0)
                        {
                            tempSubject = el.Key;
                            break;
                        }
                    }

                    rand = GetRandomNumber(0, sb[1].Count - 1);
                    Console.WriteLine(rand);

                    foreach (var el in sb[1])
                    {
                        rand--;
                        if (rand == 0)
                        {
                            tempVerb = el.Key;
                            break;
                        }
                    }

                    sentenceBuild.Append(tempSubject + " " + tempVerb);
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
            ReadySentence = sentenceBuild.ToString();
            ReadySentence = FirstCharToUpper(ReadySentence);
        }

        public Sentence(int type)
        {

            BuildSentence(type);
        }

        public void Show()
        {
            Console.WriteLine(ReadySentence);
        }
    }
}
