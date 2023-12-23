using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0700Test
    {
        private static void CheckTest(int n, int v, int k, Task0700.Result result)
        {
            var solution = Task0700.Solve(n, v, k);
            
			Assert.That(result.IsEmpty, Is.EqualTo(solution.IsEmpty));
			Assert.That(result.Volume, Is.EqualTo(solution.Volume));
        }

        [Test]
        public void Test1()
        {
	        CheckTest(15, 100, 10, new Task0700.Result { IsEmpty = true, Volume = 550 });
        }

		[Test]
		public void Test2()
		{
			CheckTest(10, 10, 1, new Task0700.Result { IsEmpty = false, Volume = 55 });
		}
    }
}