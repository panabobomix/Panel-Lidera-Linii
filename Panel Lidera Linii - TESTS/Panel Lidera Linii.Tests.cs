using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Panel_Lidera_Linii;

namespace Panel_Lidera_Linii___TESTS
{
    /// <summary>
    /// Klasa testowa
    /// </summary>
    [TestClass]
    public class Panel_Lidera_lini_tests

    {
        /// <summary>
        /// Testowanie wpisywania poprawności danych w polu wyszukiwania rdzenia/turbosprężarki
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            bool czy_spelnia = Pomocniczna.popr_kod("%");

            Assert.IsFalse(czy_spelnia);

            czy_spelnia = Pomocniczna.popr_kod("");

            Assert.IsFalse(czy_spelnia);
            czy_spelnia = Pomocniczna.popr_kod("54684548946468714687984646549879464354789465");

            Assert.IsFalse(czy_spelnia);

            czy_spelnia = Pomocniczna.popr_kod("20191014100000000000000000000840");

            Assert.IsTrue(czy_spelnia);


        }
        /// <summary>
        /// Testowanie wpisywania poprawności danych w polu numeru logowania osoby korzystającej z programu
        /// </summary>
        [TestMethod]
        public void Numer_prac()
        {
            

            bool czy_spelnia = Pomocniczna.kod_lid("");

            Assert.IsFalse(czy_spelnia);
           

            czy_spelnia = Pomocniczna.kod_lid("20154");

            Assert.IsTrue(czy_spelnia);


        }


    }
}
