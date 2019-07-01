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
            char[] delimiters = { ' ', ',', '.' };
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

        public void histogram()
        {
            string[] orderedWordArray;
            for(int i = 0; i < dict.Count(); i++)
            {
                //dict.ElementAt(i).Value;
            }
        }
    }
}
