using System.Linq;
using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1088Test
    {
        private static void CheckTest(string point1, string point2, string[] results)
        {
            var actual = Task1088.Solve(point1, point2);
			Assert.That(results.Length, Is.EqualTo(actual.Length));

            foreach (var result in results)
            {
                Assert.That(actual.Contains(result));
            }
        }

        [Test]
        public void Test1()
        {
            CheckTest("D3", "D7", new[] { "Queen", "Rook" });
        }
        
        [Test]
        public void Test2()
        {
            CheckTest("F4", "H5", new[] { "Knight" });
        }
        
        [Test]
        public void Test3()
        {
            CheckTest("E2", "E3", new[] { "King", "Queen", "Rook", "Pawn" });
        }
        
        [Test]
        public void Test4()
        {
            CheckTest("A1", "H7", new[] { "Nobody" });
        }
    }
}