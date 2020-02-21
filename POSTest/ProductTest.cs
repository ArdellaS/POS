using System;
using Xunit;
using POS;

namespace POSTest
{
    public class ProductTest
    {
        [Theory]
        [InlineData(1000)]
        public void Product(int id)
        {
            int actual = 1000;
            Assert.Equal(id, actual);
        }
        [Theory]
        [InlineData("Baja Blast")]
        public void FullProduct(string name)
        {
            Inventory sut = new Inventory();
            var b = sut.Items(name);
            Assert.Equal(name, b);
        }



    }
}