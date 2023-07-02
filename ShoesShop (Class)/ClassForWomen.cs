using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesShop__Class_
{
    internal class OrderForWomen
    {
        public string name;
        public int quantity;
        public int price;
        public string size;

        OrderForWomen(string name, int quantity, string size, int price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.size = size;
        }
        internal class ItemOrderedOfWomen
        {
            public void receipt()
            {
                OrderForWomen[] orders = new OrderForWomen[100];
                int numberOfOrders = 0;
                int quantity, totalAmount = 0;
                int verification;
                string size;
                char addMoreOrder;

                do
                {
                    Menu myObject4 = new Menu();
                    myObject4.womenShoes();

                    Console.Write("\nIf you want to see the price and available size please enter Y, " +
                                "If not please enter N: ");
                    string wantToSee = Console.ReadLine();

                    switch (wantToSee)
                    {
                        case "Y":

                            Item priceAndSizeForWomen = new Item();
                            priceAndSizeForWomen.priceForWomen();
                            priceAndSizeForWomen.sizeMenAndWomenShoes();
                            break;

                        case "N":
                            Console.WriteLine("\nTHANK YOU TO VISIT TO OUR WEBSITE");
                            return;
                        default:
                            Console.WriteLine("\nERROR");
                            return;
                    }

                    Item myObject5 = new Item();
                    myObject5.orderForWomen();
                    Console.Write("Please enter again your order for verification: ");
                    verification = Convert.ToInt32(Console.ReadLine());

                    while (verification < 1 || verification > 5)
                    {
                        Console.WriteLine("Invalid input! Please try again.");
                        Menu myObject44 = new Menu();
                        myObject44.womenShoes();

                        Item myObject55 = new Item();
                        myObject55.orderForWomen();
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
                            totalAmount += quantity * 5000;
                            orders[numberOfOrders] = new OrderForWomen("Campus 00s", quantity, size, 5000);
                            break;
                        case 2:
                            totalAmount += quantity * 15000;
                            orders[numberOfOrders] = new OrderForWomen("NMD S1", quantity, size, 15000);
                            break;
                        case 3:
                            totalAmount += quantity * 5300;
                            orders[numberOfOrders] = new OrderForWomen("Stan Smith", quantity, size, 5300);
                            break;
                        case 4:
                            totalAmount += quantity * 7500;
                            orders[numberOfOrders] = new OrderForWomen("Agent Gil Restomod", quantity, size, 7500);
                            break;
                        case 5:
                            totalAmount += quantity * 4500;
                            orders[numberOfOrders] = new OrderForWomen("3MC", quantity, size, 4500);
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
