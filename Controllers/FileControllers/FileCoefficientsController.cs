using System.Globalization;
using System.Text.RegularExpressions;
using QuadraticEquationSolver.Controllers.Abstractions;
using QuadraticEquationSolver.Controllers.FileControllers.Errors;
using QuadraticEquationSolver.QuadraticEquation.Coefficients;

namespace QuadraticEquationSolver.Controllers.FileControllers;

public class FileCoefficientsController : ICoefficientsController
{
    private readonly string _filePath;

    public FileCoefficientsController(string filePath)
    {
        _filePath = filePath;
    }

    public QuadraticEquationCoefficients GetData()
    {
        string fileContent = GetFileContent();
        var coefficients = ParseFileContent(fileContent);
        return coefficients;
    }

    private string GetFileContent()
    {
        string content = string.Empty;

        if (!File.Exists(_filePath)) throw new FileNotExistsException(_filePath);

        using (var reader = new StreamReader(_filePath))
        {
            content = reader.ReadToEnd();
        }

        return content;
    }

    private QuadraticEquationCoefficients ParseFileContent(string fileContent)
    {
        const char separator = ' ';
        const int numOfCoefficients = 3;

        if (!IsValidFileFormat(fileContent)) throw new InvalidFileFormatException();

        string[] strCoefsArr = fileContent.Split(separator);

        double[] coefsArr = new double[numOfCoefficients];

        for (int i = 0; i < numOfCoefficients; i++)
        {
            coefsArr[i] = double.Parse(strCoefsArr[i], CultureInfo.InvariantCulture);
        }

        QuadraticEquationCoefficients coefficients = new QuadraticEquationCoefficients(coefsArr[0], coefsArr[1], coefsArr[2]);
        
        return coefficients;
    }

    private bool IsValidFileFormat(string fileContent)
    {
        const string regexPattern =
            @"^([0-9]+|[0-9]+\.[0-9]+)\s([0-9]+|[0-9]+\.[0-9]+)\s([0-9]+|[0-9]+\.[0-9]+)(\n|\r\n)$";
        bool isValid = Regex.IsMatch(fileContent, regexPattern);

        return isValid;
    }
}