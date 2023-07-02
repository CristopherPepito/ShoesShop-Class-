using ShoesShop__Class_;
using System;
using System.Runtime.ConstrainedExecution;
using static ShoesShop__Class_.Order;
using static ShoesShop__Class_.OrderForKids;
using static ShoesShop__Class_.OrderForWomen;

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
                ItemOrderedOfMen itemOrderedOfMen = new ItemOrderedOfMen();
                itemOrderedOfMen.receipt();  
            }
            else if (resultOfCategoryInput == 2)
            {
                ItemOrderedOfWomen itemOrderedOfWomen = new ItemOrderedOfWomen();
                itemOrderedOfWomen.receipt();
            }
            else if (resultOfCategoryInput == 3)
            {
                ItemOrderForKids itemOrderForKids = new ItemOrderForKids();
                itemOrderForKids.receipt();
            }
            else
            {
                Console.WriteLine("ERROR PLEASE TRY AGAIN");
                Suggestion myObject11 = new Suggestion();
                myObject11.displayCategory();
                resultOfCategoryInput = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}