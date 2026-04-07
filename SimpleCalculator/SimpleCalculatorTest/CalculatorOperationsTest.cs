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
    }
}