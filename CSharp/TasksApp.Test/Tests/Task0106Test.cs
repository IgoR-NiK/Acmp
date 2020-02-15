﻿using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0106Test
    {
        private void CheckTest(int[] array, int result)
        {
            var resultTest = Task0106.Solve(array);
            Assert.AreEqual(resultTest, result);
        }

        [Test]
        public void Test1()
        {
            CheckTest(new []{ 1, 0, 1, 1, 0 }, 2);
        }
    }
}