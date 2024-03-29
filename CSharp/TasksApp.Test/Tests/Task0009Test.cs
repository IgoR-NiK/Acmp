﻿using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0009Test
    {
        private static void CheckTest(int n, int[] array, Result output)
        {
            var test = Task0009.Solve(n, array);
            Assert.That(test.Sum, Is.EqualTo(output.Sum));
            Assert.That(test.Mul, Is.EqualTo(output.Mul));
        }

        [Test]
        public void Test1()
        {
            CheckTest(5, new []{ -7, 5, -1, 3, 9 }, new Result { Sum = 17, Mul = -15 });
        }

        [Test]
        public void Test2()
        {
            CheckTest(8, new[] { 3, 14, -9, 4, -5, 1, -12, 4 }, new Result { Sum = 26, Mul = 180 });
        }

        [Test]
        public void Test3()
        {
            CheckTest(10, new[] { -5, 1, 2, 3, 4, 5, 6, 7, 8, -3 }, new Result { Sum = 36, Mul = 5040 });
        }
    }
}