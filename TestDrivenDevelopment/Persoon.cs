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
            Voornaam = voornaam;
        }

        // Property
        private List<string> voornaamValue;

        public List<string> Voornaam
        {
            get { return voornaamValue; }
            set { voornaamValue = value; }
        }


        // Method
        public override string ToString()
        {
            string result = "";
            foreach (var eenVoornaam in Voornaam)
            {
                result += eenVoornaam + " ";
            }
            result.Remove(result.Length - 1);
            return result;
        }
    }
}