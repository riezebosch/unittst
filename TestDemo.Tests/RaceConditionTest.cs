using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDemo.Tests
{
    [TestClass]
    public class RaceConditionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sut = new RaceCondition();
            sut.Foo();
        }
    }
}
