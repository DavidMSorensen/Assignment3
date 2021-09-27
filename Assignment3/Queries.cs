using System.Linq;
using System;
using System.Collections.Generic;

namespace BDSA2020.Assignment02
{
    public class Queries
    {
        public static IEnumerable<string> PrintRowling(){
            var repo = Wizard.Wizards.Value;

            var gr = from c in repo
                     where c.Creator.Contains("Rowling")
                     select c.Name;
            
            return gr;
        }

        public static IEnumerable<string> PrintRowlingLinq(){
            var repo = Wizard.Wizards.Value;

            var gr = repo
                     .Where(c => c.Creator.Contains("Rowling"))
                     .Select(c => c.Name);

            return gr;
        }

        public static int yearOfTheFirstSithLord(){
            throw new NotImplementedException();
        }

        public static IEnumerable<(string, int)> HarryPotterWizards(){
            throw new NotImplementedException();
        }
    }
}
