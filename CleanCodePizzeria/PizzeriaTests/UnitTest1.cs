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
                "Margerita - Ost, tomats�s - 85kr", 
                "Hawaii, Ost, tomats�s, skinka, ananas - 95kr", 
                "Kebabpizza - Ost, tomats�s, kebab, champinjoner, l�k, feferoni, isbergssallad, tomat, kebabs�s - 105kr",
                "Quatro Stagioni - Ost, tomats�s, skinka, r�kor, musslor, champinjoner, kron�rtskocka - 115kr"
            };

            Assert.AreEqual(expected, actual); 
        }

        [TestMethod]
        public void GetAllBeverageEntriesTest()
        {
            var p = new Program();

            var actual = p.GetPizzaMenuEntries();
            var expected = new[] {
                "Coca Cola - 20kr",
                "Fanta - 20kr",
                "Sprite - 25kr",
                "Quatro Stagioni - Ost, tomats�s, skinka, r�kor, musslor, champinjoner, kron�rtskocka - 115kr"
            };

            Assert.AreEqual(expected, actual);
        }
    }
}
