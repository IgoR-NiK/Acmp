using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0058Test
    {
        private static void CheckTest(Task0058.Set[] inputSet, string[] result)
        {
            var test = Task0058.Solve(inputSet);
            for (var i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(test[i], result[i]);
            }
        }

        [Test]
        public void Test1()
        {
            CheckTest(new[]
                {
                    new Task0058.Set
                    {
                        N = 1,
                        M = 1,
                        Matrix = new [,] { { 0 } }
                    },
                    new  Task0058.Set
                    {
                        N = 4,
                        M = 4,
                        Matrix = new [,] { { 1, 0, 1, 0 }, { 1, 1, 1, 0 }, { 0, 1, 0, 1 }, { 0, 0, 0, 0} }
                    },
                    new Task0058.Set
                    {
                        N =3,
                        M = 3,
                        Matrix = new [,] { { 0, 0, 1 }, { 0, 0, 1 }, { 1, 1, 1 } }
                    }
                }, new[] { "YES", "YES", "NO" });
        }
    }
}