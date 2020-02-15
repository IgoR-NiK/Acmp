using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0819Test
    {
        private void CheckTest(int a, int b, int c, Task0819.Result result)
        {
            var resultTest = Task0819.Solve(a, b, c);
            Assert.AreEqual(resultTest.S, result.S);
			Assert.AreEqual(resultTest.V, result.V);
		}

        [Test]
        public void Test1()
        {
            CheckTest(1, 1, 1, new Task0819.Result() { S = 6, V = 1 });
        }

        [Test]
        public void Test2()
        {
            CheckTest(2, 3, 4, new Task0819.Result() { S = 52, V = 24 });
        }

		[Test]
		public void Test3()
		{
			CheckTest(10000, 10000, 10000, new Task0819.Result() { S = 600000000, V = 1000000000000 });
		}
	}
}
