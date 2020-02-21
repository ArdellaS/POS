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
            Console.Clear();
            Console.WriteLine($"{"ID",2}|{"Item:",25}|{"Price:",7}|{"Category:",15}|{"Description:",30}|");
            Console.WriteLine("====================================================================================");
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
        }
        public void BuildCart(out double cartTotal, out double totalTax)
        {
            cartTotal = 0;
            totalTax = 0;
            do
            {

                CustomerValidator(out int customerSelection, out int selectionQuantity);

                foreach (Product p in products)
                {
                    if (p.Id == customerSelection)
                    {
                        addCartItem(new Cart(p.Name, p.Price, selectionQuantity));
                        cartTotal = (cartTotal + (p.Price * selectionQuantity));
                        totalTax = cartTotal * .06;
                        cartTotal += totalTax;
                    }
                }

            }
            while (ContinueProgram());
            Console.Clear();

        }

        public void CustomerValidator(out int customerSelection, out int selectionQuantity)
        {
            bool cont;
            Console.Clear();
            DisplayMenu();
            Console.Write("\nPlease select item by ID from available choices: ");
            cont = int.TryParse(Console.ReadLine(), out customerSelection);

            while (!cont || customerSelection > products.Count || customerSelection <= 0)
            {
                Console.Write("\nPlease use eyes to see available choices above: ");
                cont = int.TryParse(Console.ReadLine(), out customerSelection);
            }



            Console.WriteLine("\nHow many of this item would you like?");
            cont = int.TryParse(Console.ReadLine(), out selectionQuantity);

            while (!cont || selectionQuantity <= 0)
            {
                Console.WriteLine(SpongeBob());
                Console.WriteLine("\nHoW MaNy oF THIS iTeM WouLd YoU lIkE, SiR?");
                cont = int.TryParse(Console.ReadLine(), out selectionQuantity);
               
            }
        }

        public string SpongeBob()
        {
            return 
"          ***                  \n"+
"          * *                  \n"+
"    ----//-------            \n"+
"      \\..C/--..--/ \\   `A    \n" +
"       (@ )  ( @) \\  \\// |w  \n" +
"        \\          \\  \\---/  \n" +
"         HGGGGGGG    \\    /` \n" +
"         V `---------`--'    \n" +
"             <<    <<        \n" +
"            ###   ###        \n";

        }

        public void Receipt()
        {

            BuildCart(out double cartTotal, out double totalTax);

            Console.WriteLine("Receipt: ");


            Console.WriteLine($"{"Items  ",23}|{"QTY:",7}|{"Price:",7}|");
            Console.WriteLine("=======================================================");

            foreach (Cart c in cartItems)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("=======================================================");
            Console.Write($"Sales Tax:  {totalTax.ToString("C2"),20}\n");
            Console.WriteLine($"\nCart Total: {cartTotal.ToString("C2"),20}\n");

            Console.WriteLine($"Change: {GetChange(cartTotal, GetMoney(ref cartTotal)).ToString("C2"),20}");
        }
        public double GetMoney(ref double cartTotal)
        {
            double money = 0.0;
            bool cont = false;
            Console.Write("Please insert cash amount: ");

            cont = double.TryParse(Console.ReadLine(), out money);

            while (!cont || money < cartTotal)
            {
                Console.WriteLine("More money now. Money me.");
                cont = double.TryParse(Console.ReadLine(), out money);
            }

            return money;
        }

        public double GetChange(double cartTotal, double money)
        {
            money = cartTotal - money;
            return money;
        }
        public void ClearCart()
        {
            cartItems.Clear();
        }

        public bool ContinueProgram()
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