using System;

class Fraction
{
    private int numerator;
    private int denominator;
     public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }
    public Fraction(int top)
    {
        numerator = top;
        denominator = 1;
    }
    public Fraction(int top, int bottom)
    {
        numerator = top;
        denominator = bottom;
    }

    public int GetNumerator()
    {
        return numerator;
    }

    public void SetNumerator(int numerator)
    {
        numerator = 5;
    }
}