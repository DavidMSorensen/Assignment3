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
            var expected = new List<int> {1,2,3,4,5,6,7,8,9};
            var list1 = new List<int>() {1,2,3};
            var list2 = new List<int>() {4,5,6};
            var list3 = new List<int>() {7,8,9};
            var list = new List<int>[] {list1, list2, list3};

            var actual = list.Flatten();

            Assert.Equal(expected, actual);   
        }
    }
}
