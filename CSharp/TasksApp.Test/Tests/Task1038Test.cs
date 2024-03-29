﻿using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1038Test
    {
        private static void CheckTest(int n, int result)
        {
            var actual = Task1038.Solve(n);
			Assert.That(result, Is.EqualTo(actual));
        }

        [Test]
        public void Test1()
        {
            CheckTest(200, 20);
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(203, 21);
        }
    }
}