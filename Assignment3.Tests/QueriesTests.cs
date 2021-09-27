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
        public void HarryPotterWizards_returns_tuples_of_name_and_year_of_wizards_from_Harrpy_Potter_books()
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

        [Fact]
        public void ListWizardsInReverseOrder_returns_wizards_in_reverse_order()
        {
            //Arrange
             string[] expected = {
                "Mickey Mouse", 
                "Neo", 
                "Stephen Strange", 
                "The Wizard of Oz",
                "Sauron","Gandalf",
                "Voldemort", "Ronald Weasley", "Hermione Granger", "Harry Potter",
                "Yoda", "Darth Vader", "Darth Maul", "Darth Plagueis The Wise"};

            //Act
            var actual = Queries.ListWizardsInReverseOrder();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
