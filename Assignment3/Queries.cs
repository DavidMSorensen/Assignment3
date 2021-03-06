using System.Linq;
using System;
using System.Collections.Generic;

namespace BDSA2020.Assignment02
{
    public class Queries
    {
        public static IEnumerable<string> GetWizardsByRowling(){
            var repo = Wizard.Wizards.Value;

            var gr = from c in repo
                     where c.Creator.Contains("Rowling")
                     select c.Name;
            
            return gr;
        }

        public static IEnumerable<string> GetWizardsByRowlingLinq(){
            var repo = Wizard.Wizards.Value;

            var gr = repo
                     .Where(c => c.Creator.Contains("Rowling"))
                     .Select(c => c.Name);

            return gr;
        }

        public static int? YearOfTheFirstSithLord(){
            var repo = Wizard.Wizards.Value;

            var gr = from c in repo
                     where c.Name.Contains("Darth")
                     orderby c.Year ascending
                     select c.Year;

            return gr.ElementAt(0);
        }

        public static int? YearOfTheFirstSithLordLinq(){
            var repo = Wizard.Wizards.Value;

            var gr = repo
                     .Where(c => c.Name.Contains("Darth"))
                     .OrderBy(c => c.Year)
                     .Select(c => c.Year);

            return gr.ElementAt(0);
        }

        public static IEnumerable<(string, int?)> HarryPotterWizards(){
            var repo = Wizard.Wizards.Value;

            var gr = from c in repo
                     where c.Medium.Contains("Harry Potter")
                     select (c.Name, c.Year);

            return gr;
        }

        public static IEnumerable<(string, int?)> HarryPotterWizardsLinq(){
            var repo = Wizard.Wizards.Value;

            var gr = repo
                     .Where(c => c.Medium.Contains("Harry Potter"))
                     .Select(c => (c.Name, c.Year));

            return gr;
        }

        public static IEnumerable<string> ListWizardsInReverseOrder(){
            var repo = Wizard.Wizards.Value;

            var gr = from c in repo
                     orderby c.Creator descending, c.Name descending
                     select c.Name;

            return gr;
        }

        public static IEnumerable<string> ListWizardsInReverseOrderLinq(){
            var repo = Wizard.Wizards.Value;

            var gr = repo
                     .OrderByDescending(c => (c.Creator, c.Name))
                     .Select(c => c.Name);

            return gr;
        }
    }
}
