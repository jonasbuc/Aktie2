using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aktie;
using System;

namespace Aktie.Tests
{
    [TestClass()]
    public class StockTests
    {
        [TestMethod()]
        public void AfkastTest()
        {
            // Arrange
            var stock = new Stock
            {
                AktieNavn = "Test Aktie",
                KøbsKurs = 100,
                SalgsKurs = 150,
                antalAktier = 10
            };

            // Act
            var result = stock.Afkast();

            // Assert
            Assert.AreEqual(500, result);
        }

        [TestMethod()]
        public void AktieNavnTest()
        {
            // Arrange
            var stock = new Stock();
            var expectedName = "Test Aktie";

            // Act
            stock.AktieNavn = expectedName;

            // Assert
            Assert.AreEqual(expectedName, stock.AktieNavn);
        }

        [TestMethod()]
        public void AntalAktierTest()
        {
            // Arrange
            var stock = new Stock();
            var expectedAntal = 100;

            // Act
            stock.antalAktier = expectedAntal;

            // Assert
            Assert.AreEqual(expectedAntal, stock.antalAktier);
        }

        [TestMethod()]
        public void KøbsKursTest()
        {
            // Arrange
            var stock = new Stock();
            var expectedKøbsKurs = 200;

            // Act
            stock.KøbsKurs = expectedKøbsKurs;

            // Assert
            Assert.AreEqual(expectedKøbsKurs, stock.KøbsKurs);
        }

        [TestMethod()]
        public void SalgsKursTest()
        {
            // Arrange
            var stock = new Stock();
            var expectedSalgsKurs = 250;

            // Act
            stock.SalgsKurs = expectedSalgsKurs;

            // Assert
            Assert.AreEqual(expectedSalgsKurs, stock.SalgsKurs);
        }
    }
}
