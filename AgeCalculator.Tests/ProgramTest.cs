using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgeCalculator.Tests
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestCalcAge()
        {
            int result = Program.CalcAge(new DateTime(1982, 4, 5));
            Assert.AreEqual(32, result);
        }

        [TestMethod]
        public void TestCalcAge_AnotherBirthDate()
        {
            
            int result = Program.CalcAge(new DateTime(1983, 4, 5));
            Assert.AreEqual(31, result);
        }

        [TestMethod]
        public void TestCalcAge_Where_Month_Not_Passed_Yet()
        {

            int result = Program.CalcAge(new DateTime(1982, 7, 5));
            Assert.AreEqual(31, result);
        }

        [TestMethod]
        public void TestCalcAge_Where_Month_Is_Now_But_Day_Not_Passed()
        {

            int result = Program.CalcAge(new DateTime(1982, 5, 23));
            Assert.AreEqual(31, result);
        }
    }
}
