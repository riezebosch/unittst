using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoverageDemo.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private static string Something(bool a, bool b)
        {
            string result = default(string);

            if (a)
            {
                result = "a";
            }

            if (b)
            {
                result = "b";
            }

            return result.ToString();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Something(true, true);
        }

        [TestMethod]
        public void SomethingHasABug()
        {
            Something(false, false);
        }
    }
}
