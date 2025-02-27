using QuadraticEquationSolver.Controllers;
using QuadraticEquationSolver.Controllers.Abstractions;
using QuadraticEquationSolver.Presenters.Abstractions;
using QuadraticEquationSolver.Presenters.ErrorPresenters;
using QuadraticEquationSolver.Presenters.QuadraticEquationPresenter;
using QuadraticEquationSolver.QuadraticEquation.Abstractions;
using QuadraticEquationSolver.QuadraticEquation.Solvers;

IErrorPresenter errorPresenter = new ErrorPresenter();

try
{
    ICoefficientsController controller = new ControllerFactory().Create(args, errorPresenter);
    var coefficients = controller.GetData();

    IQuadraticEquationSolver solver = new QuadraticSolver();
    var result = solver.Solve(coefficients);

    IQuadraticEquationPresenter equationPresenter = new QuadraticEquationPresenter();
    equationPresenter.Present(result);
}
catch (Exception ex)
{
    errorPresenter.Present(ex);
    Environment.Exit(1);
}