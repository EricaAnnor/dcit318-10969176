using System;

public class TriangleTypeIdentifier
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the length of the first side: ");
        double side1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the length of the second side: ");
        double side2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the length of the third side: ");
        double side3 = double.Parse(Console.ReadLine());

        string triangleType = IdentifyTriangleType(side1, side2, side3);
        Console.WriteLine($"The triangle is: {triangleType}");
    }

    public static string IdentifyTriangleType(double side1, double side2, double side3)
    {
        

        if (side1 == side2 && side2 == side3)
        {
            return "Equilateral Triangle";
        }

        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            return "Isosceles Triangle";
        }

        else
        {
            return "Scalene Triangle";
        }
    }
}
