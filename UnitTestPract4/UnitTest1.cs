using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using pract4;

namespace UnitTestPract4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var arrayAB = new ArrayAB(100);
            arrayAB.a = new int[] { 1, 2, 33, 4, 5, 6, 7, 8, 9};
            arrayAB.Length = 9;
            arrayAB.Calc();
            CollectionAssert.AreEqual(arrayAB.b, new int[] { 1, 2, 4, 5, 6, 7, 8, 9});
        }
        [TestMethod]
        public void TestMethod2()
        {
            var arrayAB = new ArrayAB(100);
            arrayAB.a = new int[] { 1, 2, 3, 4, 5, 6, 44, 8, 9 };
            arrayAB.Length = 9;
            arrayAB.Calc();
            CollectionAssert.AreEqual(arrayAB.b, new int[] { 1, 2, 3, 4, 5, 6, 8, 9 });
        }
    }
}
