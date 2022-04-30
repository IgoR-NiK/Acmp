using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0340Test
    {
        private static void CheckTest(Task0340.Box box1, Task0340.Box box2, string result)
        {
            var actual = Task0340.Solve(box1, box2);
            
            Assert.AreEqual(result, actual);
        }

        [Test]
        public void Test1()
        {
            CheckTest(new Task0340.Box(1, 2, 3), new Task0340.Box(3, 2, 1), "Boxes are equal");
        }

        [Test]
        public void Test2()
        {
            CheckTest(new Task0340.Box(2, 2, 3), new Task0340.Box(3, 2, 1), "The first box is larger than the second one");
        }

        [Test]
        public void Test3()
        {
            CheckTest(new Task0340.Box(2, 2, 3), new Task0340.Box(3, 2, 3), "The first box is smaller than the second one");
        }

        [Test]
        public void Test4()
        {
            CheckTest(new Task0340.Box(3, 4, 5), new Task0340.Box(2, 4, 6), "Boxes are incomparable");
        }
    }
}
