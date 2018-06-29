using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0033Test
    {
		private void CheckTest(int a, int b, Task0033.Result result)
        {
            var test = Task0033.Solve(a, b);
            Assert.AreEqual(test.A, result.A);
			Assert.AreEqual(test.B, result.B);
        }

        [TestMethod]
        public void Test1()
        {
			CheckTest(4, 7, new Task0033.Result() { A = 6, B = 3 });
        }
    }
}