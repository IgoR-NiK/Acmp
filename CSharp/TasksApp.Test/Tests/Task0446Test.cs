using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0446Test
    {
        private static void CheckTest(char[,] splash, int[,] board, string result)
        {
            var test = Task0446.Solve(splash, board);
            Assert.AreEqual(result, test);
        }

        [Test]
        public void Test1()
        {
            CheckTest(new[,]
            {
                { '.', 'G', 'B' },
                { 'R', '.', 'B' },
                { 'R', 'G', '.' }
            }, new[,]
            {
                { 0, 1, 2 },
                { 3, 4, 5 },
                { 6, 7, 0 }
            }, "NO");
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(new[,]
            {
                { 'R', 'G', 'B' },
                { '.', 'G', '.' }
            }, new[,]
            {
                { 7, 7, 7 },
                { 7, 7, 7 }
            }, "YES");
        }
    }
}