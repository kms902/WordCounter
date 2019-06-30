using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = args[0];
            string text = System.IO.File.ReadAllText(fileName);

            WordCounter wordCounter = new WordCounter(text);
     
        }
    }
}
