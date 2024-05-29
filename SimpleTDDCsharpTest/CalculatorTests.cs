using Calculator;

namespace SimpleTDDCsharpTest
{
    public class CalculatorTests
    {
        [Fact]
        public void Addition_Return_Value_Matched_Expected_Result()
        {
            //Arrange
            int a=10, b=20;
            int expectedAdditionResult = a + b;
            Calc calc = new Calc();
            Calc.MathOperation additionOperation = calc.Addition;
            //Act
            int actualAdditionResult = calc.ExecuteOperation(additionOperation,a,b);
            //Assert
            actualAdditionResult.Should().Be(expectedAdditionResult);
        }

        [Theory]
        [AutoData]
        public void Addition_Return_Value_Matched_Expected_Result_AutoData(int a,int b)
        {
            //Arrange
            int expectedAdditionResult =a+b;
            Calc calc = new Calc();
            Calc.MathOperation additionOperation = calc.Addition;
            //Act
            int actualAdditionResult = calc.ExecuteOperation(additionOperation,a,b);
            //Assert
            actualAdditionResult.Should().Be(expectedAdditionResult);
        }

        [Theory]
        [AutoData]
        public void Subtraction_Return_Value_Matched_ExpectedSubtraction_Result(int a, int b)
        {
            //Arrange
            int expectedSubtractionResult = a - b;
            Calc calc = new Calc();
            Calc.MathOperation subtractionOperation = calc.Subtraction;
            //Act
            int actualSubtractionResult=calc.ExecuteOperation(subtractionOperation, a,b);
            //Assert
            actualSubtractionResult.Should().Be(expectedSubtractionResult);
        }

        [Theory]
        [AutoData]
        public void Multiplication_Return_Value_Matched_ExpectedMultiplication_Result(int a, int b)
        {
            //Arrange
            int expectedMultiplicationResult = a * b;
            Calc calc = new Calc();
            Calc.MathOperation multiplicationOperation = calc.Multiplication;
            //Act
            int actualMultiplicationResult = calc.ExecuteOperation(multiplicationOperation, a,b);
            //Assert
            actualMultiplicationResult.Should().Be(expectedMultiplicationResult);
        }

        [Theory]
        [AutoData]
        public void Division_Return_Value_Matched_ExpectedDivision_Result(int a, int b)
        {
            //Arrange
            int expectedDivisionResult = a / b;
            Calc calc = new Calc();
            Calc.MathOperation divideOperation = calc.Division;
            //Act
            int actualDivisionResult = calc.ExecuteOperation(divideOperation, a,b);
            //Assert
            actualDivisionResult.Should().Be(expectedDivisionResult);
        }

        [Fact]
        public void Division_By_Zero_Should_Throw_Exception()
        {
            // Arrange
            int a = 10, b = 0;
            Calc calc = new Calc();
            //Act
            Action actualDivisionByZeroResult= () => calc.Division(a, b);
            //Assert
            actualDivisionByZeroResult.Should().Throw<DivideByZeroException>();
        }
    }
}