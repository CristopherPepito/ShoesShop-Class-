using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesShop__Class_
{
    internal class Order
    {
        public string name;
        public int quantity;
        public int price;
        public string size;

        Order(string name, int quantity, string size, int price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.size = size;
        }
        internal class ItemOrderedOfMen
        {
            public void receipt()
            {
                Order[] orders = new Order[100];
                int numberOfOrders = 0;
                int quantity, totalAmount = 0;
                int verification;
                string size;
                char addMoreOrder;

                do
                {
                    Menu myObject2 = new Menu();
                    myObject2.menShoes();

                    Console.Write("\nIf you want to see the price and available size please enter Y, " +
                            "If not please enter N: ");
                    string wantToSee = Console.ReadLine();

                    switch (wantToSee)
                    {
                        case "Y":

                            Item priceAndSizeForMen = new Item();
                            priceAndSizeForMen.priceForMen();
                            priceAndSizeForMen.sizeMenAndWomenShoes();
                            break;

                        case "N":
                            Console.WriteLine("\nTHANK YOU TO VISIT TO OUR WEBSITE");
                            return;
                        default:
                            Console.WriteLine("\nERROR");
                            return;
                    }

                    Item myObject3 = new Item();
                    myObject3.orderForMen();
                    Console.Write("Please enter again your order for verification: ");
                    verification = Convert.ToInt32(Console.ReadLine());

                    while (verification < 1 || verification > 5)
                    {
                        Console.WriteLine("Invalid input! Please try again.");
                        Menu myObject22 = new Menu();
                        myObject22.menShoes();

                        Item myObject33 = new Item();
                        myObject33.orderForMen();
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
                            totalAmount += quantity * 5500;
                            orders[numberOfOrders] = new Order("Forum Low Cl", quantity, size, 5500);
                            break;
                        case 2:
                            totalAmount += quantity * 5000;
                            orders[numberOfOrders] = new Order("Forum Low Shoes", quantity, size, 5000);
                            break;
                        case 3:
                            totalAmount += quantity * 5300;
                            orders[numberOfOrders] = new Order("Super Star Shoes", quantity, size, 5300);
                            break;
                        case 4:
                            totalAmount += quantity * 11000;
                            orders[numberOfOrders] = new Order("Ultraboost Light", quantity, size, 11000);
                            break;
                        case 5:
                            totalAmount += quantity * 5500;
                            orders[numberOfOrders] = new Order("Supernova", quantity, size, 5500);
                            break;

                    }
                    numberOfOrders++;

                    Console.Write("Do you want to add another order (Y/N): ");
                    addMoreOrder = Convert.ToChar(Console.ReadLine());
                } while (addMoreOrder == 'y' || addMoreOrder == 'Y');

                Console.WriteLine("\n---------------------------------------------------------------------------------------------------------");
                Console.WriteLine("                                                 RECEIPT                                                 ");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Item Ordered".PadRight(20) + "Quantity".PadRight(20) + "Price".PadRight(20) +"Size".PadRight(20) + "Total Price");
                for (int i = 0; i < numberOfOrders; i++)
                {
                    Console.WriteLine(orders[i].name.PadRight(20) + orders[i].quantity.ToString().PadRight(20) + 
                        orders[i].price.ToString().PadRight(20) + orders[i].size.PadRight(20) + orders[i].price * orders[i].quantity);

                }
                Console.WriteLine("---------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Total amount to be paid: " + "Php " + totalAmount);
                Console.WriteLine("---------------------------------------------------------------------------------------------------------");
                Console.WriteLine("*** Thank you to purchased we hope you will come back again ***");
            }
        }
    }
}
