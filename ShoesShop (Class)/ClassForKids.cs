using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesShop__Class_
{
    internal class OrderForKids
    {
        public string name;
        public int quantity;
        public int price;
        public string size;

        OrderForKids(string name, int quantity, string size, int price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.size = size;
        }
        internal class ItemOrderForKids
        {
            public void receipt()
            {
                OrderForKids[] orders = new OrderForKids[1];
                int numberOfOrders = 0;
                int quantity, totalAmount = 0;
                int verification;
                string size;
                char addMoreOrder;

                do
                {
                    Menu myObject6 = new Menu();
                    myObject6.kidsShoes();

                    Console.Write("\nIf you want to see the price and available size please enter Y, " +
                                "If not please enter N: ");
                    string wantToSee = Console.ReadLine();

                    switch (wantToSee)
                    {
                        case "Y":

                            Item priceAndSizeForKids = new Item();
                            priceAndSizeForKids.priceForKids();
                            priceAndSizeForKids.sizeKids();
                            break;
                        case "N":
                            Console.WriteLine("\nTHANK YOU TO VISIT TO OUR WEBSITE");
                            return;
                        default:
                            Console.WriteLine("\nERROR");
                            return;
                    }

                    Item myObject7 = new Item();
                    myObject7.orderForKids();
                    Console.Write("Please enter again your order for verification: ");
                    verification = Convert.ToInt32(Console.ReadLine());

                    while (verification < 1 || verification > 5)
                    {
                        Console.WriteLine("Invalid input! Please try again.");
                        Menu myObject66 = new Menu();
                        myObject66.kidsShoes();

                        Item myObject77 = new Item();
                        myObject77.orderForKids();
                        Console.Write("Please enter again your order for verification: ");
                        verification = Convert.ToInt32(Console.ReadLine());

                    }

                    Console.Write("Enter the size: ");
                    size = Console.ReadLine();
                    Console.Write("Enter the quantity of your order: ");
                    quantity = Convert.ToInt32(Console.ReadLine());

                    switch (quantity)
                    {
                        case 1:
                            totalAmount += quantity * 2200;
                            orders[numberOfOrders] = new OrderForKids("Grand Court Lifestyle lace", quantity, size, 2200);
                            break;
                        case 2:
                            totalAmount += quantity * 2200;
                            orders[numberOfOrders] = new OrderForKids("Advantage Lifestyle Court Lace", quantity, size, 2200);
                            break;
                        case 3:
                            totalAmount += quantity * 2000;
                            orders[numberOfOrders] = new OrderForKids("Tensaur Run Shoes", quantity, size, 2000);
                            break;
                        case 4:
                            totalAmount += quantity * 3500;
                            orders[numberOfOrders] = new OrderForKids("NMD 360", quantity, size, 3500);
                            break;
                        case 5:
                            totalAmount += quantity + 3000;
                            orders[numberOfOrders] = new OrderForKids("RapidaSport Bounce Lace", quantity, size, 3000);
                            break;
                    }
                    numberOfOrders++;

                    Console.Write("Do you want to add another order (Y/N): ");
                    addMoreOrder = Convert.ToChar(Console.ReadLine());
                } while (addMoreOrder == 'y' || addMoreOrder == 'Y');
                Console.WriteLine("\n---------------------------------------------------------------------------------------------------------");
                Console.WriteLine("                                                 RECEIPT                                                 ");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Item Ordered".PadRight(20) + "Quantity".PadRight(20) + "Price".PadRight(20) + "Size".PadRight(20) + "Total Price");
                for (int i = 0; i < numberOfOrders; i++)
                {
                    Console.WriteLine(orders[i].name.PadRight(20) + orders[i].quantity.ToString().PadRight(20) + orders[i].price.ToString().PadRight(20) + orders[i].size.PadRight(20) + orders[i].price * orders[i].quantity);
                }
                Console.WriteLine("---------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Total amount to be paid: " + "Php " + totalAmount);
                Console.WriteLine("---------------------------------------------------------------------------------------------------------");
                Console.WriteLine("*** Thank you to purchased we hope you will come back again ***");
            }
        }
    }
}
