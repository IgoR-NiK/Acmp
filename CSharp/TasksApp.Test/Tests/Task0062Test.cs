﻿using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0062Test
    {
        private static void CheckTest(string input, string result)
        {
            var resultTest = Task0062.Solve(input);
            Assert.That(resultTest, Is.EqualTo(result));
        }

        [Test]
        public void Test1()
        {
            CheckTest("C3", "BLACK");
        }

        [Test]
        public void Test2()
        {
            CheckTest("G8", "WHITE");
        }
    }
}