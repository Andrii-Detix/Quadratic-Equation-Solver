using System.Globalization;
using System.Text;
using QuadraticEquationSolver.Presenters.Abstractions;
using QuadraticEquationSolver.QuadraticEquation.Coefficients;
using QuadraticEquationSolver.QuadraticEquation.Data;

namespace QuadraticEquationSolver.Presenters.QuadraticEquationPresenter;

public class QuadraticEquationPresenter : IQuadraticEquationPresenter
{
    private const char RootChar = 'x';

    public void Present(QuadraticEquationData value)
    {
        string str = SerializeEquation(value.Coefficients) + SerializeRoots(value);
        Console.Write(str);
    }

    private string SerializeEquation(QuadraticEquationCoefficients coefficients)
    {
        string equation = new StringBuilder().AppendJoin(' ',
            "Equation: ",
            GetCoefficientSign(coefficients.A),
            SerializeCoefficient(coefficients.A),
            $"{RootChar}^{RootChar}",
            GetCoefficientSign(coefficients.B),
            SerializeCoefficient(coefficients.B),
            $"{RootChar}",
            GetCoefficientSign(coefficients.C),
            SerializeCoefficient(coefficients.C),
            "= 0").AppendLine().ToString();

        return equation;
    }

    private string SerializeCoefficient(double coefficient)
    {
        double absCoefficient = Math.Abs(coefficient);
        string str = absCoefficient.ToString(CultureInfo.InvariantCulture);
        return $"({str})";
    }

    private char GetCoefficientSign(double coefficient)
    {
        return coefficient < 0 ? '-' : '+';
    }

    private string SerializeRoots(in QuadraticEquationData data)
    {
        StringBuilder roots = new StringBuilder();

        double count = data.RootCount;
        int index = 1;

        roots.Append("Amount of roots: ").Append(count).AppendLine();
        foreach (var root in data.Roots)
        {
            double rounded = RoundDoubleNumber(root);
            
            roots.Append(RootChar).Append(index).Append(": ")
                .Append(rounded.ToString(CultureInfo.InvariantCulture))
                .AppendLine();

            index++;
        }

        return roots.ToString();
    }

    private double RoundDoubleNumber(double value)
    {
        const int decimalPlaces = 6;
        return Math.Round(value, decimalPlaces);
    }
}