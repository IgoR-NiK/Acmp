using System.Collections.Generic;
using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0005Test
    {
        private static void CheckTest(Task0005.Output result, string answer, int n, params int[] days)
        {
            var resultTest = Task0005.Solve(n, days);
            
            for(var i = 0; i < resultTest.OddDays.Count; i++)            
                Assert.AreEqual(resultTest.OddDays[i], result.OddDays[i]);

            for (var i = 0; i < resultTest.EvenDays.Count; i++)
                Assert.AreEqual(resultTest.EvenDays[i], result.EvenDays[i]);

            Assert.AreEqual(resultTest.Answer, answer);
        }

        [Test]
        public void Test1()
        {
            var output = new Task0005.Output
            {
                EvenDays = new List<int> { 4, 16, 2 },
                OddDays = new List<int> { 19, 31 }
            };
            CheckTest(output, "YES", 5, 4, 16, 19, 31, 2);
        }

        [Test]
        public void Test2()
        {
            var output = new Task0005.Output
            {
                EvenDays = new List<int> { 4, 12, 24 },
                OddDays = new List<int> { 29, 7, 15, 17, 1 }
            };
            CheckTest(output, "NO", 8, 29, 4, 7, 12, 15, 17, 24, 1);
        }
    }
}
