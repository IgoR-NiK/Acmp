using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0459Test
    {
        private void CheckTest(string input, string output)
        {
            var test = Task0459.Solve(input);
            Assert.AreEqual(test, output);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest("EENNESWSSWE", "NWW");
        }

        [TestMethod]
        public void Test2()
        {
            CheckTest("EWSN", "");
        }

        [TestMethod]
        public void Test3()
        {
            CheckTest("EEWWSNSNS", "N");
        }

        [TestMethod]
        public void Test4()
        {
            CheckTest("NWS", "NES");
        }
    }
}
