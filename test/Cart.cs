using System;
using System.Collections.Generic;
using System.Text;
namespace POS
{
    public class Cart
    {
        private string name;
        private double price;
        private int quantity;
        public Cart(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public override string ToString()
        {
            return $"{quantity,5} X {name}:{price.ToString("C2"),20}";
        }
    }
}