using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0082Test
    {
        private void CheckTest(int[] arrayN, int[] arrayM, int[] result)
        {
            var resultTest = Task0082.Solve(arrayN, arrayM);

            for (var i = 0; i < resultTest.Length; i++)
            {
                Assert.AreEqual(resultTest[i], result[i]);
            }
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(new [] { 2, 4, 6, 8, 10, 12, 10, 8, 6, 4, 2 }, new [] { 3, 6, 9, 12, 15, 18 }, new [] { 6, 12 });
        }
    }
}