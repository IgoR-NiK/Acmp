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
            
            Assert.That(result.IsSuccess, Is.EqualTo(test.IsSuccess));

            if (result.IsSuccess)
            {
                Assert.That(result.Field.GetLength(0), Is.EqualTo(test.Field.GetLength(0)));
                
                for (var i = 0; i < result.Field.GetLength(0); i++)
                {
                    for (var j = 0; j < result.Field.GetLength(1); j++)
                    {
                        Assert.That(result.Field[i, j], Is.EqualTo(test.Field[i, j]));
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