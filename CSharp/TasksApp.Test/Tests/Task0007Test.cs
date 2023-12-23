using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0007Test
    {
        private static void CheckTest(string a, string b, string c, string output)
        {
            var test = Task0007.Solve(a, b, c);
            Assert.That(test, Is.EqualTo(output));
        }

        [Test]
        public void Test1()
        {
            CheckTest("5", "7", "3", "7");
        }   

        [Test]
        public void Test2()
        {
            CheckTest("987531", "234", "86364", "987531");
        }

        [Test]
        public void Test3()
        {
            CheckTest("189285", "283", "4958439238923098349024", "4958439238923098349024");
        }
    }
}