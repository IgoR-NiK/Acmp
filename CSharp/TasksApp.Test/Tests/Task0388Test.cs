using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0388Test
    {
        private static void CheckTest(int[,] field, int result)
        {
            var test = Task0388.Solve(field);

            Assert.That(result, Is.EqualTo(test));
        }

        [Test]
        public void Test1()
        {
            CheckTest(new[,]
            {
                { 0, 0 },
                { 0, 0 }
            }, 4);
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(new[,]
            {
                { 1, 2 },
                { 3, 4 }
            }, 1);
        }
    }
}