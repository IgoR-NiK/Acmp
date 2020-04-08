using System.Linq;
using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0561Test
    {
        private void CheckTest(Task0561.Tower[] towers, int[] result)
        {
            var solution = Task0561.Solve(towers).ToArray();

            Assert.AreEqual(solution.Length, result.Length);
            for (var i = 0; i < result.Length; i++)
                Assert.AreEqual(solution[i], result[i]);
        }

        [Test]
        public void Test1()
        {
            CheckTest(new[]
            {
                new Task0561.Tower(1, 2, 2, 2, 2, 2),
                new Task0561.Tower(2, 2, 2),
                new Task0561.Tower(3, 3, 2),
                new Task0561.Tower(4, 2, 3),
                new Task0561.Tower(5, 2, 2, 2, 2),
                new Task0561.Tower(6, 2, 2, 2),
                new Task0561.Tower(7, 3, 3),
                new Task0561.Tower(8, 3, 3, 3, 3),
                new Task0561.Tower(9, 4, 3, 3),
                new Task0561.Tower(10, 2, 3, 4)
            }, new[] { 2, 4, 3, 6, 7, 5, 9, 10, 1, 8 });
        }
    }
}