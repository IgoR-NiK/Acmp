﻿using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0108Test
    {
        private static void CheckTest(int input, int result)
        {
            var resultTest = Task0108.Solve(input);
            Assert.That(resultTest, Is.EqualTo(result));
        }

        [Test]
        public void Test1()
        {
            CheckTest(5, 5);
        }
    }
}
