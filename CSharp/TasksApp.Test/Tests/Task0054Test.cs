using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0054Test
    {
        private void CheckTest(int n, int m, int[,] field, Task0054.Result result)
        {
            var test = Task0054.Solve(n, m, field);
			Assert.AreEqual(test.Max, result.Max);
			Assert.AreEqual(test.Min, result.Min);
        }

        [TestMethod]
        public void Test1()
        {
			CheckTest(3, 3, new[,] { { 4, -1, -3 }, {-2, 1, 3}, {0, 2, -3} }, new Task0054.Result() { Min = -2, Max = 2 });
        }

        [TestMethod]
        public void Test2()
        {
			CheckTest(3, 4, new[,] { { -1, 0, 2, 1 }, { -2, 0, 1, 0 }, { 2, 1, -1, -2, } }, new Task0054.Result() { Min = -1, Max = 1 });
        }
    }
}