using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanCodePizzeria;

namespace PizzeriaTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetAllPizzaEntriesTest()
        {
            var p = new Program();

            var actual = p.GetPizzaMenuEntries();
            var expected = new[] { 
                "[1] Margerita - Ost, tomats�s - 85kr", 
                "[2] Hawaii, Ost, tomats�s, skinka, ananas - 95kr", 
                "[3] Kebabpizza - Ost, tomats�s, kebab, champinjoner, l�k, feferoni, isbergssallad, tomat, kebabs�s - 105kr",
                "[4] Quatro Stagioni - Ost, tomats�s, skinka, r�kor, musslor, champinjoner, kron�rtskocka - 115kr"
            };

            Assert.AreEqual(expected, actual); 
        }

        [TestMethod]
        public void GetAllBeverageEntriesTest()
        {
            var p = new Program();

            var actual = p.GetBeverageMenuEntries();
            var expected = new[] {
                "[1] Coca Cola - 20kr",
                "[2] Fanta - 20kr",
                "[3] Sprite - 25kr"
            };

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDatSweetExtraTest()
        {
            var p = new Program();

            var actual = p.GetExtraMenuEntries();
            var expected = new[] {
                "[1] Skinka - 10kr", 
                "[2] Ananas - 10kr", 
                "[3] Champinjoner - 10kr", 
                "[4] L�k - 10kr", 
                "[5] Kebabs�s - 10kr",
                "[6] R�kor - 15kr", 
                "[7] Musslor - 15kr", 
                "[8] Kron�rtskocka - 15kr",
                "[9] Kebab - 20kr", 
                "[0] Koriander - 20kr"
            };

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StartOrderTest()
        {
            var p = new Program();

            var expected = "Order started";
            var actual = p.StartOrder();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddToOrderTest()
        {
            var p = new Program();
            var expected1 = "Item Added: Margerita";
            var expected2 = "Item Added: Kebabpizza + Ost + Kebab";
            p.StartOrder();
            var actual1 = p.AddToOrder("1");
            var actual2 = p.AddToOrder("2");

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void FinishOrderTest()
        {
            var p = new Program();

            var expected = "Order started";
            var actual = p.StartOrder();

            Assert.AreEqual(expected, actual);
        }
    }
}
