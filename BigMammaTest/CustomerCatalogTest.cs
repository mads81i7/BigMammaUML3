using BigMammaUML3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BigMammaTest
{
    [TestClass]
    public class CustomerCatalogTest
    {
        [TestMethod]
        public void AddCustomerTest()
        {
            //Arrange
            ICustomerCatalog catalog = new CustomerCatalog();
            int numberBefore = catalog.Count;
            Customer c1 = new Customer("Mads", "over there",1, "10 10 10 10");

            //Act
            catalog.AddCustomer(c1);
            int numberAfter = catalog.Count;
            //Assert
            Assert.AreEqual( numberBefore + 1, numberAfter );
        }
    }
}
