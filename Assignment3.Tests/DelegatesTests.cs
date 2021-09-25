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
            Func<string, string> reverse = (s) => new string(s.Reverse().ToArray());
            var actual = reverse(input);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
