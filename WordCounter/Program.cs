using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Run Tests
            TestSimpleString();

            // Run Program

            //string fileName = args[0];
            string fileName = "..\\..\\..\\TaleOfTwoCities.txt";
            string text = File.ReadAllText(fileName);

            WordCounter wordCounter = new WordCounter();
            wordCounter.Start(text);
            wordCounter.Histogram();
            
            Console.WriteLine("[PRESS ENTER TO EXIT PROGRAM]");
            Console.ReadLine();
     
        }

        public static void TestSimpleString()
        {
            string para = "This is a test to see the count of each word that is repeated in this sentence";
            WordCounter wordCounter = new WordCounter();
            wordCounter.Start(para);
            Dictionary<string, int> wordCounts = wordCounter.getDictionary();
            Debug.Assert(wordCounts["this"] == 2, "Test failure: Count of \"this\" not equal to 2.");
            wordCounter.Histogram();
        }
    }
}
