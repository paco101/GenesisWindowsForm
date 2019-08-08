using System;
using System.Threading.Tasks;
using Genesis.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenesisUnitTest
{
	[TestClass]
	public class UnitTestDemo
	{
		[TestMethod]
		public void Test_LoadCustomer()
		{
			string customerId = "88A96958-A302-4913-9ADC-1997B49C7571";
			Customer cust = Genesis.Controllers.CustomerUserControl.Instance.LoadCustomerData(customerId);
			Assert.IsNotNull(cust);
		}

		[TestMethod]
		public async Task Test_SaveCustomer()
		{
			Customer cust = new Customer();
			cust.FirstName = "John";
			cust.LastName = "Smith";
			cust.Id = new Guid("88A96958-A302-4913-9ADC-1997B49C7571");
			bool isValid = await Genesis.Controllers.CustomerUserControl.Instance.SaveCustomerData(cust);
			Assert.IsTrue(isValid);
		}

		[TestMethod]
		public async Task Test_SaveDuplicatedCustomer()
		{
			Customer cust = new Customer();
			cust.FirstName = "Ray";
			cust.LastName = "Charles";
			cust.Id = new Guid("88A96958-A302-4913-9ADC-1997B49C7571");
			bool isValid = await Genesis.Controllers.CustomerUserControl.Instance.SaveCustomerData(cust);
			Assert.IsFalse(isValid);
		}
	}
}
