using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ShoesShop__Class_
{
    internal class Suggestion
    {
        public void displayCategory()
        {
            var category = new List<string>()
                {" CATEGORY ",
                "1. Men Shoes",
                "2. Women Shoes",
                "3. Kids Shoes",};

            foreach (string i in category)
            {
                Console.WriteLine(i);
            }
        }
    }
    internal class Menu
    {
        public void menShoes()
        {
            var menShoes = new List<string>()
            { "\n***********MENS ORIGINALS**********",
              "Here the new top 5 Arrivals Shoes\n",
              "1. Forum Low Cl",
              "2. Forum Low Shoes",
              "3. Super Star Shoes",
              "4. Ultraboost Light",
              "5. Supernova",};

            foreach (string i in menShoes)
            {
                Console.WriteLine(i);
            }
        }
        public void womenShoes()
        {
            var womenShoes = new List<string>()
            { "\n***********WOMENS ORIGINALS***********",
              "  Here the new top 5 Arrivals Shoes\n",
              "1. Campus 00s",
              "2. NMD S1",
              "3. Stan Smith",
              "4. Agent Gil Restomod",
              "5. 3MC",};

            foreach (string i in womenShoes)
            {
                Console.WriteLine(i);
            }
        }
        public void kidsShoes()
        {
            var kidsShoes = new List<string>()
            { "\n***********KIDS ORIGINALS***********",
              "  Here the new top 5 Arrivals Shoes\n",
              "1. Grand Court Lifestyle lace",
              "2. Advantage Lifestyle Court Lace",
              "3. Tensaur Run Shoes",
              "4. NMD 360",
              "5. RapidaSport Bounce Lace",};

            foreach (string i in kidsShoes)
            {
                Console.WriteLine(i);
            }
        }
    }
    internal class Item
    {
        public void priceForMen()
        {
            var priceForMen = new List<string>()
            {
              " \nHere the all price",
              "====================================",
              "1. Forum Low Cl           Php 5,500",
              "2. Forum Low Shoes        Php 5,000",
              "3. Super Star Shoes       Php 5,300",
              "4. Ultraboost Light       Php 11,000",
              "5. Supernova              Php 5,500 ",
              "====================================\n"};
            foreach (string i in priceForMen)
            {
                Console.WriteLine(i);
            }
        }
        public void priceForWomen()
        {
            var priceForWomen = new List<string>()
            {
              " \nHere the all price",
              "====================================",
              "1. Campus 00s             Php 5,000",
              "2. NMD S1                 Php 15,000",
              "3. Stan Smith             Php 5,300",
              "4. Agent Gil Restomod     Php 7,500",
              "5. 3MC                    Php 4,500",
              "====================================\n"};

            foreach (string i in priceForWomen)
            {
                Console.WriteLine(i);
            }
        }
        public void priceForKids()
        {
            var priceForKids = new List<string>()
            {
              " \nHere the all price",
              "===================================================",
              "1. Grand Court Lifestyle lace            Php 2,200",
              "2. Advantage Lifestyle Court Lace        Php 2,200",
              "3. Tensaur Run Shoes                     Php 2,000",
              "4. NMD 360                               Php 3,500",
              "5. RapidaSport Bounce Lace               Php 3,000",
              "===================================================\n"};

            foreach (string i in priceForKids)
            {
                Console.WriteLine(i);
            }
        }
        public void sizeMenAndWomenShoes()
        {
            var sizeMenAndWomenShoes = new List<string>()
            {            "HERE THE SIZE AVAILABLE",
                "A. 8.7 inch","B. 8.9 inch","C. 9.0 inch",
                "D. 9.2 inch","E. 9.4 inch","F. 9.5 inch",
                "G. 9.7 inch","H. 9.8 inch","I. 10.0 inch"

            };

            foreach (string i in sizeMenAndWomenShoes)
            {
                Console.WriteLine(i);
            }
        }
        public void sizeKids()
        {
            var sizeKids = new List<string>()
            {          "HERE THE SIZE AVAILABLE",
                "A. 3.2 inch","B. 3.5 inch","C. 3.9 inch",
                "D. 4.2 inch","E. 4.5 inch","F. 4.9 inch",
                "G. 5.2 inch","H. 5.5 inch","I. 5.9 inch"
            };

            foreach (string i in sizeKids)
            {
                Console.WriteLine(i);
            }

        }
        public void orderForMen()
        {
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


        }
        public void orderForWomen()
        {
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
        }
        public void orderForKids()
        {
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
        }
    }
}