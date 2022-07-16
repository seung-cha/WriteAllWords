using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace WriteAllWords
{
    internal static class Words
    {
        static Dictionary<char, LinkedList<string>> wordsTable;


        public static void Initialise()
        {
            wordsTable = new Dictionary<char, LinkedList<string>>();

            for(int i = 0; i < 26; i++)
            {
                wordsTable.Add((char)('a' + i), new LinkedList<string>());
            }
        }

        public static void ReadData()
        {
            string path = Directory.GetCurrentDirectory() + "\\words_alpha.txt";

            try
            {
                using (StreamReader reader = File.OpenText(path))
                {
                    string s = "";     
                    while ((s = reader.ReadLine()) != null)
                    {

                        wordsTable[s[0]].AddFirst(s);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Reading file failed");
            }

            Console.WriteLine("File Read");
        }


        public static List<string> GetWords(char startingLetter, string? contains, int length)
        {
            if (contains == null)
                return wordsTable[startingLetter].Where(x => x.Length == length).ToList();

            return wordsTable[startingLetter].Where(x => x.Length == length && x.Contains(contains)).ToList();
        }
    }
}
