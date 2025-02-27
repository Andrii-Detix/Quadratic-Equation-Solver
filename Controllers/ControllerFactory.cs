using QuadraticEquationSolver.Controllers.Abstractions;
using QuadraticEquationSolver.Controllers.FileControllers;
using QuadraticEquationSolver.Controllers.InputControllers;
using QuadraticEquationSolver.Presenters.Abstractions;

namespace QuadraticEquationSolver.Controllers;

public class ControllerFactory
{
    public ICoefficientsController Create(string[] args, IErrorPresenter errorPresenter)
    {
        return args.Count() switch
        {
            0 => new InputCoefficientsController(errorPresenter),
            1 => new FileCoefficientsController(args[0]),
            _ => new FileCoefficientsController(args[0])
        };
    }
}