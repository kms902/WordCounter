using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounterProject
{
    public class Histogram
    {

        
        public static void Start(Dictionary<string, int> dict)
        {
            /// <summary> Writes a sorted histogram of words and their count to the console. </summary>
            /// <example>
            /// <code>
            /// IDictionary dict = new Dictionary<string, int>() {
            ///   { "the", 18 },
            ///   { "to", 20 },
            /// };
            /// Histogram.Start(dict);
            /// </code>
            /// </example>
            /// <param name="dict">A dictionary where each key represents a word, and the value is the number of times the word was found in a text.</param>

            // Convert the dictionary into a sorted list
            //var sortedList = from word in dict orderby word.Value descending select word;
            var sortedList = dict.OrderByDescending(e => e.Value).ThenBy(e => e.Key).ToList();

            // Print the list with stars for the word count
            for (int i = 0; i < sortedList.Count(); i++)
            {
                string starString = "";
                for (int j = 0; j < sortedList[i].Value; j++)
                {
                    starString = starString + "*";
                }
                Console.WriteLine(sortedList[i].Key + ": " + starString);
            }
        }
    }
}
