using System.Globalization;
using QuadraticEquationSolver.Controllers.Abstractions;
using QuadraticEquationSolver.Controllers.InputControllers.Errors;
using QuadraticEquationSolver.QuadraticEquation.Coefficients;
using QuadraticEquationSolver.QuadraticEquation.Coefficients.Errors;

namespace QuadraticEquationSolver.Controllers.InputControllers;

public class InputCoefficientController : ICoefficientsController
{
    public QuadraticEquationCoefficients GetData()
    {
        Dictionary<string, double> inputCoefficients = new Dictionary<string, double>
        {
            { "a", 0 },
            { "b", 0 },
            { "c", 0 }
        };

        foreach (var key in inputCoefficients.Keys)
        {
            inputCoefficients[key] = GetCoefficient(key);
        }

        var coefficients = new QuadraticEquationCoefficients(
            inputCoefficients["a"],
            inputCoefficients["b"],
            inputCoefficients["c"]);

        return coefficients;
    }

    private double GetCoefficient(string coefName)
    {
        while (true)
        {
            Console.Write($"Enter {coefName}: ");
            string input = Console.ReadLine();

            bool isValid = double.TryParse(input, CultureInfo.InvariantCulture, out double coefficient);
            if (!isValid)
            {
                ShowErrors(new InvalidNumberException(input));
                continue;
            }

            if (coefName == "a" && coefficient == 0)
            {
                ShowErrors(new CoeffAZeroValueException());
                continue;
            }

            return coefficient;
        }
    }

    private void ShowErrors(Exception exception)
    {
        const string errorTitle = "Error: ";
        ConsoleColor originalColor = Console.ForegroundColor;
        ConsoleColor errorColor = ConsoleColor.Red;

        Console.ForegroundColor = errorColor;
        Console.Write(errorTitle);
        Console.ForegroundColor = originalColor;
        Console.WriteLine(exception.Message);
    }
}