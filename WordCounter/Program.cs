using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace WordCounterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //string fileName = args[0];
            string fileName = "..\\..\\..\\TaleOfTwoCities.txt";
            string text = File.ReadAllText(fileName);

            WordCounter wordCounter = new WordCounter();
            Dictionary<string, int> wordDict = wordCounter.Start(text);
            Histogram.Start(wordDict);
            
            Console.WriteLine("[PRESS ENTER TO EXIT PROGRAM]");
            Console.ReadLine();
     
        }
    }
}
