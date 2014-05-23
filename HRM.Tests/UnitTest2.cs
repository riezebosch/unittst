using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.IO;

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

        public interface IInterface
        {
            void Dummy(FileInfo f);
        }

        [TestMethod]
        public void MoqSetupQuiz_Fail()
        {
            var mock = new Mock<IInterface>(MockBehavior.Strict);
            mock.Setup(m => m.Dummy(new FileInfo("C:\\temp\\temp.log")));

            mock.Object.Dummy(new FileInfo("C:\\temp\\temp.log"));
        }


        [TestMethod]
        public void MoqSetupQuiz_Succeed()
        {
            // Omdat nu de reference gelijk is die door de 
            // setup en uitvoering gedeeld wordt en daarmee
            // een match is.
            var fi = new FileInfo("C:\\temp\\temp.log");
            var mock = new Mock<IInterface>(MockBehavior.Strict);
            mock.Setup(m => m.Dummy(fi));

            mock.Object.Dummy(fi);
        }


    }
}
