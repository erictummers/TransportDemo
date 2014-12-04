using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Voertuig;

namespace Voertuig.unittest
{
    [TestClass]
    public class AutoTest
    {
        [TestMethod]
        public void Vooruit_verplaatst_auto_naar_voren()
        {
            // Arrange
            var testObject = new Auto();

            // Act
            testObject.Vooruit();

            // Assert
            Assert.IsInstanceOfType(testObject.Verplaatsing, typeof(NaarVoren));
        }

        [TestMethod]
        public void Achteruit_verplaatst_auto_naar_achteren()
        {
            // Arrange
            var testObject = new Auto();

            // Act
            testObject.Achteruit();

            // Assert
            Assert.IsInstanceOfType(testObject.Verplaatsing, typeof(NaarAchteren));
        }

        [TestMethod]
        public void Stop_brengt_auto_tot_stilstand()
        {
            // Arrange
            var testObject = new Auto();

            // Act
            testObject.Stop();

            // Assert
            Assert.IsInstanceOfType(testObject.Verplaatsing, typeof(Stilstand));
        }

        [TestMethod]
        [ExpectedException(typeof(Ongeluk))]
        public void Vooruit_indien_auto_naar_achteren_verplaatst_brengt_ongeluk()
        {
            // Arrange
            var testObject = new Auto();
            testObject.Verplaatsing = new NaarAchteren();

            // Act
            testObject.Vooruit();

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(Ongeluk))]
        public void Achteruit_indien_auto_naar_voren_verplaatst_brengt_ongeluk()
        {
            // Arrange
            var testObject = new Auto();
            testObject.Verplaatsing = new NaarVoren();

            // Act
            testObject.Achteruit();

            // Assert

        }

        [TestMethod]
        public void Vooruit_indien_auto_naar_achteren_verplaatst_geen_ongeluk_indien_thestig()
        {
            // Arrange
            var testObject = new Auto();
            testObject.Verplaatsing = new NaarAchteren();
            testObject.Bestuurder = "the stig";

            // Act
            testObject.Vooruit();

            // Assert
            Assert.IsInstanceOfType(testObject.Verplaatsing, typeof(NaarVoren));
        }
    }
}
