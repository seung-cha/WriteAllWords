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

        public static bool fileRead = false;

        public static void Initialise()
        {
            wordsTable = new Dictionary<char, LinkedList<string>>();

            for(int i = 0; i < 26; i++)
            {
                wordsTable.Add((char)('a' + i), new LinkedList<string>());
            }
        }

        public static bool ReadData()
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
            catch(FileNotFoundException e)
            {
                Console.WriteLine("words_alpha.txt is not found. Make sure there is a text file named 'words_alpha' in the folder.");
                fileRead = false;
                return false;
            }
            catch(Exception e)
            {
                fileRead = false;
                return false;
            }

            Console.WriteLine("File Read");
            fileRead = true;
            return true;
        }


        public static List<string> GetWords(char startingLetter, string contains, int length)
        {
            if(!wordsTable.ContainsKey(startingLetter))
            {
                Console.WriteLine("Invalid character is provided.");
                return null;
            }

            if(length <= 0)
            {
                return wordsTable[startingLetter].Where(x => x.Contains(contains)).ToList();
            }

            return wordsTable[startingLetter].Where(x => x.Length == length && x.Contains(contains)).ToList();
        }
    }
}
