using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordCounter.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string para = "This is a test to see the count of each word that is repeated in this sentence";
            WordCounter wordCounter = new WordCounter();
            Dictionary<string, int> wordCounts = wordCounter.Start(para);
            Debug.Assert(wordCounts["this"] == 2, "Test failure: Count of \"this\" not equal to 2.");
            Histogram.Start(wordCounts);
        }
    }
}
