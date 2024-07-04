using CustomerData;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void kwhPositive()
        {
            decimal kwhActual = Customer.CalculateCharge(1000m);
            decimal kwhExpected = 132m;

            Assert.AreEqual(kwhActual, kwhExpected);
        }

        [TestMethod]
        public void kwhCNegative()
        {
            
        }
    }
}