using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator {
    public interface ICalculator {
        int Add(int a, int b);
        int Subtract(int a, int b);
        int Multiply(int a, int b);
        double Divide(int a, int b);
    }
}
