using QuadraticEquationSolver.QuadraticEquation.Coefficients;
using QuadraticEquationSolver.QuadraticEquation.Data.Errors;

namespace QuadraticEquationSolver.QuadraticEquation.Data;

public record struct QuadraticEquationData
{
    public QuadraticEquationData(QuadraticEquationCoefficients coefficients, IReadOnlyCollection<double> roots)
    {
        if (!IsValidRoots(roots)) throw new InvalidAmountOfRootsException();

        Coefficients = coefficients;
        Roots = roots;
    }

    public QuadraticEquationCoefficients Coefficients { get; }
    public IReadOnlyCollection<double> Roots { get; }
    public int RootCount => Roots.Count;

    private bool IsValidRoots(IReadOnlyCollection<double> roots)
    {
        if (roots is null) return false;
        
        const int min = 0;
        const int max = 2;
        
        int count = roots.Count;

        return count >= min && count <= max;
    }
}