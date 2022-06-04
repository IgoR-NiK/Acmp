using System.Linq;
using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0178Test
    {
        private static void CheckTest(int[] numbers, int[] result)
        {
            var solution = Task0178.Solve(numbers).ToArray();

            for (var i = 0; i < solution.Length; i++)
            {
                Assert.AreEqual(result[i], solution[i]);
            }
            
        }

        [Test]
        public void Test1()
        {
            CheckTest(new[] { 1, 2, 3, 2, 3, 1, 2 }, new[] { 1, 3, 3, 1, 2, 2, 2 });
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(new[] { 1, 1, 2, 2, 3, 3 }, new[] { 2, 2, 3, 3, 1, 1 });
        }
        
        [Test]
        public void Test3()
        {
            CheckTest(new[] { 5 }, new[] { 5 });
        }
        
        [Test]
        public void Test4()
        {
            CheckTest(new[] { 3, 5 }, new[] { 5, 3 });
        }
        
        [Test]
        public void Test5()
        {
            CheckTest(new[] { 5, 3 }, new[] { 5, 3 });
        }
        
        [Test]
        public void Test6()
        {
            CheckTest(new[] { -10, 9, 5, 9, 5, -10 }, new[] { 9, 5, 9, 5, -10, -10 });
        }
    }
}