using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _10_lr;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] bubbleSort = new int[] { 3, 7, 1, 6, 9, 12 };
            int[] expected = new int[] { 1, 3, 6, 7, 9, 12 };
            var bubble = new Bubble();

            // Act
            bubble.AAlgorithm(bubbleSort);

            // Assert
            CollectionAssert.AreEqual(expected, bubbleSort);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] podrazzz = new int[] { 3, 7, 1, 6, 9, 12 };
            int[] expected = new int[] { 1, 3, 6, 7, 9, 12 };
            var podrazz = new buble();

            // Act
            podrazz.Algorithm(podrazzz);

            // Assert
            CollectionAssert.AreEqual(expected, podrazzz);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] viborSort = new int[] { 6, 2, 3, 1, 4, 5 };
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6 };
            buble.ViborSort(viborSort);
            CollectionAssert.AreEqual(expected, viborSort);
        }

    }
}