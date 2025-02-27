using QuadraticEquationSolver.Controllers.Abstractions;
using QuadraticEquationSolver.Controllers.InputControllers;
using QuadraticEquationSolver.Presenters.Abstractions;
using QuadraticEquationSolver.Presenters.ErrorPresenters;
using QuadraticEquationSolver.Presenters.QuadraticEquationPresenter;
using QuadraticEquationSolver.QuadraticEquation.Abstractions;
using QuadraticEquationSolver.QuadraticEquation.Solvers;

IErrorPresenter errorPresenter = new ErrorPresenter();

ICoefficientsController controller = new InputCoefficientsController(errorPresenter);
var coefficients = controller.GetData();

IQuadraticEquationSolver solver = new QuadraticSolver();
var result = solver.Solve(coefficients);

IQuadraticEquationPresenter equationPresenter = new QuadraticEquationPresenter();
equationPresenter.Present(result);