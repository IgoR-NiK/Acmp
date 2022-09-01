using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0940Test
    {
        private static void CheckTest(int k, string word, string result)
        {
            var test = Task0940.Solve(k, word);
			Assert.AreEqual(test, result);
        }

        [Test]
        public void Test1()
        {
			CheckTest(4, "MISTSPELL", "MISSPELL");
        }

		[Test]
		public void Test2()
		{
			CheckTest(2, "ABC", "AC");
		}
    }
}