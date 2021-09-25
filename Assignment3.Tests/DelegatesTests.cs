using System;
using System.Linq;
using Xunit;

namespace BDSA2020.Assignment02.Tests
{
    public class DelegatesTests
    {
        [Fact]
        public void ReverseString_takes_abcdef_returns_fedcba()
        {
            //Arrange
            var expected = "fedcba";
            var input = "abcdef";

            //Act
            //Func<string, string> Reverse = (s) => new string(s.Reverse().ToArray());
            Func<string, string> Reverse = delegate (string s) { return new string(s.Reverse().ToArray()); }; 
            var actual = Reverse(input);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Multiply_take_two_decimals_return_product()
        {
            //Arrange
            var expected = 8;

            //Act
            //Func<int, int, int> Multiply = (a, b) => a * b;
            Func<int, int, int> Multiply = delegate (int a, int b) {return a * b; };
            var actual = Multiply(2, 4);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NumericCheck_given_0042_and_42_return_true()
        {
            //Arrange
            var inputString = "0042";
            var inputInt = 42;
            
            //Act
            //Func<string, int, bool> NumericCheck = (s, i) => int.Parse(s) == i;
            Func<string, int, bool> NumericCheck = delegate (string s, int i) {return int.Parse(s) == i; };
            var actual = NumericCheck(inputString, inputInt);

            //Assert
            Assert.True(actual);
        }
    }
}
