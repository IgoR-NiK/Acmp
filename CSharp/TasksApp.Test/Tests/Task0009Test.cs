using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0009Test
    {
        private void CheckTest(int n, int[] array, Result output)
        {
            var test = Task0009.Solve(n, array);
            Assert.AreEqual(test.Sum, output.Sum);
            Assert.AreEqual(test.Mul, output.Mul);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(5, new []{ -7, 5, -1, 3, 9 }, new Result { Sum = 17, Mul = -15 });
        }

        [TestMethod]
        public void Test2()
        {
            CheckTest(8, new[] { 3, 14, -9, 4, -5, 1, -12, 4 }, new Result { Sum = 26, Mul = 180 });
        }

        [TestMethod]
        public void Test3()
        {
            CheckTest(10, new[] { -5, 1, 2, 3, 4, 5, 6, 7, 8, -3 }, new Result { Sum = 36, Mul = 5040 });
        }
    }
}