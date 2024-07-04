using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerData;

namespace UnitTest
{
    [TestClass()]
    public class CustomerTests
    {
        Customer customer = new Customer("test", "test", 1);

        [TestMethod()]
        public void CalculateChargeWithPositive()
        {
            decimal actualKwh = Customer.CalculateCharge(1000);
            decimal expectedKwh = 82;

            Assert.AreEqual(expectedKwh, actualKwh);
        }

        [TestMethod()]
        public void CalculateChargeWithNegative()
        {
            decimal actualKwh = Customer.CalculateCharge(-10);
            decimal expectedKwh = -1m;

            Assert.AreEqual(expectedKwh, actualKwh);
        }

        [TestMethod()]
        public void CalculateChargeWithZero()
        {
            decimal actualKwh = Customer.CalculateCharge(0);
            decimal expectedKwh = -1m;

            Assert.AreEqual(expectedKwh, actualKwh);
        }
    }
}