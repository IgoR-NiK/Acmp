using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0413Test
    {
        private static void CheckTest(int[,] field, int result)
        {
            var test = Task0413.Solve(field);

            Assert.That(result, Is.EqualTo(test));
        }

        [Test]
        public void Test1()
        {
            CheckTest(new[,]
            {
                { 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, -1, -1, 0 },
                { 0, 0, 0, -1, -1, 0 },
                { 0, 0, 0, 0, 0, 0 },
                { 0, -1, -1, -1, 0, 0 },
                { 0, -1, -1, -1, 0, 0 },
                { 0, -1, -1, -1, 0, 0 },
                { 0, 0, 0, 0, 0, 0 }
            }, 2);
        }
    }
}