﻿using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0539Test
    {
        private void CheckTest(int n, int result)
        {
            var resultTest = Task0539.Solve(n);
            Assert.AreEqual(resultTest, result);
        }

        [Test]
        public void Test1()
        {
            CheckTest(2, 1);
        }

		[Test]
		public void Test2()
		{
			CheckTest(1, 0);
		}

		[Test]
		public void Test3()
		{
			CheckTest(3, 3);
		}
	}
}
