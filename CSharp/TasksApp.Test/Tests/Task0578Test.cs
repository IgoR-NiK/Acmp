using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0578Test
    {
        private static void CheckTest(int n, string result)
        {
            var solution = Task0578.Solve(n);
            Assert.AreEqual(result, solution);
        }

        [Test]
        public void Test1()
        {
	        CheckTest(7, "21");
        }

		[Test]
		public void Test2()
		{
			CheckTest(22, "211");
		}
		
		[Test]
		public void Test3()
		{
			CheckTest(4, "11");
		}
		
		[Test]
		public void Test4()
		{
			CheckTest(3, "3");
		}
		
		[Test]
		public void Test5()
		{
			CheckTest(6, "13");
		}
    }
}