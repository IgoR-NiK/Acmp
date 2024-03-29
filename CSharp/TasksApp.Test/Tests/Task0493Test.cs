﻿using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0493Test
    {
        private static void CheckTest(char[,] field, int result)
        {
            var actual = Task0493.Solve(field);
            
            Assert.That(result, Is.EqualTo(actual));
        }

        [Test]
        public void Test1()
        {
            CheckTest(new [,]
            {
                { '*', '*', '*', '*' },
                { '*', '*', '.', '.' },
                { '*', '.', '.', '.' },
                { '*', '.', '.', '.' }
            }, 4);
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(new [,]
            {
                { '*', '*', '*' },
                { '.', '.', '.' },
                { '.', '.', '.' },
                { '*', '*', '*' }
            }, 0);
        }
    }
}
