using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounterProject
{
    class Histogram
    {
        public Histogram() { }

        public static void Start(Dictionary<string, int> dict)
        {
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
