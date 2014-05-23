using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Util;

namespace Util.Tests
{
    [TestClass]
    public class StringHelperTest
    {
        [TestClass]
        public class ReverseTests
        {
            [TestMethod]
            [TestCategory("Unit Test")]
            public void TestReverse()
            {
                // Arrange
                var target = new StringHelper();

                // Act
                string result = target.Reverse("a");

                // Assert
                Assert.AreEqual("a", result);
            }

            [TestMethod]
            [TestCategory("Unit Test")]
            public void TestReverseWithMultipleCharachters()
            {
                var target = new StringHelper();
                var result = target.Reverse("ab");

                Assert.AreEqual("ba", result);
            }

            [TestMethod]
            [TestCategory("Unit Test")]
            [Owner("Manuel")]
            [TestCategory("Exception tests")]
            [ExpectedException(typeof(ArgumentNullException))]
            public void TestReverseWithNullAndExpectedExceptionAttribute()
            {
                new StringHelper().Reverse(null);
            }

            [TestMethod]
            public void TestReverseWithNull()
            {
                try
                {
                    new StringHelper().Reverse(null);
                    Assert.Fail();
                }
                catch (ArgumentNullException ex)
                {
                    StringAssert.Contains(ex.Message, "input mag niet niks zijn");
                }
            }
        }

        [TestMethod]
        public void TestWithAccents()
        {
            var target = new StringHelper();
            var result = target.Reverse("Les Misérables");

            Assert.AreEqual("selbarésiM seL", result);
        }

        [TestMethod]
        public void TestReverseWithSurrogatePairs()
        {
            var result = new StringHelper().Reverse("Les Misérables");
            Assert.AreEqual("selbarésiM seL", result);
        }

        [TestMethod]
        public void TestAccents()
        {
            Assert.AreEqual("é", "é");
        }
    [TestMethod]
        public void TestReverseWithSurrogatePairsExplicit()
        {
            var result = new StringHelper().Reverse("Les Mise\u0302rables");
            Assert.AreEqual("selbare\u0302siM seL", result);
        }}
}
