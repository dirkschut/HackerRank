using Microsoft.VisualStudio.TestTools.UnitTesting;
using Array2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2D.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void GetMaxHValueTest()
        {
            int[,] testArray =
            {
                { 0, -4, -6, 0, -7, -6},
                { -1, -2, -6, -8, -3, -1},
                { -8, -4, -2, -8, -8, -6},
                { -3, -1, -2, -5, -7, -4},
                { -3, -5, -3, -6, -6, -6},
                { -3, -6, 0, -8, -6, -7}
            };
            int answer = Solution.GetMaxHValue(testArray);
            int expected = -19;
            Assert.AreEqual(expected, answer);
        }
    }
}