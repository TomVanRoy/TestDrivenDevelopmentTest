using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TestDrivenDevelopment
{
    public class Persoon
    {
        // Constructor
        public Persoon(List<string> voornaam)
        {
            if (voornaam == null)
            {
                throw new ArgumentNullException();
            }
            if (voornaam.Contains("") || voornaam.Count == 0)
            {
                throw new ArgumentException();
            }

            Regex reg = new Regex("[A-Za-z]");
            foreach (var eenVoornaam in voornaam)
            {
                foreach (var letter in eenVoornaam)
                {
                    if (!reg.IsMatch(letter.ToString()))
                    {
                        throw new ArgumentException("Een naam kan alleen maar letters bevatten");
                    }
                }

            }

            foreach (var eenVoornaam in voornaam)
            {
                int amount = 0;
                foreach (var duplicaatVoornaam in voornaam)
                {
                    if (eenVoornaam == duplicaatVoornaam)
                    {
                        amount++;
                        if (amount > 1)
                        {
                            throw new ArgumentException("Elke naam mag maar 1 keer voorkomen");
                        }
                    }
                }

            }
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
            result = result.Remove(result.LastIndexOf(" "));
            return result;
        }
    }
}