using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0174Test
    {
        private static void CheckTest(double[] b, double a, string result)
        {
            var solution = Task0174.Solve(b, a);
            Assert.That(result, Is.EqualTo(solution));
        }

        [Test]
        public void Test1()
        {
            CheckTest(new double[] { 5, 10 }, 5, "7.500000");
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(new double[] { 1, 3, 2 }, 0, "2.125000");
        }
    }
}