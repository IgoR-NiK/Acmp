using System.Collections.Generic;
using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0382Test
    {
        private void CheckTest(int[,] field, long result)
        {
            var test = Task0382.Solve(field);

            Assert.AreEqual(result, test);
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