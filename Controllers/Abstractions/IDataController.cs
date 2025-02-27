namespace QuadraticEquationSolver.Controllers.Abstractions;

public interface IDataController<T>
{
    T GetData();
}