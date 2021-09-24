using System;
using System.Collections.Generic;
using Xunit;

namespace BDSA2020.Assignment02.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public void flatten_given_List_123_456_789_return_123456789()
        {   
            //Arrange
            var expected = new List<int> {1,2,3,4,5,6,7,8,9};
            var list1 = new List<int>() {1,2,3};
            var list2 = new List<int>() {4,5,6};
            var list3 = new List<int>() {7,8,9};
            var list = new List<int>[] {list1, list2, list3};

            //Act
            var actual = list.Flatten();

            //Assert
            Assert.Equal(expected, actual);   
        }

        [Fact]
        public void TestName()
        {
            //Arrange
            int[] expected = {49, 70};
            int[] list = {7, 19, 35, 42, 49, 54, 67, 70, 71};
            
            //Act
            var actual = list.FilterBy7and42();

            //Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void IsSecure_returns_true()
        {
        //Arrange
        var url = new Uri("https://docs.microsoft.com/");
        //Act
        var isTrue = url.IsSecure();
        //Assert
        Assert.True(isTrue);
        }
        
        [Fact]
        public void IsSecure_returns_false()
        {
        //Arrange
        var url = new Uri("http://docs.microsoft.com/");
        //Act
        var isFalse = url.IsSecure();
        //Assert
        Assert.False(isFalse);
        }
    }
}
