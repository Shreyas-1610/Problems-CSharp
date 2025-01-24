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
        private Average average;
        private Line line;

        [TestInitialize]
        public void Initalize()
        {
            smallest = new Smallest();
            sum = new Sum();
            bubble = new Bubble();
            reverse = new Reverse();
            moveZeros = new MoveZeros();
            average = new Average();
            line = new Line();
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

        [TestMethod]
        [DataRow(new float[] {2.5F,3.5F,1.5F,2.5F},2.5F)]
        public void TestMethod6(float[] arr, float expected)
        {
            var actual = average.FloatAvg(arr);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(1, 1, 2, 2, 3, 3, true)]
        [DataRow(1, 1, 2, 2, 3, 4, false)]
        public void TestMethod7(int x1,int y1, int x2, int y2, int x3, int y3, bool expected)
        {
            var actual = line.FindSingleLine(x1, y1, x2, y2, x3, y3);
            Assert.AreEqual(expected, actual);
        }
    }
}
