namespace QuadraticEquationSolver.Presenters.Abstractions;

public interface IPresenter<T>
{
    void Present(T data);
}