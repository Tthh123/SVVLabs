using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public class Calculator
{
    public interface IFileReader
    {
        string[] Read(string path);
    }


    public class FileReader : IFileReader
    {
        public string[] Read(string path)
        {
            return File.ReadAllLines(path);
        }
    }

    public Calculator() { }
    public double DoOperation(double num1, double num2, double num3, string op)
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
                result = Divide(num1, num2);
                break;
            case "f":
                result = Factorial(num1);
                break;
            case "i":
                result = CalCircle(num1); // Use num1 as the radius for the circle
                break;
            case "e":
                result = CalTriangle(num1, num2); // Use num1 as base and num2 as height
                break;
            case "g":
                result = UnknownFunctionA(num1, num2); // Placeholder function for unknown behavior
                break;
            case "h":
                result = UnknownFunctionB(num1, num2); // Placeholder function for unknown behavior
                break;
            case "mbtf":
                result = CalculateMTBF(num1, num2); // MTBF Calculation
                break;
            case "ava":
                result = CalculateAvailability(num1, num2); // Availability Calculation
                break;
            case "cfi":
                result = CalculateCurrentFailureIntensity(num1, num2, num3); // Current Failure Intensity Calculation
                break;
            case "aef":
                result = CalculateExpectedFailures(num1, num2, num3); // Average Expected Failures Calculation
                break;
            default:
                Console.WriteLine("Unknown operator.");
                break;
        }

        return result;
    }

    public double Add(double num1, double num2)
    {
        // Convert num1 and num2 to strings for easier validation
        string num1String = num1.ToString();
        string num2String = num2.ToString();

        // Check if both numbers contain only 1s and 0s (i.e., they can be treated as binary)
        bool isNum1Binary = num1String.All(c => c == '0' || c == '1');
        bool isNum2Binary = num2String.All(c => c == '0' || c == '1');

        // If both numbers are binary, concatenate their binary representations
        if (isNum1Binary && isNum2Binary)
        {

            // Concatenate the two binary strings
            string concatenatedBinary = num1String + num2String;

            // Convert the concatenated binary string back to a decimal number
            double result = Convert.ToInt32(concatenatedBinary, 2);

            return result;
        }
        else
        {
            // If either number contains digits other than 0 or 1, perform regular addition
            return num1 + num2;
        }
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
        if (num1 == 0 && num2 != 0)
        {
            return 0;
        }

        if (num2 == 0 && num1 != 0)
        {
            return double.PositiveInfinity;
        }

        if (num1 == 0 && num2 == 0)
        {
            return 1;
        }

        // Regular division for non-special cases
        return num1 / num2;
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
        if (num1 <= 0 || num2 <= 0) {
            throw new ArgumentException();
        }
        return ((0.5) *Multiply(num1,num2));
    }
    public double CalCircle(double radius) {
        if (radius <= 0)
        {
            throw new ArgumentException();
        }
        double area = Math.PI * Math.Pow(radius, 2);
        return Math.Round(area, 2);
    }
    public double UnknownFunctionA(double num1, double num2) { 
        if (num1 < num2 || num1<0||num2<0)
        {
            throw new ArgumentException();
        }
        if (num1 % 1 != 0 || num2 % 1 != 0)
        {
            throw new ArgumentException("Both num1 and num2 must be integers.");
        }
        return Divide(Factorial(num1), Factorial(Subtract(num1, num2)));
    }
    public double UnknownFunctionB(double num1, double num2)
    {
        if (num1 < num2 || num1 < 0 || num2 < 0)
        {
            throw new ArgumentException();
        }
        if (num1 % 1 != 0 || num2 % 1 != 0)
        {
            throw new ArgumentException("Both num1 and num2 must be integers.");
        }
        double denominator = Multiply(Factorial(num2), Factorial(Subtract(num1, num2)));
        return (Factorial(num1) / denominator);
    }
    public double CalculateMTBF(double MTTF, double MTTR)
    {
        if (MTTF < 0 || MTTR < 0)
        {
            throw new ArgumentException("MTTF and MTTR must be non-negative.");
        }

        // MTBF = MTTF + MTTR
        return Add(MTTF, MTTR);
    }

    public double CalculateAvailability(double MTTF, double MTBF)
    {
        if (MTTF < 0 || MTBF <= 0)
        {
            throw new ArgumentException("MTTF must be non-negative, and MTBF must be greater than zero.");
        }

        // Availability = MTTF / MTBF
        double availability = Divide(MTTF, MTBF) * 100; // Converting to percentage
        return Math.Round(availability, 2); // Round to 2 decimal places
    }

    public double CalculateCurrentFailureIntensity(double lambda0, double mu, double v0)
    {
        if (lambda0 < 0 || mu < 0 || v0 <= 0)
        {
            throw new ArgumentException("lambda0, mu, and v0 must be non-negative, and v0 must be greater than zero.");
        }

        if (mu > v0)
        {
            throw new ArgumentException("Expected failures (mu) cannot be greater than the total failures (v0).");
        }

        // λ(τ) = λ₀ [1 - μ / v₀]
        double result = lambda0 * (1 - (mu / v0));
        return Math.Round(result, 2); // Rounding to 2 decimal places
    }

    public double CalculateExpectedFailures(double v0, double lambda0, double tau)
    {
        if (v0 <= 0 || lambda0 <= 0 || tau < 0)
        {
            throw new ArgumentException("v0 and lambda0 must be greater than zero, and tau must be non-negative.");
        }

        // μ(τ) = v₀ [1 - exp(-λ₀ / v₀ * τ)]
        double result = v0 * (1 - Math.Exp(-lambda0 / v0 * tau));
        return Math.Round(result, 2); // Rounding to 2 decimal places
    }


    public double CalculateDefectDensity(double defects, double linesOfCode)
    {
        if (linesOfCode <= 0)
        {
            throw new ArgumentException("Lines of code must be greater than zero.");
        }

        return defects / linesOfCode;
    }
    public double CalculateTotalSSI(double release1, double release2)
    {
        if (release1 < 0 || release2 < 0)
        {
            throw new ArgumentException("SSI values must be non-negative.");
        }

        return release1 + release2;
    }

    public double CalculateLogModelFailureIntensity(double lambda0, double theta, double mu)
    {
        if (lambda0 < 0 || theta < 0 || mu < 0)
        {
            throw new ArgumentException("lambda0, theta, and mu must be non-negative.");
        }

        // λ(τ) = λ₀ * exp(-θ * μ)
        double result = lambda0 * Math.Exp(-theta * mu);
        return Math.Round(result, 2); // Rounding to 2 decimal places
    }

    public double CalculateLogModelExpectedFailures(double lambda0, double theta, double tau)
    {
        if (lambda0 < 0 || theta <= 0 || tau < 0)
        {
            throw new ArgumentException("lambda0, theta must be greater than zero, and tau must be non-negative.");
        }

        // μ(τ) = (1 / θ) * ln(λ₀ * θ * τ + 1)
        double result = (1 / theta) * Math.Log(lambda0 * theta * tau + 1);
        return Math.Round(result, 2); // Rounding to 2 decimal places
    }


    public double GenMagicNum(double input, IFileReader fileReader)
    {
        double result = 0;
        int choice = Convert.ToInt16(input);

        string[] magicStrings = fileReader.Read("C:\\Users\\chipp\\Documents\\School\\Y3T1\\SVVLabs\\MagicNumbers.txt");

        if ((choice >= 0) && (choice < magicStrings.Length))
        {
            result = Convert.ToDouble(magicStrings[choice]);
        }

        result = (result > 0) ? (2 * result) : (-2 * result);
        return result;
    }


}