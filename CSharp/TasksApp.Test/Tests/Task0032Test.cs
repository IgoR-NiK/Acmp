using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0032Test
    {
		private void CheckTest(int a, int b, int result)
        {
            var test = Task0032.Solve(a, b);
            Assert.AreEqual(result, test);
        }

        [TestMethod]
        public void Test1()
        {
			CheckTest(18, 10, 71);
        }
        
        [TestMethod]
        public void Test2()
        {
            CheckTest(1, -23, 33);
        }
    }
}