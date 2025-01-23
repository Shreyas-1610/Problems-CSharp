using FirstDemo;
using System.Collections.Generic;

namespace FirstDemoMsTest
{
    [TestClass]
    public class Test1
    {
        private Smallest smallest;
        private Sum sum;
        private Bubble bubble;
        private Reverse reverse;
        private MoveZeros moveZeros;

        [TestInitialize]
        public void Initalize()
        {
            smallest = new Smallest();
            sum = new Sum();
            bubble = new Bubble();
            reverse = new Reverse();
            moveZeros = new MoveZeros();
        }

        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = { 2, 3, 5, 1, 77, 11 };
            int expected = 1;

            var actual = smallest.Difference(arr);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(new int[] { 21, 2, 5, 7, 1 }, 36)]
        public void TestMethod2(int[] arr, int expected)
        {
            var actual = sum.ArraySum(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] arr = { 1, 3, 2, 55, 4 };
            bubble.Sort(arr);
            int[] expected = { 1, 2, 3, 4, 55 };
            CollectionAssert.AreEqual(arr, expected);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string str = "I am going";
            string expected = "going am I";
            var result = reverse.Words(str);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int[] arr = { 1, 0, 3, 4, 2, 0 };
            moveZeros.move(arr);
            int[] expected = { 1, 3, 4, 2, 0, 0 };
            CollectionAssert.AreEqual(arr, expected);
        }
    }
}
