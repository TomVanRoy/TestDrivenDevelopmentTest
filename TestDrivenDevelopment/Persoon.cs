using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopment
{
    public class Persoon
    {
        // Constructor
        public Persoon(List<string> voornaam)
        {
            this.voornaam = voornaam;
        }

        // Property
        public List<string> voornaam { get; set; }

        // Method
        public override string ToString()
        {
            string result = "";
            foreach (var eenVoornaam in voornaam)
            {
                result += eenVoornaam + " ";
            }
            result.Remove(result.Length - 1);
            return result;
        }
    }
}