using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0349Test
    {
        private static void CheckTest(int m, int n, List<int> expected)
        {
            var actual = Task0349.Solve(m, n).ToList();
            
            Assert.AreEqual(expected.Count, actual.Count);
            for (var i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [Test]
        public void Test1()
        {
            CheckTest(2, 5, new List<int> { 2, 3, 5 });
        }

        [Test]
        public void Test2()
        {
            CheckTest(4, 4, new List<int>());
        }
    }
}
