namespace QuadraticEquationSolver.Controllers.FileControllers.Errors;

public class FileNotExistsException(string path) : Exception($"File with path {path} does not exists")
{
    
}