using System;
using System.Collections.Generic;
using Xunit;

namespace BDSA2020.Assignment02.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void GetRowling_returns_names_of_wizards_made_by_Rowling()
        {
            //Arrange
            string[] expected = {"Harry Potter", "Hermione Granger", "Ronald Weasley", "Voldemort"};


            //Act
            var actual = Queries.GetWizardsByRowling();


            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YearOfTheFirstSithLord_returns_1977()
        {
            //Arrange
            var expected = 1977;

            //Act
            var actual = Queries.YearOfTheFirstSithLord();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestName()
        {
            //Arrange
            var expected = new List<(string, int?)>();
            expected.Add(("Harry Potter", 1997));
            expected.Add(("Hermione Granger", 2003));
            expected.Add(("Ronald Weasley", 1997));
            expected.Add(("Voldemort", 1999));

            //Act
            var actual = Queries.HarryPotterWizards();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
