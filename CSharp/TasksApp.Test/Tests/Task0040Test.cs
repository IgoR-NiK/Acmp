using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0040Test
    {
        private void CheckTest(int n, string result)
        {			
			var bigInteger = new Task0040.BigInteger(result);
            var test = Task0040.Solve(n);
			Assert.AreEqual(test.CompareTo(bigInteger), 0);
        }

        [Test]
        public void Test1()
        {
			CheckTest(3, "8");
        }

		[Test]
		public void Test2()
		{
			CheckTest(10, "1024");
		}

		[Test]
		public void Test3()
		{
			CheckTest(72, "4722366482869645213696");
		}
    }
}