using System;
using System.Collections.Generic;
using System.Text;
namespace POS
{
    public class Inventory
    {
        List<Product> products = new List<Product>();
        List<Cart> cartItems = new List<Cart>();
        public void addItem(Product p)
        {
            products.Add(p);
        }
        public void addCartItem(Cart c)
        {
            cartItems.Add(c);
        }
        public string Items(string a)
        {
            foreach (Product p in products)
            {
                if (p.Name.Contains(a))
                {
                    return "";
                }
            }
            return a;
        }
        public void DisplayMenu()
        {
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
        }
        public void BuildCart()
        {
            double cartTotal = 0;
            do
            {
                Console.Write("\nPlease select item by ID: ");
                int customerSelection = int.Parse(Console.ReadLine());
                Console.WriteLine("\nHow many of this item would you like?");
                int selectionQuantity = int.Parse(Console.ReadLine());

                foreach (Product p in products)
                {
                    if (p.Id == customerSelection)
                    {
                        addCartItem(new Cart(p.Name, p.Price, selectionQuantity));
                        cartTotal = (cartTotal + (p.Price * selectionQuantity));
                        cartTotal = cartTotal * 1.06;
                        cartTotal = Math.Round(cartTotal, 2);
                    }
                }
                
            }
            while (ContinueProgram());
            Console.Clear();


            Console.WriteLine("Receipt: ");
            foreach (Cart c in cartItems)
            {
                Console.WriteLine(c);
            }
            Console.Write($"Sales Tax: {Math.Round((cartTotal * .06), 2)}");
            Console.WriteLine($"\nCart Total: {cartTotal}");

        }

        static bool ContinueProgram()
        {
            char c;
            do
            {
                Console.WriteLine("Would you like to continue? y/n");
                c = Console.ReadKey().KeyChar;
                if (c == 'n' || c == 'N')
                {
                    return false;
                }
            } while (c != 'y' && c != 'Y');
            return true;
        }


    }
}