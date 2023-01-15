using Microsoft.VisualStudio.TestTools.UnitTesting;
using T34;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * With an empty array, everything fails
 * I expected average to fail becaue you can not divide something with 0.
 * Others Like Max and Min require elements becaue they are Enumerable methods.
 * 
 * But also noticed, since the functions return string in the form of "Sum = X". Test expects exact output. Such as "Sum = 0" and "Average = NaN"
 * So adjusting the expected output as string output, I can get the expected results. Still, enumerable methods fail due to their nature.
 */
namespace T34.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {
        [TestMethod()]
        public void SumTest()
        {
            new ArrayCalcs();
            double[] array = {};

            string actual = ArrayCalcs.Sum(array);
            string expected = "Sum = 0";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void AverageTest()
        {
            new ArrayCalcs();
            double[] array = {};

            string actual = ArrayCalcs.Average(array);
            string expected = "Average = NaN";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void MaxTest()
        {
            new ArrayCalcs();
            double[] array = {};

            string actual = ArrayCalcs.Max(array);
            string expected = "Max = 0";

            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void MinTest()
        {
            new ArrayCalcs();
            double[] array = {};

            string actual = ArrayCalcs.Min(array);
            string expected = "Min = 0";

            Assert.AreEqual(actual, expected);
        }
    }
}