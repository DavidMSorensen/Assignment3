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
            //Func<string, string> reverse = (s) => new string(s.Reverse().ToArray());
            Func<string, string> reverse = delegate (string s) { return new string(s.Reverse().ToArray()); }; 
            var actual = reverse(input);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Multiply_take_two_decimals_return_product()
        {
            //Arrange
            var expected = 8;

            //Act
            //Func<int, int, int> multiply = (a, b) => a * b;
            Func<int, int, int> multiply = delegate (int a, int b) {return a * b; };
            var actual = multiply(2, 4);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
