using System;
class Complex
{
    private double realPart; // 실수부
    private double imagePart; // 허수부
    public Complex(double rVal, double iVal)
    {
        realPart = rVal;
        imagePart = iVal;
    }
    public static Complex operator +(Complex x1, Complex x2)
    {
        Complex x = new Complex(0, 0);
        x.realPart = x1.realPart + x2.realPart;
        x.imagePart = x1.imagePart + x2.imagePart;
        return x;
    }
    override public string ToString()
    {
        return "(" + realPart + "," + imagePart + "i)";
    }
}
class OperatorOverloadingApp
{
    public static void Main()
    {
        Complex c, c1, c2;
        c1 = new Complex(1, 2);
        c2 = new Complex(3, 4);
        c = c1 + c2;
        Console.WriteLine(c1 + " + " + c2 + " = " + c);
    }
}