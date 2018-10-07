using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeanMedianAvarage;

namespace MeanMedianAvarage.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void GetNumbersTest()
        {
            string input = "64630 11735 14216 99233 14470 4978 73429 38120 51135 67060";
            List<int> result = Solution.GetNumbers(input);
            List<int> expected = new List<int> { 64630, 11735, 14216, 99233, 14470, 4978, 73429, 38120, 51135, 67060 };

            if (result.Count != expected.Count) Assert.Fail();

            bool successful = true;
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] != expected[i])
                {
                    successful = false;
                }
            }

            Assert.IsTrue(successful);
        }

        [TestMethod()]
        public void GetMeanTest()
        {
            List<int> numbers = new List<int> { 64630, 11735, 14216, 99233, 14470, 4978, 73429, 38120, 51135, 67060 };
            float mean = Solution.GetMean(numbers);
            float expected = 43900.6f;

            Assert.AreEqual(expected, mean);
        }

        [TestMethod()]
        public void GetMedianTest()
        {
            List<int> numbers = new List<int> { 64630, 11735, 14216, 99233, 14470, 4978, 73429, 38120, 51135, 67060 };
            float median = Solution.GetMedian(numbers);
            float expected = 44627.5f;
            Assert.AreEqual(expected, median);
        }

        [TestMethod()]
        public void GetModeTest()
        {
            List<int> numbers = new List<int> { 64630, 11735, 14216, 99233, 14470, 4978, 73429, 38120, 51135, 67060 };
            int mode = Solution.GetMode(numbers);
            int expected = 4978;
            Assert.AreEqual(expected, mode);
        }
    }
}