using System;
using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0550Test
    {
        private static void CheckTest(int n, DateTime result)
        {
            var resultTest = Task0550.Solve(n);
            Assert.That(resultTest, Is.EqualTo(result));
        }

        [Test]
        public void Test1()
        {
            CheckTest(2000, new DateTime(2000, 09, 12));
        }

		[Test]
		public void Test2()
		{
			CheckTest(2009, new DateTime(2009, 09, 13));
		}
	}
}
