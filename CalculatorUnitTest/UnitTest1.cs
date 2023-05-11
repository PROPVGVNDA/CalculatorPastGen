using NUnit.Framework;

namespace CalculatorPastGen
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Decimal_Calculate_Addition()
        {
            // Arrange
            Calculator calculator = new Decimal();

            // Act
            long result = calculator.Calculate('+', 5, 3);

            // Assert
            Assert.AreEqual(8, result);
        }

        [Test]
        public void Binary_ParseFromString()
        {
            // Arrange
            Calculator calculator = new Binary();
            string binaryString = "1010";

            // Act
            long result = calculator.ParseFromString(binaryString);

            // Assert
            Assert.AreEqual(10, result);
        }

        [Test]
        public void Hexadecimal_ParseToStringFromStr()
        {
            // Arrange
            Calculator calculator = new Hexadecimal();
            string decimalString = "255";
            ushort numberBase = 10;

            // Act
            string result = calculator.ParseToStringFromStr(decimalString, numberBase);

            // Assert
            Assert.AreEqual("FF", result);
        }

        // Add more test methods for other operations and scenarios
    }
}
