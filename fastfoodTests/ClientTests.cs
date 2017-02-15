using Microsoft.VisualStudio.TestTools.UnitTesting;
using fastfood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastfood.Tests
{
	[TestClass()]
	public class ClientTests
	{
		[TestMethod()]
		public void PayerTest()
		{
			double rendu;
			bool result;

			Client client = new Client();

			result = client.Payer(10, 12, out rendu);
			Assert.IsTrue(result);
			Assert.AreEqual(rendu, 2);

			result = client.Payer(12, 10, out rendu);
			Assert.IsFalse(result);
			Assert.AreEqual(rendu, -2);
		}
	}
}