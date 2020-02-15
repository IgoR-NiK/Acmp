using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0081Test
    {
        private void CheckTest(int[] input, Task0081.Result result)
        {
            var resultTest = Task0081.Solve(input);
            Assert.AreEqual(resultTest.Max, result.Max);
            Assert.AreEqual(resultTest.Min, result.Min);
        }

        [Test]
        public void Test1()
        {
            CheckTest(new[] { 5, 1, 6, 5, 9 }, new Task0081.Result() { Max = 9, Min = 1 });
        }
    }
}