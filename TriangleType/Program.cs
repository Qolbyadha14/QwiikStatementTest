using System;

public class Program
{
    public static string DetermineTriangleType(int side1, int side2, int side3)
    {
        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            throw new ArgumentException("Sides must be greater than 0.");
        }

        if (side1 == side2 && side2 == side3)
        {
            return "Equilateral Triangle";
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            return "Isosceles Triangle";
        }
        else
        {
            return "Scalene Triangle";
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter the three sides of the triangle:");
        int side1 = Convert.ToInt32(Console.ReadLine());
        int side2 = Convert.ToInt32(Console.ReadLine());
        int side3 = Convert.ToInt32(Console.ReadLine());

        try
        {
            string triangleType = DetermineTriangleType(side1, side2, side3);
            Console.WriteLine("The triangle is a {0}", triangleType);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
