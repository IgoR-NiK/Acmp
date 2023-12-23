using System.Collections.Generic;
using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0365Test
    {
        private static void CheckTest(int n, List<List<int>> output)
        {
            var test = Task0365.Solve(1, n);

            Assert.That(test.Count, Is.EqualTo(output.Count));

            var testHash = test.ConvertAll(Hash);
            var outputHash = output.ConvertAll(Hash);

            foreach (var e in testHash)
            {
                Assert.That(outputHash.Contains(e));
            }
        }

        private static long Hash(List<int> list)
        {
            long sum = 0;
            long mul = 1;

            foreach(var e in list)
            {
                sum += e;
                mul *= e;
            }

            return sum != 0 ? mul % sum : 0;
        }

        [Test]
        public void Test1()
        {
            CheckTest(2, new List<List<int>>
            {
                new List<int> { 1, 1 }
            });
        }

        [Test]
        public void Test2()
        {
            CheckTest(3, new List<List<int>>
            {
                new List<int> { 1, 1, 1 },
                new List<int> { 1, 2 }
            });
        }

        [Test]
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

        [Test]
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