﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

using TasksApp.Tasks;

namespace TasksApp.Test.Tests
{
	[TestClass]
	public class Task0172Test
	{
		private void CheckTest(Task0172.BigInteger n, int k, int result)
		{
			var resultTest = Task0172.Solve(n, k);
			Assert.AreEqual(resultTest, result);
		}

		[TestMethod]
		public void Test1()
		{
			CheckTest(new Task0172.BigInteger("239"), 16, 15);
		}

		[TestMethod]
		public void Test2()
		{
			CheckTest(new Task0172.BigInteger("4638746747645731289347483927"), 6784789, 1001783);
		}
	}
}