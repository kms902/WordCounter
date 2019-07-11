using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounterProject
{
    class WordCounter
    {
        public WordCounter()
        {
            
        }

        public Dictionary<string, int> Start(string inputString)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            //Note: UTF8 encoded files will experience some symbol escapes
            char[] delimiters = { ' ', ',', '.','/','?','!','\'','\"',';',':','\r','\n','_' };
            string[] words = inputString.Split(delimiters);
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i].ToLower();
                if (dict.ContainsKey(word))
                {
                    dict[word] += 1;
                }
                else
                {
                    dict.Add(word, 1);
                }
            }
            return dict;
        }
    }
}
