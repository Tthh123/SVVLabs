using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Calculator
{
    public Calculator() { }
    public double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN; // Default value
                                    // Use a switch statement to do the math.
        switch (op)
        {
            case "a":
                result = Add(num1, num2);
                break;
            case "s":
                result = Subtract(num1, num2);
                break;
            case "m":
                result = Multiply(num1, num2);
                break;
            case "d":
                // Ask the user to enter a non-zero divisor.
                result = Divide(num1, num2);
                break;
            case "f":
                result = Factorial(num1);
                break;
            // Return text for an incorrect option entry.
            default:
                break;
        }
        return result;
    }
    public double Add(double num1, double num2)
    {
        return (num1 + num2);
    }
    public double Subtract(double num1, double num2)
    {
        return (num1 - num2);
    }
    public double Multiply(double num1, double num2)
    {
        return (num1 * num2);
    }
    public double Divide(double num1, double num2)
    {
        if (num1==0 || num2== 0){
            throw new ArgumentException();
        }
        return (num1 / num2);
    }
    public double Factorial(double num1)
    {
        if (num1 < 0) {
            throw new ArgumentException();
        }
        if (num1 == 1 || num1 == 0) {
            return 1;
        }
        return (num1 * Factorial(num1-1));
    }
    public double CalTriangle(double num1, double num2) {
        return ((0.5) *Multiply(num1,num2));
    }
    public double CalCircle(double radius) {
        double area = Math.PI * Math.Pow(radius, 2);
        return Math.Round(area, 2);
    }
    public double UnknownFunctionA(double num1, double num2) { 
        if (num1 < num2)
        {
            throw new ArgumentException();
        }
        return Divide(Factorial(num1), Factorial(Subtract(num1, num2)));
    }
    public double UnknownFunctionB(double num1, double num2)
    {
        if (num1 < num2)
        {
            throw new ArgumentException();
        }
        double denominator = Multiply(Factorial(num2), Factorial(Subtract(num1, num2)));
        return (Factorial(num1) / denominator);
    }
}