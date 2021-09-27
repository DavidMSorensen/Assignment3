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
    }
}
