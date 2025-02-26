using QuadraticEquationSolver.QuadraticEquation.Abstractions;
using QuadraticEquationSolver.QuadraticEquation.Coefficients;
using QuadraticEquationSolver.QuadraticEquation.Data;

namespace QuadraticEquationSolver.QuadraticEquation.Solvers;

public class QuadraticSolver : IQuadraticEquationSolver
{
    public QuadraticEquationData Solve(QuadraticEquationCoefficients coefficients)
    {
        double discriminant = GetDiscriminant(coefficients);
        List<double> roots = FindRoots(coefficients, discriminant);

        QuadraticEquationData result = new QuadraticEquationData(coefficients, roots);

        return result;
    }

    private double GetDiscriminant(QuadraticEquationCoefficients coefficients)
    {
        return coefficients.B * coefficients.B - 4 * coefficients.A * coefficients.C;
    }

    private List<double> FindRoots(QuadraticEquationCoefficients coefficients, double discriminant)
    {
        List<double> roots = new List<double>();

        if (discriminant < 0) return roots;

        double root = FindRoot(coefficients, discriminant);
        roots.Add(root);

        if (discriminant > 0)
        {
            int sign = -1;
            root = FindRoot(coefficients, discriminant, sign);
            roots.Add(root);
        }

        return roots;
    }

    private double FindRoot(QuadraticEquationCoefficients coefficients, double discriminant, int sign = 1)
    {
        return (-coefficients.B + sign * Math.Sqrt(discriminant)) / (2 * coefficients.A);
    }
}