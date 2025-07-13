using System;

class Program
{
    static void Main(string[] args)
    {
        // Test the three different constructors
        Fraction fraction1 = new Fraction();           // Creates 1/1
        Fraction fraction2 = new Fraction(5);          // Creates 5/1  
        Fraction fraction3 = new Fraction(3, 4);       // Creates 3/4
        Fraction fraction4 = new Fraction(1, 3);       // Creates 1/3

        // Display the fractions using GetFractionString method
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

        // Test the getters and setters
        fraction1.SetNumerator(6);
        fraction1.SetDenominator(7);

        Console.WriteLine("\nAfter using setters on fraction1:");
        Console.WriteLine("Numerator: " + fraction1.GetNumerator());
        Console.WriteLine("Denominator: " + fraction1.GetDenominator());
        Console.WriteLine("Fraction: " + fraction1.GetFractionString());
        Console.WriteLine("Decimal: " + fraction1.GetDecimalValue());
    }
}