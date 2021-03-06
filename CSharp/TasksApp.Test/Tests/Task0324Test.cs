﻿using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0324Test
    {
        private void CheckTest(string n, string result)
        {
            var solution = Task0324.Solve(n);

            Assert.AreEqual(result, solution);
        }

        [Test]
        public void Test1()
        {
            CheckTest("6116", "YES");
        }

        [Test]
        public void Test2()
        {
            CheckTest("1231", "NO");
        }
    }
}