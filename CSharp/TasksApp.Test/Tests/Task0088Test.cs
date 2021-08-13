using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0088Test
    {
        private void CheckTest(int n, int[,] field, string result)
        {
            var resultTest = Task0088.Solve(n, field);

            Assert.AreEqual(result, resultTest);
        }

        [Test]
        public void Test1()
        {
            CheckTest(3, new[,]
            {
                { 1, 3, 2, 5, 4, 6, 9, 8, 7 },
                { 4, 6, 5, 8, 7, 9, 3, 2, 1 },
                { 7, 9, 8, 2, 1, 3, 6, 5, 4 },
                { 9, 2, 1, 4, 3, 5, 8, 7, 6 },
                { 3, 5, 4, 7, 6, 8, 2, 1, 9 },
                { 6, 8, 7, 1, 9, 2, 5, 4, 3 },
                { 5, 7, 6, 9, 8, 1, 4, 3, 2 },
                { 2, 4, 3, 6, 5, 7, 1, 9, 8 },
                { 8, 1, 9, 3, 2, 4, 7, 6, 5 }
            }, "Correct");
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(1, new[,]
            {
                { 10 }
            }, "Incorrect");
        }
        
        [Test]
        public void Test3()
        {
            CheckTest(1, new[,]
            {
                { 1 }
            }, "Correct");
        }
        
        [Test]
        public void Test4()
        {
            CheckTest(2, new[,]
            {
                { 1, 2, 3, 4 },
                { 2, 1, 4, 3 },
                { 3, 4, 2, 1 },
                { 4, 3, 1, 2 }
            }, "Incorrect");
        }
        
        [Test]
        public void Test5()
        {
            CheckTest(2, new[,]
            {
                { 1, 2, 3, 5 },
                { 2, 1, 4, 3 },
                { 3, 4, 2, 1 },
                { 4, 3, 1, 2 }
            }, "Incorrect");
        }
        
        [Test]
        public void Test6()
        {
            CheckTest(2, new[,]
            {
                { 1, 2, 3, 4 },
                { 2, 1, 4, 3 },
                { 3, 4, 2, 1 },
                { 5, 3, 1, 2 }
            }, "Incorrect");
        }
    }
}