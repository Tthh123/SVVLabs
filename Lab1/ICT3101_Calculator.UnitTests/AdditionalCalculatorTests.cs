using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using static Calculator;

namespace ICT3101_Calculator.UnitTests
{
    public class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr =>
            fr.Read("MagicNumbers.txt")).Returns(new string[2] { "1.5", "-3.4" });
            _calculator = new Calculator();
        }

        [Test]
        public void GenMagicNum_ValidPositiveInput_ReturnsCorrectResult()
        {
            // Arrange
            double input = 0; // Corresponds to magicNumbers[0] -> "1.5"
            double expectedResult = 3.0; // 2 * 1.5

            // Act
            double result = _calculator.GenMagicNum(input, _mockFileReader.Object); // Use mock object

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult)); // Using Assert.That()
        }

        [Test]
        public void GenMagicNum_ValidNegativeInput_ReturnsCorrectResult()
        {
            // Arrange
            double input = 1; // Corresponds to magicNumbers[1] -> "-3.4"
            double expectedResult = 6.8; // Absolute value of 2 * -3.4

            // Act
            double result = _calculator.GenMagicNum(input, _mockFileReader.Object); // Use mock object

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult)); // Using Assert.That()
        }

        [Test]
        public void GenMagicNum_InputOutOfBounds_ReturnsZero()
        {
            // Arrange
            double input = 5; // Out of bounds as magicNumbers only has 2 entries
            double expectedResult = 0; // Expected result when out of bounds

            // Act
            double result = _calculator.GenMagicNum(input, _mockFileReader.Object); // Use mock object

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult)); // Using Assert.That()
        }

        [Test]
        public void GenMagicNum_NegativeIndex_ReturnsZero()
        {
            // Arrange
            double input = -1; // Negative index
            double expectedResult = 0; // Expected result for negative index

            // Act
            double result = _calculator.GenMagicNum(input, _mockFileReader.Object); // Use mock object

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult)); // Using Assert.That()
        }
    }

    
}
