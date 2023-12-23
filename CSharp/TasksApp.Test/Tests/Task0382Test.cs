using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0382Test
    {
        private static void CheckTest(int[,] field, long result)
        {
            var test = Task0382.Solve(field);

            Assert.That(result, Is.EqualTo(test));
        }

        [Test]
        public void Test1()
        {
            CheckTest(new[,]
            {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 2, 2 },
                { 0, 0, 2, 0, 0 },
                { 0, 0, 2, 2, 2 },
                { 0, 0, 0, 0, 0 }
            }, 550);
        }
    }
}