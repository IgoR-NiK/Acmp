﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0027Test
    {
        private void CheckTest(int w, int h, int n, Task0027.Rectangle[] rectangles, int output)
        {
            var test = Task0027.Solve(w, h, n, rectangles);
            Assert.AreEqual(test, output);
        }

        [TestMethod]
        public void Test1()
        {
            var rectangles = new Task0027.Rectangle[]
            {
                new Task0027.Rectangle()
                {
                    LeftUp = new Task0027.Point() { X = 1, Y = 1},
                    RightDown = new Task0027.Point() { X = 3, Y = 3}
                },
                new Task0027.Rectangle()
                {
                    LeftUp = new Task0027.Point() { X = 2, Y = 2},
                    RightDown = new Task0027.Point() { X = 4, Y = 4}
                }
            };
            CheckTest(5, 5, 2, rectangles, 18);
        }

        [TestMethod]
        public void Test2()
        {
            var rectangles = new Task0027.Rectangle[]
            {
                new Task0027.Rectangle()
                {
                    LeftUp = new Task0027.Point() { X = 0, Y = 0},
                    RightDown = new Task0027.Point() { X = 5, Y = 5}
                },
                new Task0027.Rectangle()
                {
                    LeftUp = new Task0027.Point() { X = 1, Y = 1},
                    RightDown = new Task0027.Point() { X = 4, Y = 4}
                },
                new Task0027.Rectangle()
                {
                    LeftUp = new Task0027.Point() { X = 2, Y = 2},
                    RightDown = new Task0027.Point() { X = 3, Y = 3}
                }
            };
            CheckTest(6, 7, 3, rectangles, 17);
        }
    }
}