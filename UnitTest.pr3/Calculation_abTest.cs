using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.CompilerServices;
using WindowsFormsApp1.pr3;

namespace UnitTest.pr3
{

    [TestClass]
    public class Calculation_abTest
    {
        [TestMethod]
        public void calc_a_gr_b()
        {
            var calc = new Calculation_ab(3, 2);

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => calc.Sun());
        }

        [TestMethod]
        public void calc_a_eq_b()
        {
            var calc = new Calculation_ab(3, 3);
            var testRez = 0;

            var rez = calc.Sun();

            Assert.AreEqual(testRez, rez);

        }

        [TestMethod]
        public void calc_neg_poz()
        {
            var calc = new Calculation_ab(-10, 100);
            var testRez = 77;

            var rez = calc.Sun();

            Assert.AreEqual(testRez, rez);

        }


    }
}
