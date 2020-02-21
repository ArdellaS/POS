using System;
using Xunit;
using POS;

namespace POSTest
{
    public class InventoryTest
    {
        [Theory]
        [InlineData(0)]
        public void Inventory_GrandTotal_Works(int grandTotal)
        {
            int actual = 0;
            Assert.Equal(grandTotal, actual);
        }

        [Theory]
        [InlineData(3.99, 20.00, -15.77)]
        [InlineData(4.99, 50.00, -44.71)]
        [InlineData(1.00, 22.22, -21.16)]
        public void Change(double total, double money, double expected)
        {
            Inventory inventory = new Inventory();
            double change = inventory.GetChange(Math.Round(((total * 1.06)), 2), money);
            Assert.Equal(expected, change);
        }

    

    }
}