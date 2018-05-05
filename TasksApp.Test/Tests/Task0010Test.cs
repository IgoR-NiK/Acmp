﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0010Test
    {
        private void CheckTest(int a, int b, int c, int d, params int[] output)
        {
            var test = Task0010.Solve(a, b, c, d);

            Assert.AreEqual(test.Count, output.Length);
            for (var i = 0; i < test.Count; i++)
            {
                Assert.AreEqual(test[i], output[i]);
            }
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(1, -3, 0, 0, 0, 3);
        }

        [TestMethod]
        public void Test2()
        {
            CheckTest(3, -15, 18, 0, 0, 2, 3);
        }

        [TestMethod]
        public void Test3()
        {
            CheckTest(1, -7, -33, 135, -5, 3, 9);
        }
    }
}