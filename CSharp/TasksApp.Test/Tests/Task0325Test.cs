using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0325Test
    {
        private static void CheckTest(string firstCoordinate, string secondCoordinate, string output)
        {
            var test = Task0325.Solve(firstCoordinate, secondCoordinate);
            Assert.That(test, Is.EqualTo(output));
        }

        [Test]
        public void Test1()
        {
            CheckTest("a1", "h8", "NO");
        }

        [Test]
        public void Test2()
        {
            CheckTest("a1", "b3", "1");
        }

        [Test]
        public void Test3()
        {
            CheckTest("a1", "d4", "2");
        }

        [Test]
        public void Test4()
        {
            CheckTest("c4", "c4", "2");
        }
    }
}
