using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0431Test
    {
        private static void CheckTest(int[,] field, Task0431.Result result)
        {
            var test = Task0431.Solve(field);
            
            Assert.AreEqual(result.IsSuccess, test.IsSuccess);

            if (result.IsSuccess)
            {
                Assert.AreEqual(result.Field.GetLength(0), test.Field.GetLength(0));
                
                for (var i = 0; i < result.Field.GetLength(0); i++)
                {
                    for (var j = 0; j < result.Field.GetLength(1); j++)
                    {
                        Assert.AreEqual(result.Field[i, j], test.Field[i, j]);
                    }
                }
            }
        }

        [Test]
        public void Test1()
        {
            CheckTest(new[,]
            {
                { -3, -3, -3, -3, -3 },
                { -3, -2, -2, -3, -3 },
                { -3, -3, -3, -3, -3 },
                { -3, -3, -3, -3, -3 },
                { -3, -3, -3, -3, -3 }
            }, new Task0431.Result
            {
                IsSuccess = true,
                Field = new[,]
                {
                    { -3, -3, -3, -3, -2 },
                    { -3, -2, -2, -3, -3 },
                    { -3, -3, -3, -2, -3 },
                    { -3, -3, -3, -3, -3 },
                    { -3, -3, -3, -3, -3 }
                }
            });
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(new[,]
            {
                { -2, -3, -3, -2, -3 },
                { -3, -3, -1, -1, -3 },
                { -3, -3, -3, -3, -3 },
                { -3, -3, -3, -3, -3 },
                { -3, -3, -3, -3, -3 }
            }, new Task0431.Result
            {
                IsSuccess = true,
                Field = new[,]
                {
                    { -2, -3, -3, -2, -3 },
                    { -3, -3, -1, -1, -3 },
                    { -3, -2, -3, -3, -2 },
                    { -3, -3, -2, -3, -3 },
                    { -2, -3, -3, -3, -3 }
                }
            });
        }
        
        [Test]
        public void Test3()
        {
            CheckTest(new[,]
            {
                { -2, -3, -3, -3, -3 },
                { -3, -3, -1, -3, -3 },
                { -3, -1, -3, -3, -3 },
                { -3, -3, -3, -3, -3 },
                { -3, -3, -3, -3, -2 }
            }, new Task0431.Result
            {
                IsSuccess = false
            });
        }
    }
}