using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quartiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartiles.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void GetQuartilesTest()
        {
            List<int> data = new List<int> { 3, 7, 8, 5, 12, 14, 21, 13, 18 };
            List<double> output = Solution.GetQuartiles(data);
            List<double> expected = new List<double> { 6, 12, 16 };

            bool success = true;

            for(int i = 0; i < 3; i++)
            {
                if(output[i] != expected[i])
                {
                    success = false;
                }
            }

            Assert.IsTrue(success);

        }
    }
}