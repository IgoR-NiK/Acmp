using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0275Test
    {
        private static void CheckTest(string[] numbers, string[] result)
        {
            var solution = Task0275.Solve(numbers);
            
            Assert.AreEqual(solution.Length, result.Length);
            for (var i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(result[i], solution[i]);
            }
        }

        [Test]
        public void Test1()
        {
            CheckTest(new[] { "1110", "1010101", "111111111111111111111111111" }, new[] { "Yes", "No", "Yes" });
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(new[] { "11" }, new[] { "No" });
        }
    }
}