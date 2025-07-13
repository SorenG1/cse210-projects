using System;

public class Fraction
{
    // Private member variables for the numerator and denominator
    private int _numerator;
    private int _denominator;

    // Constructor with no parameters - creates 1/1
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Constructor with one parameter for the top number - creates something like 5/1
    public Fraction(int topNumber)
    {
        _numerator = topNumber;
        _denominator = 1;
    }

    // Constructor with two parameters for both top and bottom
    public Fraction(int topNumber, int bottomNumber)
    {
        _numerator = topNumber;
        _denominator = bottomNumber;
    }

    // Getter for the numerator (top number)
    public int GetNumerator()
    {
        return _numerator;
    }

    // Setter for the numerator (top number)
    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    // Getter for the denominator (bottom number)
    public int GetDenominator()
    {
        return _denominator;
    }

    // Setter for the denominator (bottom number)
    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }

    // Method to get the fraction as a string like "3/4"
    public string GetFractionString()
    {
        return _numerator + "/" + _denominator;
    }

    // Method to get the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_numerator / (double)_denominator;
    }
}
