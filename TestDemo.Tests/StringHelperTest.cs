using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDemo.Tests
{
    [TestClass]
    public class StringHelperTest
    {
        [TestMethod]
        public void TestSimpleCase()
        {
            string result = StringHelper.Reverse("a");
            Assert.AreEqual("a", result);
        }

        [TestMethod]
        public void TestInputWithTwoCharacters()
        {
            string result = StringHelper.Reverse("ab");
            Assert.AreEqual("ba", result);
        }

        [TestMethod]
        public void TestWithEmptyString()
        {
            string result = StringHelper.Reverse("");
            Assert.AreEqual("", result);
        }

        [TestCategory("Integration Test")]
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestWithNull()
        {
            StringHelper.Reverse(null);
        }

        [TestMethod]
        public void TestBlockCoverage()
        {
            BlockCoverage.Foo(true, false);
        }

        [TestMethod]
        public void TestBlockCoverage2()
        {
            BlockCoverage.Foo(false, true);
        }

        [TestMethod]
        public void TestBlockCoverageNotSufficient()
        {
            BlockCoverage.Foo(false, false);
        }

        [TestMethod]
        public void TestReverseWithSurrogatePairs()
        {
            var result = StringHelper.Reverse("Les Misérables");
            Assert.AreEqual("selbarésiM seL", result);
        }

        [TestMethod]
        public void TestReverseWithAscii()
        {
            var result = StringHelper.Reverse("Les Misérables");
            Assert.AreEqual("selbarésiM seL", result);
        }

    }
}

