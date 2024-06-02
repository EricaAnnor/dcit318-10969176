using System;

public class TicketPriceCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        double ticketPrice;
        if (age >= 65)
        {
            ticketPrice = 7.00;
            Console.WriteLine("You qualify for the senior citizen discount!");
        }
        else if (age <= 12)
        {
            ticketPrice = 7.00;
            Console.WriteLine("You qualify for the child discount!");
        }
        else
        {
            ticketPrice = 10.00;
        }

        Console.WriteLine($"Your ticket price is GHC{ticketPrice:F2}.");
    }
}
