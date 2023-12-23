using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
    [TestFixture]
    public class Task0252Test
    {
        private static void CheckTest(Task0252.Mass[] input, Task0252.Mass[] expected)
        {
            var solution = Task0252.Solve(input);
            
            Assert.That(solution.Length, Is.EqualTo(expected.Length));
            for (var i = 0; i < expected.Length; i++)
            {
                Assert.That(solution[i], Is.EqualTo(expected[i]));
            }
        }

        [Test]
        public void Test1()
        {
            CheckTest(new[]
                {
                    new Task0252.Mass { Number = 3, Unit = Task0252.Unit.g },
                    new Task0252.Mass { Number = 1, Unit = Task0252.Unit.g }
                },
                new[]
                {
                    new Task0252.Mass { Number = 1, Unit = Task0252.Unit.g },
                    new Task0252.Mass { Number = 3, Unit = Task0252.Unit.g }
                });
        }
        
        [Test]
        public void Test2()
        {
            CheckTest(new[]
                {
                    new Task0252.Mass { Number = 234, Unit = Task0252.Unit.g },
                    new Task0252.Mass { Number = 4576, Unit = Task0252.Unit.mp },
                    new Task0252.Mass { Number = 2, Unit = Task0252.Unit.t },
                    new Task0252.Mass { Number = 32, Unit = Task0252.Unit.mg },
                    new Task0252.Mass { Number = 2, Unit = Task0252.Unit.Mg }
                },
                new[]
                {
                    new Task0252.Mass { Number = 32, Unit = Task0252.Unit.mg },
                    new Task0252.Mass { Number = 234, Unit = Task0252.Unit.g },
                    new Task0252.Mass { Number = 4576, Unit = Task0252.Unit.mp },
                    new Task0252.Mass { Number = 2, Unit = Task0252.Unit.t },
                    new Task0252.Mass { Number = 2, Unit = Task0252.Unit.Mg }
                });
        }
    }
}