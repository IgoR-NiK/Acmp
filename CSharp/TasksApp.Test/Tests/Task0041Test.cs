using System.Collections.Generic;
using NUnit.Framework;
using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
	[TestFixture]
    public class Task0041Test
    {
        private static void CheckTest(int[] input, int[] result)
        {			
            var test = Task0041.Solve(input);

            var processedTest = new List<int>();
            for (var i = 0; i <= 200; i++)
            {
	            for (var j = 1; j <= test[i]; j++)
	            {
		            processedTest.Add(i - 100);
	            }
            }
            
            Assert.That(result.Length, Is.EqualTo(processedTest.Count));
            for (var i = 0; i < result.Length; i++)
            {
	            Assert.That(result[i], Is.EqualTo(processedTest[i]));
            }
        }

        [Test]
        public void Test1()
        {
			CheckTest(new[] { 9, -20, 14 }, new[] { -20, 9, 14 });
        }

		[Test]
		public void Test2()
		{
			CheckTest(new[] { 12, 7, 92, 5, 18, 4, 32, 48, 11, 74 }, new[] { 4, 5, 7, 11, 12, 18, 32, 48, 74, 92 });
		}
    }
}