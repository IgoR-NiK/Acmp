using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0346Test
    {
        private static void CheckTest(string a, string b, int c, Task0346.Result result)
        {
            var actual = Task0346.Solve(a, b, c);
            
            Assert.That(result.Answer, Is.EqualTo(actual.Answer));
            Assert.That(result.X, Is.EqualTo(actual.X));
            Assert.That(result.Y, Is.EqualTo(actual.Y));
        }

        [Test]
        public void Test1()
        {
            CheckTest("12", "31", 25, new Task0346.Result { Answer = true, X = 12, Y = 13 });
        }

        [Test]
        public void Test2()
        {
            CheckTest("12", "31", 26, new Task0346.Result { Answer = false });
        }

        [Test]
        public void Test3()
        {
            CheckTest("101", "2", 13, new Task0346.Result { Answer = true, X = 11, Y = 2 });
        }

        [Test]
        public void Test4()
        {
            CheckTest("54321", "9876", 19134, new Task0346.Result { Answer = true, X = 12345, Y = 6789 });
        }

        [Test]
        public void Test5()
        {
            CheckTest("1", "10", 2, new Task0346.Result { Answer = true, X = 1, Y = 1 });
        }

        [Test]
        public void Test6()
        {
            CheckTest("10", "1000", 11, new Task0346.Result { Answer = true, X = 1, Y = 10 });
        }

        [Test]
        public void Test7()
        {
            CheckTest("13", "101", 24, new Task0346.Result { Answer = true, X = 13, Y = 11 });
        }

        [Test]
        public void Test8()
        {
            CheckTest("11", "11", 121, new Task0346.Result { Answer = false });
        }

        [Test]
        public void Test9()
        {
            CheckTest("987654321", "1", 123456790, new Task0346.Result { Answer = true, X = 123456789, Y = 1 });
        }

        [Test]
        public void Test10()
        {
            CheckTest("122", "1", 222, new Task0346.Result { Answer = true, X = 221, Y = 1 });
        }

        [Test]
        public void Test11()
        {
            CheckTest("666", "100", 667, new Task0346.Result { Answer = true, X = 666, Y = 1 });
        }

        [Test]
        public void Test12()
        {
            CheckTest("100", "666", 667, new Task0346.Result { Answer = true, X = 1, Y = 666 });
        }

        [Test]
        public void Test13()
        {
            CheckTest("12345", "1", 54322, new Task0346.Result { Answer = true, X = 54321, Y = 1 });
        }

        [Test]
        public void Test14()
        {
            CheckTest("351", "0", 15, new Task0346.Result { Answer = false });
        }
    }
}
