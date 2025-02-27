using QuadraticEquationSolver.Presenters.Abstractions;

namespace QuadraticEquationSolver.Presenters.ErrorPresenters;

public class ErrorPresenter : IErrorPresenter
{
    private const string ErrorTitle = "Error: ";
    private readonly ConsoleColor _originalColor = Console.ForegroundColor;
    private readonly ConsoleColor _errorColor = ConsoleColor.Red;

    public void Present(Exception exception)
    {
        Console.ForegroundColor = _errorColor;
        Console.Write(ErrorTitle);
        Console.ForegroundColor = _originalColor;
        Console.WriteLine(exception.Message);
    }
}