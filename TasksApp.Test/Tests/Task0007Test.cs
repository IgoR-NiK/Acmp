﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0007Test
    {
        private void CheckTest(string a, string b, string c, string output)
        {
            var test = Task0007.Solve(a, b, c);
            Assert.AreEqual(test, output);
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest("5", "7", "3", "7");
        }   

        [TestMethod]
        public void Test2()
        {
            CheckTest("987531", "234", "86364", "987531");
        }

        [TestMethod]
        public void Test3()
        {
            CheckTest("189285", "283", "4958439238923098349024", "4958439238923098349024");
        }
    }
}