using System.Linq;
using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0350Test
    {
        private static void CheckTest(string input, string[] result)
        {
            var test = Task0350.Solve(input);
            
            Assert.That(result.Length, Is.EqualTo(test.Length));

            foreach (var res in result)
            {
                var count = test.Count(s => s == res);
                Assert.That(count, Is.EqualTo(1));
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
