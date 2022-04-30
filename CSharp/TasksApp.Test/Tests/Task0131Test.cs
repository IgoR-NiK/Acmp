using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
	[TestFixture]
	public class Task0131Test
	{
		private static void CheckTest(Task0131.Person[] input, int result)
		{
			var resultTest = Task0131.Solve(input);
			Assert.AreEqual(result, resultTest);
		}

		[Test]
		public void Test1()
		{
			CheckTest(new[]
			{
				new Task0131.Person { Age = 25, Gender = 1 },
				new Task0131.Person { Age = 70, Gender = 1 },
				new Task0131.Person { Age = 100, Gender = 0 },
				new Task0131.Person { Age = 3, Gender = 1 }
			}, 2);
		}
	}
}