using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    class WordCounter
    {
        public WordCounter(string inputString)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            char[] delimiters = { ' ', ',', '.' };
            string[] words = inputString.Split(delimiters);
            for(int i = 0; i < words.Length; i++)
            {
                if (dict.ContainsKey(words[i])){
                    dict[words[i]] += 1;
                }
                else
                {
                    dict.Add(words[i], 1);
                }
            }
        }
    }
}
