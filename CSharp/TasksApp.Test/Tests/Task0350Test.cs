using System.Linq;
using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0350Test
    {
        private void CheckTest(string input, string[] result)
        {
            var test = Task0350.Solve(input);
            
            Assert.AreEqual(result.Length, test.Length);

            foreach (var res in result)
            {
                var count = test.Count(s => s == res);
                Assert.AreEqual(count, 1);
            }
        }

        [Test]
        public void Test1()
        {
            CheckTest("AB", new[]
            {
                "AB",
                "BA"
            });
        }

        [Test]
        public void Test2()
        {
            CheckTest("IOX", new[]
            {
                "XOI",
                "OIX",
                "IXO",
                "XIO",
                "OXI",
                "IOX"
            });
        }
    }
}
