using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0066Test
    {
        private static void CheckTest(char s, char result)
        {
            var resultTest = Task0066.Solve(s);
            Assert.That(result, Is.EqualTo(resultTest));
        }

        [Test]
        public void Test1()
        {
            CheckTest('q', 'w');
        }

        [Test]
        public void Test2()
        {
            CheckTest('t', 'y');
        }
        
        [Test]
        public void Test3()
        {
            CheckTest('p', 'a');
        }
        
        [Test]
        public void Test4()
        {
            CheckTest('l', 'z');
        }
        
        [Test]
        public void Test5()
        {
            CheckTest('m', 'q');
        }
    }
}