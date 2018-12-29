using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0754Test
    {
        private void CheckTest(int m1, int m2, int m3, string result)
        {
            var resultTest = Task0754.Solve(m1, m2, m3);
            Assert.AreEqual(resultTest, result);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(98, 106, 214, "214");
        }

        [TestMethod]
        public void Test2()
        {
			CheckTest(100, 100, 100, "100");
		}

		[TestMethod]
		public void Test3()
		{
			CheckTest(93, 500, 1000, "Error");
		}
	}
}
