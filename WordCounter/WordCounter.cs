using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounterProject
{
    public class WordCounter
    {

        public Dictionary<string, int> Start(string inputString)
        {
            ///<summary> This method iterates over the input string and returns a dictionary with each word encountered as keys and their occurence count as values.</summary>
            ///<example>
            ///<code>
            ///string inputString = "This is a test to see the count of each word that is repeated in this sentence";
            ///WordCounter myWordCount = new WordCounter();
            ///myWordCount.Start(inputString);
            ///</code>
            ///</example>
            ///<param name="inputString">Any string to be counted.</param>

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
