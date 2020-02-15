using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0061Test
    {
        private void CheckTest(int[] a, int[] b, string result)
        {
            var resultTest = Task0061.Solve(a, b);
            Assert.AreEqual(resultTest, result);
        }

        [Test]
        public void Test1()
        {
            CheckTest(new[] { 26, 13, 19, 14 }, new[] { 17, 15, 11, 16 }, "1");
        }

        [Test]
        public void Test2()
        {
            CheckTest(new[] { 14, 17, 20, 15 }, new[] { 15, 18, 20, 17 }, "2");
        }

        [Test]
        public void Test3()
        {
            CheckTest(new[] { 15, 18, 10, 14 }, new[] { 16, 17, 12, 12 }, "DRAW");
        }
    }
}