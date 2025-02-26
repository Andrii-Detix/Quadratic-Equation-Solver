using System.Globalization;
using QuadraticEquationSolver.Controllers.Abstractions;
using QuadraticEquationSolver.Controllers.InputControllers.Errors;
using QuadraticEquationSolver.QuadraticEquation.Coefficients;

namespace QuadraticEquationSolver.Controllers.InputControllers;

public class InputCoefficientController : ICoefficientsController
{
    public QuadraticEquationCoefficients GetData()
    {
        Dictionary<string, double> inputCoefficients = new Dictionary<string, double>
        {
            { "a", default },
            { "b", default },
            { "c", default }
        };

        foreach (var key in inputCoefficients.Keys)
        {
            inputCoefficients[key] = GetCoefficient(key);
        }

        var coefs = new QuadraticEquationCoefficients(
            inputCoefficients["a"],
            inputCoefficients["b"],
            inputCoefficients["c"]);

        return coefs;
    }

    private double GetCoefficient(string coefName)
    {
        while (true)
        {
            Console.Write($"Enter {coefName}: ");
            string input = Console.ReadLine();

            double coefficient = double.Parse(input, CultureInfo.InvariantCulture);

            return coefficient;
        }
    }
}