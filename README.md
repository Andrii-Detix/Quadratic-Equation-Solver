# Quadratic Equation Solver

This project is a simple quadratic equation solver for equations of the form `ax^2 + bx + c = 0`. The program accepts three coefficients `a`, `b`, and `c`, and calculates the roots. There are two modes of usage:

1. **Interactive Mode**: The user enters the coefficients manually via the console.
2. **File Mode**: The user provides the path to a file containing the coefficients.

## Content Table
- [Installation](#installation)
- [Usage](#usage)
  - [Interactive Mode](#interactive-mode)
  - [File Mode](#file-mode)
- [File Format](#file-format)
- [Output](#output)
- [Error Handling](#error-handling)
- [Revert Commit](#revert-commit)
- [Author](#author)

<span id="installation"></span>
## Installation

Make sure you have [.NET 9.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) installed.

1. Clone the repository:
    ```bash
    git clone https://github.com/Andrii-Detix/Quadratic-Equation-Solver.git
    ```

2. Navigate to the project directory:
    ```bash
    cd Quadratic-Equation-Solver
    ```

3. Build the project:
    ```bash
    dotnet build
    ```

<span id="usage"></span>
## Usage

For both usage modes, make sure you are in the project directory. 

<span id="interactive-mode"></span>
### Interactive Mode

If no command-line arguments are provided, the program will start in interactive mode. The program will sequentially prompt you to enter the values for the coefficients, which you will need to input via the console.

To run the program in interactive mode, use the following command:

```bash
dotnet run
```

<span id="file-mode"></span>
### File Mode

To use the coefficients stored in a specific file, you need to pass the file path as the first command-line argument when running the program via the console.

To run the program in file mode, use the following command:

```bash
dotnet run <file-path>
```

<span id="file-format"></span>
## File Format

The file should have the coefficients in the following format:

| Example            | Format          |
|--------------------|-----------------|
| `1 -4.5 0`         | `1\s-4.5\s0\n`   |
| `6 6.4 -43.6`      | `6\s6.4\s-43.6\r\n` |

Where:
- **Decimal numbers must be written using a dot (e.g., `4.5`, not `4,5`).**
- **Numbers must be separated by a single space (`\s`).**
- **The line must end with a newline character (`\n`) or carriage return + newline (`\r\n`).**

<span id="output"></span>
## Output

After successfully running the program, the output will display the quadratic equation and its roots.

For example, if the program calculates the roots for the equation `1x² + 0.2x - 0,08 = 0`, the output will look like this:

```bash
Equation:  + (1) x^x + (0.2) x - (0.08) = 0
Amount of roots: 2
x1: 0.2
x2: -0.4
```

<span id="error-handling"></span>
## Error Handling

The program includes error handling to address potential issues that may arise during incorrect usage or execution of program. If an error occurs, the program will display the error message in the following format:

```bash
Error: <error-message>
```

### Common Errors

1. **Coefficient a zero value**
   ```bash
   Enter a: 0
   Error: Coefficient a cannot be 0
   ```
   
2. **Invalid input number**
   ```bash
   Enter b: three
   Error: Input number is not valid. Got three instead
   ```
   
3. **Incorrect file path**
   ```bash
   > dotnet run file\not\exist.txt
   Error: File with path file\not\exist.txt does not exists
   ```

4. **Invalid file format**

   Example of invalid file format:
   ```bash
   0 number 3,4
   ```

   Output:
   ```bash
   > dotnet run badfile.txt
   Error: Invalid file format
   ```

<span id="revert-commit"></span>
## Revert Commit

During the development of the program, two commit reverts were made.

1. **Revert: Incorrect name of ICoefficientController**

   Revert commit has the hash `1c697ab`, and it can be found at the following [link](https://github.com/Andrii-Detix/Quadratic-Equation-Solver/commit/1c697abe1ae5ae84ca3482e1bd039bb27ffd0f96).

2. **Revert: InputCoefficientController is responsible for showing errors, but it hasn't to be**

   Revert commit has the hash `b05d69b`, and it can be found at the following [link](https://github.com/Andrii-Detix/Quadratic-Equation-Solver/commit/b05d69b07168ce70e9c5a6ca5fa47ff123d7a990#diff-b84185364dc5c3b4eb856b13c860a7b7acf503acde392453cd08531782080095).

<span id="author"></span>
## Author

Developed by [Andrii Ivanchyshyn](https://github.com/Andrii-Detix/Sliding_Puzzle_Project/commits?author=Andrii-Detix).
