﻿using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1236Test
    {
        private void CheckTest(int[,] numbers, int[,] result)
        {
            var actual = Task1236.Solve(numbers);
            
			Assert.AreEqual(result.GetLength(0), actual.GetLength(0));
            Assert.AreEqual(result.GetLength(1), actual.GetLength(1));
            
            for (var i = 0; i < result.GetLength(0); i++)
            {
                for (var j = 0; j < result.GetLength(1); j++)
                {
                    Assert.AreEqual(result[i, j], actual[i, j]);
                }
            }
        }

        [Test]
        public void Test1()
        {
            CheckTest(new[,]
            {
                { 5, 9, 2, 6 },
                { 6, 2, 4, 3 },
                { 1, 2, 8, 7 }
            }, new[,]
            {
                { 1, 2, 8, 7 },
                { 6, 2, 4, 3 },
                { 5, 9, 2, 6 }
            });
        }
    }
}