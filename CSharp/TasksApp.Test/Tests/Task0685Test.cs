using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0685Test
    {
        private void CheckTest(int[] a, int[] b, int result)
        {
            var resultTest = Task0685.Solve(a, b);
            Assert.AreEqual(resultTest, result);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(new[] { 1, 2, 3 }, new[] { 3, 2, 1 }, 14);
        }		
	}
}