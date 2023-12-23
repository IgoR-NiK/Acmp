using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0839Test
    {
        private static void CheckTest(string input, bool result)
        {
            var resultTest = Task0839.Solve(input);
            Assert.That(resultTest, Is.EqualTo(result));
		}

        [Test]
        public void Test1()
        {
            CheckTest("11111101010011", false);
        }

        [Test]
        public void Test2()
        {
            CheckTest("11", true);
        }
	}
}
