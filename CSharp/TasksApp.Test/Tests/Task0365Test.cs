using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0365Test
    {
        private void CheckTest(int n, List<List<int>> output)
        {
            var test = Task0365.Solve(1, n);

            Assert.AreEqual(test.Count, output.Count);

            var testHash = calculateHash(test);
            var outputHash = calculateHash(output);

            foreach (var e in testHash)
            {
                Assert.IsTrue(outputHash.Contains(e));
            }
        }

        private List<long> calculateHash(List<List<int>> test)
        {
            return test.ConvertAll(x => Hash(x));
        }

        private long Hash(List<int> list)
        {
            long sum = 0;
            long mul = 1;

            foreach(var e in list)
            {
                sum += e;
                mul *= e;
            }

            return mul % sum;
        }

        [TestMethod]
        public void Test1()
        {
            CheckTest(2, new List<List<int>>
            {
                new List<int> { 1, 1 }
            });
        }

        [TestMethod]
        public void Test2()
        {
            CheckTest(3, new List<List<int>>
            {
                new List<int> { 1, 1, 1 },
                new List<int> { 1, 2 }
            });
        }

        [TestMethod]
        public void Test3()
        {
            CheckTest(4, new List<List<int>>
            {
                new List<int> { 1, 1, 1, 1 },
                new List<int> { 1, 2, 1 },
                new List<int> { 1, 3 },
                new List<int> { 2, 2 }
            });
        }

        [TestMethod]
        public void Test4()
        {
            CheckTest(5, new List<List<int>>
            {
                new List<int> { 1, 1, 1, 1, 1 },
                new List<int> { 1, 1, 1, 2 },
                new List<int> { 1, 1, 3 },
                new List<int> { 1, 2, 2 },
                new List<int> { 2, 3 },
                new List<int> { 1, 4 }
            });
        }
    }
}