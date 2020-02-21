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
            inventory.addItem(new Product("Baja Blast", 2.69, "Drink", "Satisfying", 5));
            inventory.addItem(new Product("Pepsi", 2.69, "Drink", "Thirst Quenching", 6));
            inventory.addItem(new Product("Cheesy Gordita Crunch", 4.19, "Specialty", "Hard and Soft Shell", 7));
            inventory.addItem(new Product("Chalupa Supreme", 2.99, "Taco", "Tasty Chalupa", 8));
            inventory.addItem(new Product("Nacho Fries", 1.99, "Specialty", "Seasoned Fries", 9));
            inventory.addItem(new Product("Mini Chicken Quesidilla", 1.00, "Value Menu", "Amazing sauce with chicken", 10));
            inventory.addItem(new Product("Chicken Quesidilla", 5.99, "Specialty", "Awesome Grilled Chicken", 11));
            inventory.addItem(new Product("Cheesy Roll Up", 1.00, "Value Menu", "Cheesy goodness", 12));
            do
            {

                Console.WriteLine("\t\t\tWelcome to Taco Bell\n");
                inventory.DisplayMenu();
                inventory.ClearCart();

                inventory.Receipt();
            }
            while (inventory.ContinueProgram());

            Console.WriteLine("Come again... or don't.. whateve");
        }
    }
}