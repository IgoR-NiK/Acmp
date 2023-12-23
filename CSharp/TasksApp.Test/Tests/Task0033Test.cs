using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0033Test
    {
		private static void CheckTest(int a, int b, Task0033.Result result)
        {
            var test = Task0033.Solve(a, b);
            Assert.That(test.A, Is.EqualTo(result.A));
			Assert.That(test.B, Is.EqualTo(result.B));
        }

        [Test]
        public void Test1()
        {
			CheckTest(4, 7, new Task0033.Result { A = 6, B = 3 });
        }
    }
}