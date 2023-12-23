using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0046Test
    {
        private static void CheckTest(int n, string result)
        {
            var test = Task0046.Solve(n);
			Assert.That(result, Is.EqualTo(test));
        }

        [Test]
        public void Test1()
        {
			CheckTest(0, "3");
        }

        [Test]
        public void Test2()
        {
            CheckTest(1, "2.7");
        }

        [Test]
        public void Test3()
        {
            CheckTest(2, "2.72");
        }

        [Test]
        public void Test4()
        {
            CheckTest(3, "2.718");
        }

        [Test]
        public void Test5()
        {
            CheckTest(4, "2.7183");
        }

        [Test]
        public void Test6()
        {
            CheckTest(5, "2.71828");
        }

        [Test]
        public void Test7()
        {
            CheckTest(6, "2.718282");
        }

        [Test]
        public void Test8()
        {
            CheckTest(7, "2.7182818");
        }

        [Test]
        public void Test9()
        {
            CheckTest(8, "2.71828183");
        }

        [Test]
        public void Test10()
        {
            CheckTest(9, "2.718281828");
        }

        [Test]
        public void Test11()
        {
            CheckTest(10, "2.7182818285");
        }

        [Test]
        public void Test12()
        {
            CheckTest(11, "2.71828182846");
        }

        [Test]
        public void Test13()
        {
            CheckTest(12, "2.718281828459");
        }

        [Test]
        public void Test14()
        {
            CheckTest(13, "2.7182818284590");
        }

        [Test]
        public void Test15()
        {
            CheckTest(14, "2.71828182845905");
        }

        [Test]
        public void Test16()
        {
            CheckTest(15, "2.718281828459045");
        }

        [Test]
        public void Test17()
        {
            CheckTest(16, "2.7182818284590452");
        }

        [Test]
        public void Test18()
        {
            CheckTest(17, "2.71828182845904524");
        }

        [Test]
        public void Test19()
        {
            CheckTest(18, "2.718281828459045235");
        }

        [Test]
        public void Test20()
        {
            CheckTest(19, "2.7182818284590452354");
        }

        [Test]
        public void Test21()
        {
            CheckTest(20, "2.71828182845904523536");
        }

        [Test]
        public void Test22()
        {
            CheckTest(21, "2.718281828459045235360");
        }

        [Test]
        public void Test23()
        {
            CheckTest(22, "2.7182818284590452353603");
        }

        [Test]
        public void Test24()
        {
            CheckTest(23, "2.71828182845904523536029");
        }

        [Test]
        public void Test25()
        {
            CheckTest(24, "2.718281828459045235360288");
        }

        [Test]
        public void Test26()
        {
            CheckTest(25, "2.7182818284590452353602875");
        }
    }
}