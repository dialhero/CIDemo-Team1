using System.Runtime.InteropServices.Marshalling;

namespace SimpleCalculatorTest {
    [TestClass]
    public sealed class CalculatorOperationsTest {
        private SimpleCalculator.CalculatorOperations calculatorOperations;

        [TestInitialize]
        public void Initialize() {
            calculatorOperations = new SimpleCalculator.CalculatorOperations();
        }

        [TestMethod]
        public void Add_TwoNumbers() {
            //Arrange
            int a = 5;
            int b = 5;

            //Act
            int result = calculatorOperations.Add(a, b);

            //Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Subtract_TwoNumbers() {
            //Arrange
            int a = 5;
            int b = 5;

            //Act
            int result = calculatorOperations.Subtract(a, b);

            //Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Multiply_TwoNumbers() {
            //Arrange
            int a = 5;
            int b = 5;

            //Act
            int result = calculatorOperations.Multiply(a, b);

            //Assert
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void Divide_TwoNumbers() {
            //Arrange
            int a = 5;
            int b = 5;

            //Act
            double result = calculatorOperations.Divide(a, b);

            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Divide_ByZero_ThrowException() {
            //Arrange
            int a = 5;
            int b = 0;

            //Act + Assert
            Assert.Throws<DivideByZeroException>(() =>
                calculatorOperations.Divide(a, b)
            );
        }

        [TestMethod]
        public void Power_PositiveNumbers_ReturnsCorrectResult() {
            // Arrange
            double a = 2;
            double b = 3;

            // Act
            double result = calculatorOperations.Power(a, b);

            // Assert
            Assert.AreEqual(8, result, 0.0001);
        }

        [TestMethod]
        public void Power_NegativeBase_OddExponent_ReturnsNegativeResult() {
            // Arrange
            double a = -2;
            double b = 3;

            // Act
            double result = calculatorOperations.Power(a, b);

            // Assert
            Assert.AreEqual(-8, result, 0.0001);
        }

        [TestMethod]
        public void Power_NegativeBase_EvenExponent_ReturnsPositiveResult() {
            // Arrange
            double a = -2;
            double b = 2;

            // Act
            double result = calculatorOperations.Power(a, b);

            // Assert
            Assert.AreEqual(4, result, 0.0001);
        }

        [TestMethod]
        public void Power_NegativeExponent_ReturnsFraction() {
            // Arrange
            double a = 2;
            double b = -2;

            // Act
            double result = calculatorOperations.Power(a, b);

            // Assert
            Assert.AreEqual(0.25, result, 0.0001);
        }

        [TestMethod]
        public void SquareRoot_PositiveNumber_ReturnsCorrectResult() {
            // Arrange
            double a = 9;

            // Act
            double result = calculatorOperations.SquareRoot(a);

            // Assert
            Assert.AreEqual(3, result, 0.0001);
        }

        [TestMethod]
        public void SquareRoot_Zero_ReturnsZero() {
            // Arrange
            double a = 0;

            // Act
            double result = calculatorOperations.SquareRoot(a);

            // Assert
            Assert.AreEqual(0, result, 0.0001);
        }

        [TestMethod]
        public void SquareRoot_NegativeNumber_ReturnsNaN() {
            // Arrange
            double a = -9;

            // Act
            double result = calculatorOperations.SquareRoot(a);

            // Assert
            Assert.IsTrue(double.IsNaN(result));
        }
    }
}