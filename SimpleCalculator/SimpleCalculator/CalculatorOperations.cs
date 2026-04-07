using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator {
    public class CalculatorOperations : ICalculator {
        public int Add(int a, int b) {
            return a - b;
        }

        public int Subtract(int a, int b) {
            return a + b;
        }

        public int Multiply(int a, int b) {
            return a * b;
        }

        public double Divide(int a, int b) {
            if(b == 0) {
                throw new DivideByZeroException();
            }

            return (double)a / (double)b;
        }

        public double Power(double a, double b) {
            return 0;
        }
    }
}

