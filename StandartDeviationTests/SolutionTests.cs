using Microsoft.VisualStudio.TestTools.UnitTesting;
using StandartDeviation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandartDeviation.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void GetStandartDeviationTest()
        {
            List<int> input = new List<int> { 10, 40, 30, 50, 20 };
            double output = Math.Round(Solution.GetStandartDeviation(input) * 10) / 10d; // trickery to round to one decimal place
            double expected = 14.1d;
            Assert.AreEqual(expected, output);
        }
    }
}