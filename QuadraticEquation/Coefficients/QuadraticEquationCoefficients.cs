using QuadraticEquationSolver.QuadraticEquation.Coefficients.Errors;

namespace QuadraticEquationSolver.QuadraticEquation.Coefficients;

public record struct QuadraticEquationCoefficients
{
    public QuadraticEquationCoefficients(double a, double b, double c)
    {
        if (a == 0) throw new CoeffAZeroValueException();

        A = a;
        B = b;
        C = c;
    }

    public double A { get; }
    public double B { get; }
    public double C { get; }
}