using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopment;
using System.Text.RegularExpressions;

namespace TestDrivenDevelopmentTest
{
    [TestClass]
    public class PersoonTest
    {
        private Persoon persoon;
        [TestInitialize]
        public void Initialize()
        {
            persoon = new Persoon(new System.Collections.Generic.List<string> { "Gert", "Pieter", "Jan" });
        }
        [TestMethod]
        public void PersoonHeeftMinstensEenVoornaam()
        {
            Assert.IsTrue(persoon.Voornaam.Count > 0 && persoon.Voornaam != null);
        }

        [TestMethod]
        public void PersoonHeeftNietTweeKeerDezelfdeVoornaam()
        {
            foreach (var eenVoornaam in persoon.Voornaam)
            {
                int amount = 0;
                foreach (var duplicaatVoornaam in persoon.Voornaam)
                {
                    if (eenVoornaam == duplicaatVoornaam)
                    {
                        amount++;
                    }
                }
                Assert.IsTrue(amount == 1);
            }
        }

        [TestMethod]
        public void ElkeVoornaamHeeftMinstensEenTeken()
        {
            Regex reg = new Regex("\\w+?");
            foreach (var eenVoornaam in persoon.Voornaam)
            {
                Assert.IsTrue(reg.IsMatch(eenVoornaam));
            }
        }

        [TestMethod]
        public void ToStringGeeftAlleVoornamenGescheidenMetSpaties()
        {
            string result = "";
            foreach (var eenVoornaam in persoon.Voornaam)
            {
                result += eenVoornaam + " ";
            }
            result.Remove(result.LastIndexOf(" "));
            Assert.AreEqual(persoon.ToString(), result);
        }
    }
}
