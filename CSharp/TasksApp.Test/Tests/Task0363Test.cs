using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0363Test
    {
        private static void CheckTest(Task0363.BigInteger m, Task0363.BigInteger n, Task0363.BigInteger result)
        {			
            var test = Task0363.Solve(m, n);
			Assert.AreEqual(test.CompareTo(result), 0);
        }

        [Test]
        public void Test1()
        {
	        CheckTest(
		        new Task0363.BigInteger("5"),
		        new Task0363.BigInteger("7"),
		        new Task0363.BigInteger("35"));
        }

		[Test]
		public void Test2()
		{
			CheckTest(
				new Task0363.BigInteger("4134937827592"),
				new Task0363.BigInteger("784"),
				new Task0363.BigInteger("3241791256832128"));
		}

		[Test]
		public void Test3()
		{
			CheckTest(
				new Task0363.BigInteger("9876543210"),
				new Task0363.BigInteger("1023456789"),
				new Task0363.BigInteger("10108215200126352690"));
		}
    }
}