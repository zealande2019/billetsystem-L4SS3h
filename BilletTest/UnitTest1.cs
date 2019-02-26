using System;
using BilletLibrary;
using StoreBaeltLibrary;
using OersundLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PrisBilTest()
        {
            var bil = new Bil("a", DateTime.MinValue);
            double pris = bil.Pris();
            Assert.AreEqual(240, pris);
        }

        [TestMethod]
        public void TypeBilTest()
        {
            //Arrange
            var bil = new Bil("b", DateTime.MaxValue);
            //Act
            string type = bil.Type();
            //Assert
            Assert.AreEqual("bil", type);
        }
        [TestMethod]
        public void BroBizzBilTest()
        {
            var bil = new Bil("c", DateTime.MaxValue);
            double pris = bil.Pris();
            Assert.AreEqual(240 * 0.95, pris);
        }
        [TestMethod]
        public void PrisMcTest()
        {
            var mc = new Mc("d", DateTime.MinValue);
            double pris = mc.Pris();
            Assert.AreEqual(125, pris);
        }

        [TestMethod]
        public void TypeMcTest()
        {
            var mc = new Mc("e", DateTime.MaxValue);
            string type = mc.Type();
            Assert.AreEqual("mc", type);
        }
        [TestMethod]
        public void BroBizzMcTest()
        {
            var mc = new Mc("f", DateTime.MaxValue);
            double pris = mc.Pris();
            Assert.AreEqual(125 * 0.95, pris);
        }

        [TestMethod]
        public void StorebaeltRabat()
        {
            var bil = new Bil("g", new DateTime(2019, 2, 24));
            Storebaeltrabat weekend = new Storebaeltrabat();
            double pris = weekend.Weekend(bil);
            Assert.AreEqual(240 * 0.8, pris);
        }

        [TestMethod]
        public void StorebaeltRabatMedBrobizzBil()
        {
            var bil = new Bil("g", new DateTime(2019, 2, 24));
            Storebaeltrabat rabat = new Storebaeltrabat();
            double pris = rabat.Weekend(bil);
            Assert.AreEqual(240 * 0.8 * 0.95, pris, 0.09);
        }
        

        [TestMethod]
        public void OresundBilPris()
        {
            var bil = new Bil("h", new DateTime(2019, 2, 24));
            OersundPris pris = new OersundPris();
            double bilPris = pris.Pris(bil);
            Assert.AreEqual(410, bilPris);
        }

        [TestMethod]
        public void OresundMcPris()
        {
            var mc = new Mc("i", new DateTime(2019, 2, 24));
            OersundPris pris = new OersundPris();
            double mcPris = pris.Pris(mc);
            Assert.AreEqual(210, mcPris);
        }

        [TestMethod]
        public void OresundBilPrisMedBrobizz()
        {
            var bil = new Bil("j", new DateTime(2019, 2, 24));
            OersundPris pris = new OersundPris();
            double bilPris = pris.Pris(bil);
            Assert.AreEqual(161, bilPris);
        }

        [TestMethod]
        public void OresundMcPrisMedBrobizz()
        {
            var mc = new Mc("k", new DateTime(2019, 2, 24));
            OersundPris pris = new OersundPris();
            double mcPris = pris.Pris(mc);
            Assert.AreEqual(73, mcPris);
        }

        [TestMethod]
        public void TypeMcTestOersund()
        {
            var mc = new Mc("l", new DateTime(2019, 2, 24));
            OersundPris typeKoertøj = new OersundPris();
            string type = typeKoertøj.Type(mc);
            Assert.AreEqual("øresund mc", type);
        }
        [TestMethod]
        public void TypeBilTestOersund()
        {
            var bil = new Bil("m", new DateTime(2019, 2, 24));
            OersundPris typeKoertøj = new OersundPris();
            string type = typeKoertøj.Type(bil);
            Assert.AreEqual("øresund bil", type);
        }

    }
}
