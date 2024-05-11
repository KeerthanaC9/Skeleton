using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AStock);        
        }

        [TestMethod]

        public void AvailablePropertyOK()
        {
            clsStock AStock = new clsStock();

            Boolean TestData = true;

            AStock.Available = TestData;

            Assert.AreEqual(AStock.Available, TestData);
        }

        [TestMethod]

        public void DateUpdatedPropertyOK()
        {

            clsStock AStock = new clsStock();

            DateTime TestData = DateTime.Now.Date;

            AStock.DateUpdated = TestData;

            Assert.AreEqual(AStock.DateUpdated, TestData);
        }

        [TestMethod]

        public void ShoeIdPropertyOK()
        {
            clsStock AStock = new clsStock();

            Int32 TestData = 1;

            AStock.ShoeId = TestData;

            Assert.AreEqual(AStock.ShoeId, TestData);
        }

        [TestMethod]

        public void ShoeNamePropertyOK()
        {
            clsStock AStock = new clsStock();

            string TestData = "Nike Air Force 1";

            AStock.ShoeName = TestData;

            Assert.AreEqual(AStock.ShoeName, TestData);
        }

        [TestMethod]

        public void SupplierPropertyOK()
        {
            clsStock AStock = new clsStock();

            string TestData = "Nike";

            AStock.Supplier = TestData;

            Assert.AreEqual(AStock.Supplier, TestData);
        }

        [TestMethod]

        public void ShoeSizePropertyOK()
        {
            clsStock AStock = new clsStock();

            Int32 TestData = 6;

            AStock.ShoeSize = TestData;

            Assert.AreEqual(AStock.ShoeSize, TestData);
        }

        [TestMethod]

        public void ShoeColorPropertyOK()
        {
            clsStock AStock = new clsStock();

            string TestData = "blue";

            AStock.ShoeColor = TestData;

            Assert.AreEqual(AStock.ShoeColor, TestData);
        }

        [TestMethod]

        public void ShoePricePropertyOK()
        {
            clsStock AStock = new clsStock();

            decimal TestData = 70.00m;

            AStock.ShoePrice = TestData;

            Assert.AreEqual(AStock.ShoePrice, TestData);
        }

        }
}
