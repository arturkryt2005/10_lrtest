using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _10_lr;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] ojidaemaya = new int[] { 3, 7, 1, 6, 9, 12 };
            int[] expected = new int[] { 1, 3, 6, 7, 9, 12 };
            Bubble.BubbleS(ojidaemaya);
            CollectionAssert.AreEqual(expected, ojidaemaya);
        }
    }
}
