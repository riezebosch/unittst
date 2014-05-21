using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDemo;
using Microsoft.QualityTools.Testing.Fakes;

namespace TestDemo.Tests
{
    [TestClass]
    public class AgeCalculatorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var target = new AgeCalculator();
            int result = target.Calc(new DateTime(1982, 4, 5));

            Assert.AreEqual(31, result);
        }

        [TestMethod]
        public void TestCalcCurrentMonthButDayNotPassedYet()
        {
            using (ShimsContext.Create())
            {
                System.Fakes.ShimDateTime.TodayGet = () => new DateTime(2014, 3, 11);

                var target = new AgeCalculator();
                int result = target.Calc(new DateTime(1982, 3, 12));

                Assert.AreEqual(31, result);
            }
        }
    }
}
