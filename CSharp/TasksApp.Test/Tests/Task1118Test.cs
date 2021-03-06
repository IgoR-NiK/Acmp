﻿using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1118Test
    {
        private void CheckTest(int h, int a, int b, int result)
        {
            var actual = Task1118.Solve(h, a, b);
			Assert.AreEqual(result, actual);
        }

        [Test]
        public void Test1()
        {
            CheckTest(10, 3, 2, 8);
        }
    }
}