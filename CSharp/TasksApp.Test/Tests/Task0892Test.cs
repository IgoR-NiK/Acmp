﻿using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0892Test
    {
        private static void CheckTest(int n, string result)
        {
            var resultTest = Task0892.Solve(n);
            Assert.That(resultTest, Is.EqualTo(result));
        }

        [Test]
        public void Test1()
        {
            CheckTest(3, "Spring");
        }

		[Test]
		public void Test2()
		{
			CheckTest(15, "Error");
		}
	}
}
