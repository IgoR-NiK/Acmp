using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0892Test
    {
        private void CheckTest(int n, string result)
        {
            var resultTest = Task0892.Solve(n);
            Assert.AreEqual(resultTest, result);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(3, "Spring");
        }

		[TestMethod]
		public void Test2()
		{
			CheckTest(15, "Error");
		}
	}
}
