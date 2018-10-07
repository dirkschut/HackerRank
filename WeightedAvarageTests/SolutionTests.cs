using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeightedAvarage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightedAvarage.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void GetWeightedAvarageTest()
        {
            List<int> numbers = new List<int> { 10, 40, 30, 50, 20 };
            List<int> weights = new List<int> { 1, 2, 3, 4, 5 };

            double solution = Solution.GetWeightedAvarage(numbers, weights);
            double expected = 32d;

            Assert.AreEqual(expected, solution);
        }
    }
}