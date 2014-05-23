using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace HRM.Tests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Verhoog_PersoonLangerDan5JaarInDienst_ShouldReturnTrue()
        {
            // Arrange
            var mock = new Mock<IPersoneelsAdministratie>(MockBehavior.Strict);
            mock.Setup(m => m.Zoek(It.IsAny<int>()))
                .Returns(new Persoon { });

            mock.Setup(m => m.Zoek(402))
                .Returns(new Persoon()).Verifiable();
            
            var target = new SalarisAdministratie(mock.Object);
            Console.WriteLine(mock.Object.GetType().FullName);
            // Act 
            var result = target.Verhoog(401, 50m);

            // Assert
            Assert.IsTrue(result);
            //mock.Verify();
            mock.Verify(m => m.Zoek(402), Times.Exactly(2900));
        }
    }
}
