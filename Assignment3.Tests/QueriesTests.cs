using System;
using System.Collections.Generic;
using Xunit;

namespace BDSA2020.Assignment02.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void printRowlig_returns_names_of_wizards_made_by_Rowling()
        {
            //Arrange
            string[] actual;
            string[] expected = {"Harry Potter", "Hermione Granger", "Gandalf", "Ronald Weasley", "Voldemort"};


            //Act
            actual = Queries.printRowling();


            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void yearOfTheFirstSithLord_returns_1977()
        {
            //Arrange
            int actual;
            int expected = 1977;


            //Act
            actual = Queries.yearOfTheFirstSithLord();


            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestName()
        {
            //Arrange
            List<(string, int)> actual;
            var expected = new List<(string, int)>();
            expected.Add(("Harry Potter", 1997));
            expected.Add(("Hermione Granger", 2003));
            expected.Add(("Ronald Weasley", 1997));
            expected.Add(("Voldemort", 1999));

            //Act
            actual = (List<(string, int)>) Queries.HarryPotterWizards();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
