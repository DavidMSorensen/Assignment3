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
        public void FilterBy7and42_given_list_7_19_35_42_49_54_67_70_71_returns_49_70()
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
        public void FilterLeapYears_returns_leapyear()
        {
            //Arrange
            int[] expected = {1784, 1864};
            int[] list = {1601, 1962, 2065, 1784, 1829, 1864, 2121, 2021, 2018};
            
            //Act
            var actual = list.FilterLeapYears();

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

        [Fact]
        public void WordCount_returns_number_of_letters_from_string()
        {
        //Arrange
        var expected = 9;
        var _string = "hallo! :(det der 69 er ikke       sjovt 420 mig og dig";

        //Act
        var actual = _string.WordCount();
        
        //Assert
        Assert.Equal(expected, actual);
        }
    }
}
