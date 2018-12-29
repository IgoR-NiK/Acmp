using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0755Test
    {
        private void CheckTest(int x, int y, int z, string result)
        {
            var resultTest = Task0755.Solve(x, y, z);
            Assert.AreEqual(resultTest, result);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(3, 2, 1, "4");
        }

        [TestMethod]
        public void Test2()
        {
			CheckTest(12, 13, 5, "20");
		}

		[TestMethod]
		public void Test3()
		{
			CheckTest(2, 5, 9, "Impossible");
		}
	}
}
