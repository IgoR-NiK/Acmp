using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task1006Test
    {
        private void CheckTest(string input, string result)
        {
            var actual = Task1006.Solve(input);
			Assert.AreEqual(result, actual);
        }

        [Test]
        public void Test1()
        {
            CheckTest("blackblackgreen", "black\nblack\nGREEN");
        }
        
        [Test]
        public void Test2()
        {
            CheckTest("blackYELLOWblack", "black\nYELLOW\nblack");
        }
        
        [Test]
        public void Test3()
        {
            CheckTest("redyellowgreen", "error");
        }
    }
}