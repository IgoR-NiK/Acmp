﻿using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1146Test
    {
        private static void CheckTest(char input, string result)
        {
            var actual = Task1146.Solve(input);
			Assert.That(result, Is.EqualTo(actual));
        }

        [Test]
        public void Test1()
        {
            CheckTest('5', "Yes");
        }
        
        [Test]
        public void Test2()
        {
            CheckTest('A', "No");
        }
    }
}