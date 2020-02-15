﻿using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0032Test
    {
		private void CheckTest(int a, int b, int result)
        {
            var test = Task0032.Solve(a, b);
            Assert.AreEqual(result, test);
        }

        [Test]
        public void Test1()
        {
			CheckTest(18, 10, 71);
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(1, -23, 33);
        }
    }
}