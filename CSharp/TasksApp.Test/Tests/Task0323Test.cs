﻿using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0323Test
    {
        private static void CheckTest(int n, int result)
        {
            var solution = Task0323.Solve(n);

            Assert.That(result, Is.EqualTo(solution));
        }

        [Test]
        public void Test1()
        {
            CheckTest(6, 3);
        }

        [Test]
        public void Test2()
        {
            CheckTest(992, 73);
        }
    }
}