using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0459Test
    {
        private void CheckTest(string input, string output)
        {
            var test = Task0459.Solve(input);
            Assert.AreEqual(test, output);
        }

        [Test]
        public void Test1()
        {
            CheckTest("EENNESWSSWE", "NWW");
        }

        [Test]
        public void Test2()
        {
            CheckTest("EWSN", "");
        }

        [Test]
        public void Test3()
        {
            CheckTest("EEWWSNSNS", "N");
        }

        [Test]
        public void Test4()
        {
            CheckTest("NWS", "NES");
        }
    }
}
