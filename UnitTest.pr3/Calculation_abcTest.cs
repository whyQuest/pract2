using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1.pr3;

namespace UnitTest.pr3
{
    [TestClass]
    public class Calculation_abcTest
    {

        [TestMethod]
        public void TestMethod_yesyesyes()
        {
            var calc = new Calculation_abc(7, 21, 14);

            var testREZ = 12348;

            var rez = calc.D();

            Assert.AreEqual(testREZ, rez);
        }


        [TestMethod]
        public void TestMethod_nonono()
        {
            var calc = new Calculation_abc(5, 8, 13);

            var testREZ = 0;

            var rez = calc.D();

            Assert.AreEqual(testREZ, rez);
        }

    }
}
