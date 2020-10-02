using System.Linq;
using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0354Test
    {
        private void CheckTest(int n, int[] result)
        {
            var test = Task0354.Solve(n);
            
            Assert.AreEqual(result.Length, test.Count());

            var i = 0;
            foreach (var t in test)
            {
                Assert.AreEqual(t, result[i]);
                i++;
            }
        }

        [Test]
        public void Test1()
        {
            CheckTest(5, new[] { 5 });
        }

        [Test]
        public void Test2()
        {
            CheckTest(30, new[] { 2, 3, 5 });
        }
    }
}
