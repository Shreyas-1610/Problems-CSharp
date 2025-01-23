using FirstDemo;

namespace FirstDemoTests
{
    public class Tests
    {
        private Smallest first;
        private Sum sum;
        private Bubble bubble;
        private Reverse reverse;
        private MoveZeros moveZeros;
        [SetUp]
        public void Setup()
        {
            first = new Smallest();
            sum = new Sum();
            bubble = new Bubble();
            reverse = new Reverse();
            moveZeros = new MoveZeros();
        }

        [Test]
        public void Test1()
        {
            int[] arr = { 2, 3, 5, 1, 77, 11 };
            int expected = 1;

            var actual = first.Difference(arr);
            Assert.That(expected, Is.EqualTo(actual));
        }

        [TestCase(new int[]{ 10,20,30},60)]
        [TestCase(new int[] {1,2,3,4,5,10},25)]
        public void Test2(int[] arr, int expected)
        {
            var actual = sum.ArraySum(arr);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test3()
        {
            int[] arr = { 1, 3, 2, 55, 4 };    
            bubble.Sort(arr);
            int[] expected = { 1, 2, 3, 4, 55 };
            Assert.That(arr, Is.EqualTo(expected));
        }

        [Test]
        public void Test4()
        {
            string str = "I am going";
            string expected = "going am I";
            var result = reverse.Words(str);

            Assert.That(expected, Is.EqualTo(result));
        }
        [Test]
        public void Test5()
        {
            int[] arr = { 1, 0, 3, 4, 2, 0 };
            moveZeros.move(arr);
            int[] expected = { 1, 3, 4, 2, 0, 0 };
            CollectionAssert.AreEqual(arr, expected);
        }
    }
}