using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopment;
using System.Collections.Generic;

namespace TestDrivenDevelopmentTest
{
    [TestClass]
    public class PersoonTest
    {
        [TestMethod]
        public void PersoonIsCorrect()
        {
            new Persoon(new List<string> { "Gert", "Pieter", "Jan" });
        }
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void PersoonZonderNaamIsVerkeerd()
        {
            new Persoon(null);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void LegeNaamListIsVerkeerd()
        {
            new Persoon(new List<string> { });
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void LegestringInNaamListIsVerkeerd()
        {
            new Persoon(new List<string> { string.Empty });
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void PersoonHeeftNietTweeMaalDezelfdeVoornaam()
        {
            new Persoon(new List<string> { "Pieter", "Karel", "Pieter" });
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void ElkeVoornaamHeeftMinstensEenTeken()
        {
            new Persoon(new List<string> { "Pieter", "", "Karel" });
        }
        [TestMethod]
        public void ToStringGeeftAlleVoornamenGescheidenMetSpaties()
        {
            Persoon persoon = new Persoon(new List<string> { "Gert", "Pieter", "Jan" });
            string result = "Gert Pieter Jan";
            Assert.AreEqual(result, persoon.ToString());
        }
    }
}
