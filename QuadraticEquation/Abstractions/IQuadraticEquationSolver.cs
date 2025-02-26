using QuadraticEquationSolver.QuadraticEquation.Coefficients;
using QuadraticEquationSolver.QuadraticEquation.Data;

namespace QuadraticEquationSolver.QuadraticEquation.Abstractions;

public interface IQuadraticEquationSolver
{
    QuadraticEquationData Solve(QuadraticEquationCoefficients coefficients);
}