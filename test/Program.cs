using System;
using System.Collections.Generic;
namespace POS
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Inventory inventory = new Inventory();
            inventory.addItem(new Product("Crunch Wrap", 3.99, "specialty", "Tasty", 1));
            inventory.addItem(new Product("5 Layer Burrito", 4.99, "burrito", "Yummy", 2));
            inventory.addItem(new Product("Durrito Loco Taco", 1.99, "Taco", "Durrito Shell Taco", 3));
            inventory.addItem(new Product("Cinnabon Delights", 1.00, "value menu", "Sweet", 4));
            inventory.addItem(new Product("Baja Blast", 2.69, "drink", "Satisfying", 5));
            Console.WriteLine("\t\t\tWelcome to Taco Bell\n");
            inventory.DisplayMenu();
            inventory.BuildCart();
        }
    }
}