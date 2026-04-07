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
                Console.WriteLine("\nUse one of: +, -, *, /, ^, sqrt");

                Console.Write("\nEnter the first number: ");
                var inputA = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the operator: ");
                var inputOperator = Console.ReadLine()?.Trim().ToLowerInvariant();

                if (inputOperator == "sqrt")
                {

                    Console.WriteLine($"\nsqrt({inputA}) equals {calculator.SquareRoot(inputA)}");
                }
                else
                {
                    Console.Write("\nEnter the second number: ");
                    var inputB = Convert.ToInt32(Console.ReadLine());



                    switch (inputOperator)
                    {
                        case "+":
                            Console.WriteLine($"\n{inputA} + {inputB} equals {calculator.Add(inputA, inputB)}");
                            break;

                        case "-":
                            Console.WriteLine($"\n{inputA} - {inputB} equals {calculator.Subtract(inputA, inputB)}");
                            break;

                        case "*":
                            Console.WriteLine($"\n{inputA} * {inputB} equals {calculator.Multiply(inputA, inputB)}");
                            break;

                        case "/":
                            try
                            {
                                Console.WriteLine($"\n{inputA} / {inputB} equals {calculator.Divide(inputA, inputB)}");
                            }
                            catch (DivideByZeroException)
                            {
                                Console.WriteLine("\nCannot divide by zero.");
                            }
                            break;

                        case "^":
                            Console.WriteLine($"{inputA} ^ {inputB} equals {calculator.Power(inputA, inputB)}");
                            break;

                        default:
                            Console.WriteLine("\nUnknown operator. Use one of: +, -, *, /, ^, sqrt");
                            break;
                    }
                }
                Console.Write("Do another calculation? (y/n): ");
                keepRunning = string.Equals(Console.ReadLine(), "y", StringComparison.OrdinalIgnoreCase);
            }


        }
    }
}

