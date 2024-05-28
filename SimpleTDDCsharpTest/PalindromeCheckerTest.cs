

using Xunit;
using FluentAssertions;
using Calculator;

namespace SimpleTDDCsharpTest
{
   
    public class PalindromeCheckerTest
    {
        [Fact]
        public void String_Palindrone_Checker_Result_ShouldBe_True()
        {
        //Arrange
        string name = "aba";
        //Act
        PalindromeChecker checker = new PalindromeChecker();
        bool result = checker.IsPalindrone(name);
        //Assert
        result.Should().BeTrue();
        }

        [Fact]
        public void String_Palindrone_Checker_Result_ShouldBe_False()
        {
            //Arrange
            string name = "abc";
            //Act
            PalindromeChecker checker = new PalindromeChecker();
            bool result = checker.IsPalindrone(name);
            //Assert
            result.Should().BeFalse();
        }
    }
}
