using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1152Test
    {
        private void CheckTest(string input, string result)
        {
            var actual = Task1152.Solve(input);
			Assert.AreEqual(result, actual);
        }

        [Test]
        public void Test1()
        {
            CheckTest("VisualC", "V#i#s#u#a#l#C");
        }
        
        [Test]
        public void Test2()
        {
            CheckTest("INSERT", "I#N#S#E#R#T");
        }
    }
}