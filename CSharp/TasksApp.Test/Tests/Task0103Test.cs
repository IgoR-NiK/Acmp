using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0103Test
    {
        private void CheckTest(string a, string b, string result)
        {			
			var bigIntegerA = new Task0103.BigInteger(a);
            var bigIntegerB = new Task0103.BigInteger(b);
            var bigInteger = new Task0103.BigInteger(result);
            var test = Task0103.Solve(bigIntegerA, bigIntegerB);
			Assert.AreEqual(test.CompareTo(bigInteger), 0);
        }

        [Test]
        public void Test1()
        {
			CheckTest("2", "3", "5");
        }
    }
}