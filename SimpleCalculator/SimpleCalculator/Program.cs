namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Im your NoobCalculator");

            var calculator = new CalculatorOperations();
            var keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("\nEnter expression (examples: 12+7, 50-12, 20/5, 2^8, sqrt(81) or sqrt81):");
                var expression = (Console.ReadLine() ?? string.Empty).Replace(" ", "");

                if (expression.StartsWith("sqrt", StringComparison.OrdinalIgnoreCase))
                {
                    var valueText = expression
                        .Substring(4)       // remove "sqrt"
                        .Trim('(', ')');    // allow sqrt(81) or sqrt81

                    if (int.TryParse(valueText, out var inputA))
                    {
                        Console.Write("\n*************************************************");
                        Console.WriteLine($"\nsqrt({inputA}) equals {calculator.SquareRoot(inputA)}");
                        Console.Write("*************************************************\n");
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid sqrt input.");
                    }
                }
                else
                {
                    int opPos = -1;
                    char op = '\0';

                    for (int i = 1; i < expression.Length; i++) // start at 1 so left side can be negative
                    {
                        if ("+-*/^".Contains(expression[i]))
                        {
                            opPos = i;
                            op = expression[i];
                            break;
                        }
                    }

                    if (opPos > 0 &&
                        int.TryParse(expression[..opPos], out var inputA) &&
                        int.TryParse(expression[(opPos + 1)..], out var inputB))
                    {
                        switch (op)
                        {
                            case '+':
                                Console.Write("\n*************************************************");
                                Console.WriteLine($"\n{inputA} + {inputB} equals {calculator.Add(inputA, inputB)}");
                                Console.Write("*************************************************\n");
                                break;

                            case '-':
                                Console.Write("\n*************************************************");
                                Console.WriteLine($"\n{inputA} - {inputB} equals {calculator.Subtract(inputA, inputB)}");
                                Console.Write("*************************************************\n");
                                break;

                            case '*':
                                Console.Write("\n*************************************************");
                                Console.WriteLine($"\n{inputA} * {inputB} equals {calculator.Multiply(inputA, inputB)}");
                                Console.Write("*************************************************\n");
                                break;

                            case '/':
                                try
                                {
                                    Console.Write("\n*************************************************");
                                    Console.WriteLine($"\n{inputA} / {inputB} equals {calculator.Divide(inputA, inputB)}");
                                    Console.Write("*************************************************\n");
                                }
                                catch (DivideByZeroException)
                                {
                                    //Console.Write("\n*************************************************");
                                    Console.WriteLine("\nCannot divide by zero.");
                                    Console.Write("*************************************************\n");
                                }
                                break;

                            case '^':
                                Console.Write("\n*************************************************");
                                Console.WriteLine($"\n{inputA} ^ {inputB} equals {calculator.Power(inputA, inputB)}");
                                Console.Write("*************************************************\n");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid expression format.");
                    }
                }
                Console.Write("Do another calculation? (y/n): ");
                keepRunning = string.Equals(Console.ReadLine(), "y", StringComparison.OrdinalIgnoreCase);
            }
        }
    }
}

