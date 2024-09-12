namespace ICT3101_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()//Method_Scenario_Result
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }
        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_Returns()
        {
            //Arrange
            double result = _calculator.Subtract(20, 20);
            //Assert
            Assert.That (result, Is.EqualTo(0));
        }
        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ReturnsHundred()
        {
            //Arrange
            double result = _calculator.Multiply(20, 5);
            //Assert
            Assert.That(result, Is.EqualTo(100));
        }

        [Test]
        public void Dividing_WhenDividingTwoNumbers_Returns1()
        {
            //Arrange
            double result = _calculator.Divide(20, 20);
            //Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        public void Divide_WithZerosAsInputs_ResultThrowArgumentException(double a, double b)
        {
            
            Assert.That(() => _calculator.Divide(0, 0), Throws.ArgumentException);
        }

        // Subtract Tests
        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ReturnsDifference()
        {
            // Act
            double result = _calculator.Subtract(20, 10);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Subtract_WhenSubtractingNegativeNumbers_ReturnsCorrectResult()
        {
            // Act
            double result = _calculator.Subtract(-10, -5);
            // Assert
            Assert.That(result, Is.EqualTo(-5));
        }

        [Test]
        public void Subtract_WhenSubtractingZero_ReturnsSameNumber()
        {
            // Act
            double result = _calculator.Subtract(10, 0);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }

        // Multiply Tests
        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ReturnsProduct()
        {
            // Act
            double result = _calculator.Multiply(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void Multiply_WhenMultiplyingWithZero_ReturnsZero()
        {
            // Act
            double result = _calculator.Multiply(10, 0);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Multiply_WhenMultiplyingWithNegativeNumber_ReturnsNegativeProduct()
        {
            // Act
            double result = _calculator.Multiply(-5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(-15));
        }

        // Divide Tests
        [Test]
        public void Divide_WithNonZeroNumbers_ReturnsQuotient()
        {
            // Act
            double result = _calculator.Divide(20, 5);
            // Assert
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        public void Factorial_WithZeroOrOneAsStart_ReturnsOne(double a)
        {
            Assert.That(() => _calculator.Factorial(a), Is.EqualTo(1));
        }
        [Test]
        [TestCase(-1)]
        [TestCase(-2)]
        public void Factorial_WithNegativeNo_ResultThrowArgumentException(double a)
        {
            Assert.That(() => _calculator.Factorial(a), Throws.ArgumentException);
        }
        [Test]
        [TestCase(10, 5, 25)]  
        [TestCase(6, 8, 24)]   
        [TestCase(3, 7, 10.5)] 
        public void CalTriangle_WithValidHW_ResultValid(double baseValue, double height, double expectedResult)
        {
            // Act
            double result = _calculator.CalTriangle(baseValue, height);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult).Within(0.01)); // With a tolerance of 0.01
        }

        [Test]
        [TestCase(-10, 5)]   
        [TestCase(6, -8)]    
        [TestCase(-3, -7)]
        [TestCase(3, 0)]
        [TestCase(0, 3)]
        [TestCase(0, 0)]
        public void CalTriangle_WithInvalidInputs_ThrowsArgumentException(double baseValue, double height)
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => _calculator.CalTriangle(baseValue, height));
        }


        [TestCase(5, 78.54)]   
        [TestCase(3, 28.27)]   
        [TestCase(7, 153.94)]  
        public void CalCircle_WithValidRadius_ResultValid(double radius, double expectedResult)
        {
            // Act
            double result = _calculator.CalCircle(radius);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult).Within(0.01)); 
        }

        [Test]
        [TestCase(-5)]   
        [TestCase(0)]   
        public void CalCircle_WithInvalidRadius_ThrowsArgumentException(double radius)
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => _calculator.CalCircle(radius));
        }


        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }

        [Test]
        [TestCase(5.5, 2)]
        [TestCase(5, 2.3)]  
        [TestCase(5.5, 2.3)]  
        public void UnknownFunctionA_WithDecimals_ThrowsArgumentException(double num1, double num2)
        {
            Assert.Throws<ArgumentException>(() => _calculator.UnknownFunctionA(num1, num2));
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }

        [Test]
        [TestCase(7.1, 3)]  
        [TestCase(7, 3.2)]  
        [TestCase(7.1, 3.2)]  
        public void UnknownFunctionB_WithDecimals_ThrowsArgumentException(double num1, double num2)
        {
            Assert.Throws<ArgumentException>(() => _calculator.UnknownFunctionB(num1, num2));
        }

    }
}