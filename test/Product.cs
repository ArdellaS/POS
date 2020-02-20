using System;
using System.Collections.Generic;
using System.Text;
namespace POS
{
    public class Product
    {
        private string name;
        private double price;
        private string cat;
        private string des;
        private int id;
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public string Cat { get => cat; set => cat = value; }
        public string Des { get => des; set => des = value; }
        public int Id { get => id; set => id = value; }
        public Product(string name, double price, string cat, string des, int id)
        {
            this.name = name;
            this.price = price;
            this.cat = cat;
            this.des = des;
            this.id = id;
        }
        public override string ToString()
        {
            return String.Format($"{id}|{name,20}|{price,7}|{cat,15}|{des,20}|");
        }
    }
}