using System.Linq;
using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0337Test
    {
        private static void CheckTest(uint n, byte[] p, long result)
        {
            var test = Task0337.Solve(n, p);
            Assert.That(test, Is.EqualTo(result));
        }

        [Test]
        public void Test1()
        {
            CheckTest(20, new byte[] { 2, 3, 8 }, 8);
        }

        [Test]
        public void Test2()
        {
            CheckTest(172, new byte[] { 19, 2, 7, 13, 40, 23, 16, 1, 45, 9 }, 99);
        }

        [Test]
        public void Test3()
        {
            CheckTest(30, new byte[] { 2, 4, 6, 12, 24 }, 6);
        }

        [Test]
        public void Test4()
        {
            CheckTest(30, new byte[] { 24, 2, 4, 6, 12, 24 }, 5);
        }

        [Test]
        public void Test5()
        {
            CheckTest(30, new byte[] { 24, 2, 4, 2, 4, 4, 2, 24, 1, 6, 12, 24 }, 24);
        }

        [Test]
        public void Test6()
        {
            CheckTest(30, new byte[] { 2, 4, 6, 12, 24, 24 }, 5);
        }

        [Test]
        public void Test7()
        {
            CheckTest(30, new byte[] { 2, 4, 6, 12 }, 5);
        }

        [Test]
        public void Test8()
        {
            CheckTest(7, new byte[] { 2, 3, 6 }, 4);
        }

        [Test]
        public void Test9()
        {
            CheckTest(1000000000, Enumerable.Range(2, 48).Select(x => (byte)x).ToArray(), 559399565);
        }
    }
}
