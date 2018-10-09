using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterquartileRange;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterquartileRange.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void GetQuartileRangeTest0()
        {
            List<int> input = new List<int> { 6, 6, 6, 6, 6, 8, 8, 8, 10, 10, 12, 12, 12, 12, 16, 16, 16, 16, 16, 20 };
            double output = Solution.GetQuartileRange(input);
            double expected = 9d;

            Assert.AreEqual(expected, output);
        }

        [TestMethod()]
        public void GetQuartileRangeTest3()
        {
            List<int> input = Solution.CompleteList(
                new List<int> { 10, 40, 30, 50, 20, 10, 40, 30, 50, 20, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 
                new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 40, 30, 50, 20, 10, 40, 30, 50, 20 });
            double output = Solution.GetQuartileRange(input);
            double expected = 5d;

            Assert.AreEqual(expected, output);
        }
    }
}