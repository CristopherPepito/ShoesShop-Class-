using ShoesShop__Class_;

namespace AdidasOrdringShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultOfCategoryInput;

            Suggestion myObject1 = new Suggestion();
            myObject1.displayCategory();
            Console.Write("\nEnter your want: ");
            resultOfCategoryInput = Convert.ToInt32(Console.ReadLine());

            if (resultOfCategoryInput == 1)
            {
                itemOrderedForMen();
            }
            else if (resultOfCategoryInput == 2)
            {
                itemOrderedForWomen();
            }
            else if (resultOfCategoryInput == 3)
            {
                itemOrderedForKids();
            }
            else
            {
                Console.WriteLine("\nERROR");
                return;
            }
        }
        static void itemOrderedForMen()
        {
            OrderForMen[] orders = new OrderForMen[100];
            int numberOfOrders = 0;
            int quantity, totalAmount = 0;
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

                Console.Write("\nEnter you want to order: ");
                int orderNumber = Convert.ToInt32(Console.ReadLine());
                switch (orderNumber)
                {
                    case 1:
                        Console.WriteLine("You choose is Forum Low Cl");
                        Console.WriteLine("The price is Php 5,500");
                        break;
                    case 2:
                        Console.WriteLine("You choose is Forum Low Shoes");
                        Console.WriteLine("The price is Php 5,000");
                        break;
                    case 3:
                        Console.WriteLine("You choose is Super Star Shoes");
                        Console.WriteLine("The price is Php 5,300");
                        break;
                    case 4:
                        Console.WriteLine("You choose is Ultraboost Light");
                        Console.WriteLine("The price is Php 11,000");
                        break;
                    case 5:
                        Console.WriteLine("You choose is Supernova");
                        Console.WriteLine("The price is Php 5,500");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                verificationForMen();
                Console.Write("Enter the size: ");
                size = Console.ReadLine();
                Console.Write("Enter the quantity of your order: ");
                quantity = Convert.ToInt32(Console.ReadLine());

                switch (orderNumber)
                {
                    case 1:
                        totalAmount += quantity * 5500;
                        orders[numberOfOrders] = new OrderForMen("Forum Low Cl", quantity, size, 5500);
                        break;
                    case 2:
                        totalAmount += quantity * 5000;
                        orders[numberOfOrders] = new OrderForMen("Forum Low Shoes", quantity, size, 5000);
                        break;
                    case 3:
                        totalAmount += quantity * 5300;
                        orders[numberOfOrders] = new OrderForMen("Super Star Shoes", quantity, size, 5300);
                        break;
                    case 4:
                        totalAmount += quantity * 11000;
                        orders[numberOfOrders] = new OrderForMen("Ultraboost Light", quantity, size, 11000);
                        break;
                    case 5:
                        totalAmount += quantity * 5500;
                        orders[numberOfOrders] = new OrderForMen("Supernova", quantity, size, 5500);
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
                Console.WriteLine(orders[i].name.PadRight(20) + orders[i].quantity.ToString().PadRight(20) +
                    orders[i].price.ToString().PadRight(20) + orders[i].size.PadRight(20) + orders[i].price * orders[i].quantity);

            }
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Total amount to be paid: " + "Php " + totalAmount);
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                *** Thank you to purchased we hope you will come back again ***                          ");
        }
        static void itemOrderedForWomen()
        {
            OrderForWomen[] orders = new OrderForWomen[100];
            int numberOfOrders = 0;
            int quantity, totalAmount = 0;
            string size;
            char addMoreOrder;

            do
            {
                Menu myObject3 = new Menu();
                myObject3.womenShoes();

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

                Console.Write("\nEnter you want to order: ");
                int orderNumber = Convert.ToInt32(Console.ReadLine());
                switch (orderNumber)
                {
                    case 1:
                        Console.WriteLine("You choose is Campus 00s");
                        Console.WriteLine("The price is Php 5,000");
                        break;
                    case 2:
                        Console.WriteLine("You choose is NMD S1");
                        Console.WriteLine("The price is Php 15,000");
                        break;
                    case 3:
                        Console.WriteLine("You choose is Stan Smith");
                        Console.WriteLine("The price is Php 5,300");
                        break;
                    case 4:
                        Console.WriteLine("You choose is Agent Gil Restomod");
                        Console.WriteLine("The price is Php 7,500");
                        break;
                    case 5:
                        Console.WriteLine("You choose is 3MC");
                        Console.WriteLine("The price is Php 4,500");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                verificationForWomen();
                Console.Write("Enter the size: ");
                size = Console.ReadLine();
                Console.Write("Enter the quantity of your order: ");
                quantity = Convert.ToInt32(Console.ReadLine());

                switch (orderNumber)
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
        static void itemOrderedForKids()
        {
            OrderForKids[] orders = new OrderForKids[1];
            int numberOfOrders = 0;
            int quantity, totalAmount = 0;
            string size;
            char addMoreOrder;

            do
            {
                Menu myObject4 = new Menu();
                myObject4.kidsShoes();

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

                Console.Write("\nEnter you want to order: ");
                int orderNumber = Convert.ToInt32(Console.ReadLine());

                switch (orderNumber)
                {
                    case 1:
                        Console.WriteLine("You choose is Grand Court Lifestyle lace");
                        Console.WriteLine("The price is Php 2,200");
                        break;
                    case 2:
                        Console.WriteLine("You choose is Advantage Lifestyle Court Lace");
                        Console.WriteLine("The price is Php 2,200");
                        break;
                    case 3:
                        Console.WriteLine("You choose is Tensaur Run Shoes");
                        Console.WriteLine("The price is Php 2,000");
                        break;
                    case 4:
                        Console.WriteLine("You choose is NMD 360");
                        Console.WriteLine("The price is Php 3,500");
                        break;
                    case 5:
                        Console.WriteLine("You choose is RapidaSport Bounce Lace");
                        Console.WriteLine("The price is Php 3,000");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                verificationForKids();
                Console.Write("Enter the size: ");
                size = Console.ReadLine();
                Console.Write("Enter the quantity of your order: ");
                quantity = Convert.ToInt32(Console.ReadLine());

                switch (orderNumber)
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
        static void verificationForMen()
        {
            int verification;
            int orderNumber;

            Console.Write("Please enter again your order for verification: ");
            verification = Convert.ToInt32(Console.ReadLine());

            while (verification < 1 || verification > 5)
            {
                Console.WriteLine("Invalid input! Please try again.");
                Menu myObject2 = new Menu();
                myObject2.menShoes();

                Console.Write("\nEnter you want to order: ");
                orderNumber = Convert.ToInt32(Console.ReadLine());
                switch (orderNumber)
                {
                    case 1:
                        Console.WriteLine("You choose is Forum Low Cl");
                        Console.WriteLine("The price is Php 5,500");
                        break;
                    case 2:
                        Console.WriteLine("You choose is Forum Low Shoes");
                        Console.WriteLine("The price is Php 5,000");
                        break;
                    case 3:
                        Console.WriteLine("You choose is Super Star Shoes");
                        Console.WriteLine("The price is Php 5,300");
                        break;
                    case 4:
                        Console.WriteLine("You choose is Ultraboost Light");
                        Console.WriteLine("The price is Php 11,000");
                        break;
                    case 5:
                        Console.WriteLine("You choose is Supernova");
                        Console.WriteLine("The price is Php 5,500");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                Console.Write("Please enter again your order for verification: ");
                verification = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void verificationForWomen()
        {
            int verification;
            int orderNumber;

            Console.Write("Please enter again your order for verification: ");
            verification = Convert.ToInt32(Console.ReadLine());

            while (verification < 1 || verification > 5)
            {
                Console.WriteLine("Invalid input! Please try again.");
                Menu myObject3 = new Menu();
                myObject3.womenShoes();

                Console.Write("\nEnter you want to order: ");
                orderNumber = Convert.ToInt32(Console.ReadLine());
                switch (orderNumber)
                {
                    case 1:
                        Console.WriteLine("You choose is Campus 00s");
                        Console.WriteLine("The price is Php 5,000");
                        break;
                    case 2:
                        Console.WriteLine("You choose is NMD S1");
                        Console.WriteLine("The price is Php 15,000");
                        break;
                    case 3:
                        Console.WriteLine("You choose is Stan Smith");
                        Console.WriteLine("The price is Php 5,300");
                        break;
                    case 4:
                        Console.WriteLine("You choose is Agent Gil Restomod");
                        Console.WriteLine("The price is Php 7,500");
                        break;
                    case 5:
                        Console.WriteLine("You choose is 3MC");
                        Console.WriteLine("The price is Php 4,500");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                Console.Write("Please enter again your order for verification: ");
                verification = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void verificationForKids()
        {
            int verification;
            int orderNumber;

            Console.Write("Please enter again your order for verification: ");
            verification = Convert.ToInt32(Console.ReadLine());

            while (verification < 1 || verification > 5)
            {
                Console.WriteLine("Invalid input! Please try again.");
                Menu myObject4 = new Menu();
                myObject4.kidsShoes();

                Console.Write("\nEnter you want to order: ");
                orderNumber = Convert.ToInt32(Console.ReadLine());

                switch (orderNumber)
                {
                    case 1:
                        Console.WriteLine("You choose is Grand Court Lifestyle lace");
                        Console.WriteLine("The price is Php 2,200");
                        break;
                    case 2:
                        Console.WriteLine("You choose is Advantage Lifestyle Court Lace");
                        Console.WriteLine("The price is Php 2,200");
                        break;
                    case 3:
                        Console.WriteLine("You choose is Tensaur Run Shoes");
                        Console.WriteLine("The price is Php 2,000");
                        break;
                    case 4:
                        Console.WriteLine("You choose is NMD 360");
                        Console.WriteLine("The price is Php 3,500");
                        break;
                    case 5:
                        Console.WriteLine("You choose is RapidaSport Bounce Lace");
                        Console.WriteLine("The price is Php 3,000");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                Console.Write("Please enter again your order for verification: ");
                verification = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}