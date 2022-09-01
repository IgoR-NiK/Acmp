using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0948Test
    {
        private static void CheckTest(int k, int n, Task0948.Result result)
        {
            var test = Task0948.Solve(k, n);
			Assert.AreEqual(test, result);
        }

        [Test]
        public void Test1()
        {
			CheckTest(50, 1, new Task0948.Result(1, 1));
        }

		[Test]
		public void Test2()
		{
			CheckTest(20, 25, new Task0948.Result(2, 5));
		}
		
		[Test]
		public void Test3()
		{
			CheckTest(15, 43, new Task0948.Result(3, 13));
		}
		
		[Test]
		public void Test4()
		{
			CheckTest(15, 15, new Task0948.Result(1, 15));
		}
    }
}