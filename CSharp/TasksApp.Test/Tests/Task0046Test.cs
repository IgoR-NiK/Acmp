using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestClass]
    public class Task0046Test
    {
        private void CheckTest(int n, string result)
        {
            var test = Task0046.Solve(n);
			Assert.AreEqual(result, test);
        }

        [TestMethod]
        public void Test1()
        {
			CheckTest(0, "3");
        }

        [TestMethod]
        public void Test2()
        {
            CheckTest(1, "2.7");
        }

        [TestMethod]
        public void Test3()
        {
            CheckTest(2, "2.72");
        }

        [TestMethod]
        public void Test4()
        {
            CheckTest(3, "2.718");
        }

        [TestMethod]
        public void Test5()
        {
            CheckTest(4, "2.7183");
        }

        [TestMethod]
        public void Test6()
        {
            CheckTest(5, "2.71828");
        }

        [TestMethod]
        public void Test7()
        {
            CheckTest(6, "2.718282");
        }

        [TestMethod]
        public void Test8()
        {
            CheckTest(7, "2.7182818");
        }

        [TestMethod]
        public void Test9()
        {
            CheckTest(8, "2.71828183");
        }

        [TestMethod]
        public void Test10()
        {
            CheckTest(9, "2.718281828");
        }

        [TestMethod]
        public void Test11()
        {
            CheckTest(10, "2.7182818285");
        }

        [TestMethod]
        public void Test12()
        {
            CheckTest(11, "2.71828182846");
        }

        [TestMethod]
        public void Test13()
        {
            CheckTest(12, "2.718281828459");
        }

        [TestMethod]
        public void Test14()
        {
            CheckTest(13, "2.7182818284590");
        }

        [TestMethod]
        public void Test15()
        {
            CheckTest(14, "2.71828182845905");
        }

        [TestMethod]
        public void Test16()
        {
            CheckTest(15, "2.718281828459045");
        }

        [TestMethod]
        public void Test17()
        {
            CheckTest(16, "2.7182818284590452");
        }

        [TestMethod]
        public void Test18()
        {
            CheckTest(17, "2.71828182845904524");
        }

        [TestMethod]
        public void Test19()
        {
            CheckTest(18, "2.718281828459045235");
        }

        [TestMethod]
        public void Test20()
        {
            CheckTest(19, "2.7182818284590452354");
        }

        [TestMethod]
        public void Test21()
        {
            CheckTest(20, "2.71828182845904523536");
        }

        [TestMethod]
        public void Test22()
        {
            CheckTest(21, "2.718281828459045235360");
        }

        [TestMethod]
        public void Test23()
        {
            CheckTest(22, "2.7182818284590452353603");
        }

        [TestMethod]
        public void Test24()
        {
            CheckTest(23, "2.71828182845904523536029");
        }

        [TestMethod]
        public void Test25()
        {
            CheckTest(24, "2.718281828459045235360288");
        }

        [TestMethod]
        public void Test26()
        {
            CheckTest(25, "2.7182818284590452353602875");
        }
    }
}