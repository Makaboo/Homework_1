// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;

Console.WriteLine("Hello, World!");
Console.WriteLine("Xiao Li " +
    "\nCPS 3330*01 - SOFTWARE DEV WITH FRAMEWORKS");
Console.WriteLine("Instructor: Dr. Yulia Kumar");
Console.WriteLine("Version: {0}", Environment.Version.ToString());

double price, discount, discountPrice;
string restart;

// Output
do
{
    // User Enter the price
    Console.Write("\nGet the price from the user: $");
    price = Convert.ToDouble(Console.ReadLine());

    if (price < 100)
    {
        discount = .10;
        discountPrice = price * discount;
        Console.WriteLine("\nYou entered $" + price + " and the price you enter is less than $100. Discount Price is 10%.");
        Console.WriteLine("The discounted price is: $" + discountPrice);

        price = price - discountPrice;
        Console.WriteLine("Your Grand Total is: $" + price);
    }
    else
    {
        discount = .14;
        discountPrice = price * discount;
        Console.WriteLine("\nYou entered $" + price + " and the price you enter is more than $100. Discount Price is 14%.");
        Console.WriteLine("The discounted price is: $" + discountPrice);

        price = price - discountPrice;
        Console.WriteLine("Your Grand Total is: $" + price);
    }

    // Ask user if they want to enter a another price
    Console.WriteLine("\nDo you wish to calculate another? (YES / NO) ");
    restart = Console.ReadLine().ToUpper();
    while ((restart != "YES") && (restart != "NO"))
    {
        Console.WriteLine("Error");
        Console.WriteLine("Do you wish to calculate another? (YES / NO) ");
        restart = Console.ReadLine().ToUpper();
    }
} while (restart == "YES");