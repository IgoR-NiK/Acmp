﻿using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0554Test
    {
        private static void CheckTest(int n, int result)
        {
            var resultTest = Task0554.Solve(n);
            Assert.That(resultTest, Is.EqualTo(result));
        }

        [Test]
        public void Test1()
        {
            CheckTest(2, 4);
        }

		[Test]
		public void Test2()
		{
			CheckTest(3, 7);
		}
	}
}
