using AutoFixture.Xunit2;
using Calculator;
using FluentAssertions;

namespace SimpleTDDCsharpTest
{
    public class CalcTests
    {
        [Fact]
        public void Sum_Return_Value_Matched_Expected_Result()
        {
            //Arrange
            int a=10, b=20;
            int expectedResult = a + b;
            //Act
            Calc calc=new Calc();
            int actualResult = calc.Sum(a, b);

            //Assert
            actualResult.Should().Be(expectedResult);
            
        }

        [Theory]
        [AutoData]
        public void Sum_Return_Value_Matched_Expected_Result_AutoData(int a,int b)
        {
            //Arrange
            
            int expectedResult =a+b;
            //Act
            Calc calc = new Calc();
            int actualResult = calc.Sum(a, b);

            //Assert
            
            actualResult.Should().Be(expectedResult);
        }

        [Theory]
        [AutoData]
        public void Substraction_Return_Value_Matched_ExpectedSub_Result(int a, int b)
        {
            //Arrange
            
            int expectedSubResult = a - b;
            //Act
            Calc calc = new Calc();
            int actualSubResult=calc.Sub(a,b);

            //Assert
            actualSubResult.Should().Be(expectedSubResult);

        }
        [Theory]
        [AutoData]
        public void Mul_Return_Value_Matched_ExpectedMul_Result(int a, int b)
        {
            //Arrange

            int expectedSubResult = a * b;
            //Act
            Calc calc = new Calc();
            int actualMulResult = calc.Mul(a, b);

            //Assert
            actualMulResult.Should().Be(expectedSubResult);

        }

        [Theory]
        [AutoData]
        public void Division_Return_Value_Matched_ExpectedDiv_Result(int a, int b)
        {
            //Arrange

            int expectedSubResult = a / b;
            //Act
            Calc calc = new Calc();
            int actualMulResult = calc.Div(a, b);

            //Assert
            actualMulResult.Should().Be(expectedSubResult);

        }

        [Fact]
        public void Division_By_Zero_Should_Throw_Exception()
        {
            // Arrange
            int a = 10;
            int b = 0;
            Calc calc = new Calc();
            Action actualMulResult= () => calc.Div(a, b);
            // Act & Assert
            actualMulResult.Should().Throw<DivideByZeroException>();
        }
    }

    //public static class Calc
    //{
    //    public static int Sum(int a,int b)
    //    {
    //        return a + b;
    //    }

    //}
}