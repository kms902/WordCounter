using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    class WordCounter
    {
        private Dictionary<string, int> dict;

        public WordCounter()
        {
            dict = new Dictionary<string, int>();
        }

        public void Start(string inputString)
        {
            //Note: some ? marks are still escaping somehow
            char[] delimiters = { ' ', ',', '.','/','?','!','\'','\"',';',':','\r','\n' };
            string[] words = inputString.Split(delimiters);
            for (int i = 0; i < words.Length; i++)
            {
                if (dict.ContainsKey(words[i].ToLower()))
                {
                    dict[words[i].ToLower()] += 1;
                }
                else
                {
                    dict.Add(words[i].ToLower(), 1);
                }
            }
        }

        public Dictionary<string, int> getDictionary()
        {
            return dict;
        }

        public void Histogram()
        {
            // Convert the dictionary into a sorted list
            //var sortedList = from word in dict orderby word.Value descending select word;
            var sortedList = dict.OrderByDescending(e => e.Value).ThenBy(e => e.Key). ToList();

            // Print the list with stars for the word count
            for(int i = 0; i < sortedList.Count(); i++)
            {
                string starString = "";
                for(int j = 0; j < sortedList[i].Value; j++)
                {
                    starString = starString + "*";
                }
                Console.WriteLine(sortedList[i].Key + ": " + starString);
            }
            

            //Console.Write(sortedList[0].Key);

            /*
            string[] orderedWordArray;
            for(int i = 0; i < dict.Count(); i++)
            {
                //dict.ElementAt(i).Value;
            }
            */
        }
    }
}
