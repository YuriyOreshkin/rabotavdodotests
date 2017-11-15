using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace rabotavdodo.specs
{
    [Binding]
    public class FormSteps
    {
        private Form form = new Form();
        private bool result;

        [Given(@"I have entered (.*),(.*),(.*),(.*) into the Form")]
        public void GivenIHaveEnteredIntoTheForm(string firstName,string secondName,string city,string birthDay)
        {
            form.FirstName = firstName;
            form.SecondName = secondName;
            form.City = city;
            DateTime birthDayAsDate;
            form.BirthDay =DateTime.TryParse(birthDay, out birthDayAsDate) ? birthDayAsDate: DateTime.MinValue ;
        }
        
        
        [When(@"I press submit")]
        public void WhenIPressSubmit()
        {
            result = form.Submit();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(bool submitResult)
        {
            Assert.AreEqual(result, submitResult);
        }
    }
}
