using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace rabotavdodo.specs
{
    [Binding]
    public class CityInListSteps
    {
        private Form form = new Form();
        private string result;

        [Given(@"I have entered (.*) into the CityField")]
        public void GivenIHaveEnteredCityIntoTheForm(string city)
        {
            form.City = city;
        }
        
        [When(@"I press getCity")]
        public void WhenIPressGetCity()
        {
            result = form.GetCityFromList();
        }
        
        [Then(@"the City should be (.*) on the screen")]
        public void ThenTheCityShouldBeTrueOnTheScreen(string city)
        {
            Assert.AreEqual(result, city);
        }
    }
}
