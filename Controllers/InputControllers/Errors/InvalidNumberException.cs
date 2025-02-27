namespace QuadraticEquationSolver.Controllers.InputControllers.Errors;

public class InvalidNumberException(string input) : Exception($"Input number is not valid. Got {input} instead")
{
    
}