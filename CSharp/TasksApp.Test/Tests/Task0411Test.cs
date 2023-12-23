using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0411Test
    {
        private static void CheckTest(int a, int b, int c, Task0411.Result result)
        {
            var test = Task0411.Solve(a, b, c);

            Assert.That(result.Count, Is.EqualTo(test.Count));
            for (var i = 0; i < result.Roots.Length; i++)
            {
                Assert.That(result.Roots[i], Is.EqualTo(test.Roots[i]));
            }
        }

        [Test]
        public void Test1()
        {
            var result = new Task0411.Result(2);
            result.Roots[0] = 2;
            result.Roots[1] = 1;
            
            CheckTest(1, -3, 2, result);
        }
        
        [Test]
        public void Test2()
        {
            var result = new Task0411.Result(1);
            result.Roots[0] = 6;
            
            CheckTest(0, -1, 6, result);
        }
    }
}