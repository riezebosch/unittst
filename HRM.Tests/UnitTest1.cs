using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HRM;

namespace HRM.Tests
{
    class PersoneelsAdministratieMock : HRM.IPersoneelsAdministratie
    {
        public Persoon Persoon { get; set; }



        public PersoneelsAdministratieMock()
        {
            Persoon = new Persoon();
        }

        public Persoon Zoek(int id)
        {
            ZoekWasCalledVlaggetje = true;
            return Persoon;
        }

        public bool ZoekWasCalledVlaggetje { get; set; }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Verhoog_PersoonLangerDan5JaarInDienst_ShouldReturnTrue()
        {
            var salaris = new SalarisAdministratie(new PersoneelsAdministratieMock());
            bool result = salaris.Verhoog(401, 50m);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Verhoog_PersoonKorterDan5JaarInDienst_ShouldReturnFalse()
        {
            // Arrange
            var pa = new PersoneelsAdministratieMock
            {
                Persoon = new Persoon
                {
                    DatumInDienst = new DateTime(2011, 5, 23)
                }
            };
            var salaris = new SalarisAdministratie(pa);

            // Act
            bool result = salaris.Verhoog(401, 50m);

            // Assert
            Assert.IsFalse(result);
            Assert.IsTrue(pa.ZoekWasCalledVlaggetje);
        }
    }
}
