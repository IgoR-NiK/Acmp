using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0119Test
    {
        private void CheckTest(Task0119.TimeInterval[] input, Task0119.TimeInterval[] result)
        {
            var resultTest = Task0119.Solve(input);

			Assert.AreEqual(resultTest.Length, result.Length);

			var comparer = new Task0119.TimeIntervalComparer();
			for (var i = 0; i < result.Length; i++)
			{
				Assert.AreEqual(comparer.Compare(resultTest[i], result[i]), 0);
			}
        }

        [Test]
        public void Test1()
        {
            CheckTest(new[] 
			{
				new Task0119.TimeInterval() { Hours = 10, Minutes = 20, Seconds = 30 },
				new Task0119.TimeInterval() { Hours = 7, Minutes = 30, Seconds = 0 },
				new Task0119.TimeInterval() { Hours = 23, Minutes = 59, Seconds = 59 },
				new Task0119.TimeInterval() { Hours = 13, Minutes = 30, Seconds = 30 }
			}, new[]
			{
				new Task0119.TimeInterval() { Hours = 7, Minutes = 30, Seconds = 0 },
				new Task0119.TimeInterval() { Hours = 10, Minutes = 20, Seconds = 30 },
				new Task0119.TimeInterval() { Hours = 13, Minutes = 30, Seconds = 30 },
				new Task0119.TimeInterval() { Hours = 23, Minutes = 59, Seconds = 59 },
			});
        }
    }
}
