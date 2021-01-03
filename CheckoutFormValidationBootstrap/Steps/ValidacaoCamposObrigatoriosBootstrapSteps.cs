using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace XUnitTestProject1.Steps
{
    [Binding]
    public class ValidacaoCamposObrigatoriosBootstrapSteps
    {

        private readonly IWebDriver _webDriver;

        public ValidacaoCamposObrigatoriosBootstrapSteps(ScenarioContext scenarioContext)
        {
            _webDriver = scenarioContext["WEB_DRIVER"] as IWebDriver;
        }

        [When]
        public void WhenClicoNoBotaoContinueToCheckout()
        {
            var element = _webDriver.FindElement(By.XPath("//button[contains(text(),'Continue to checkout')]"));
            Actions actions = new Actions(_webDriver);
            actions.MoveToElement(element);
            actions.Perform();
            element.Click();
        }

        [Then(@"a validacao do campo First name deve ser ""(.*)""")]
        public void ThenAValidacaoDoCampoFirstNameDeveSer_P0(string msg)
        {
            string firstNameRequired = _webDriver.FindElement(By.XPath("//div[contains(text(),'Valid first name is required.')]")).Text;
            Assert.Equal(msg, firstNameRequired);
        }

        [Then(@"a validacao do campo Last name deve ser ""(.*)""")]
        public void ThenAValidacaoDoCampoLastNameDeveSer_P0(string msg)
        {
            string lastnameRequired = _webDriver.FindElement(By.XPath("//div[contains(text(),'Valid last name is required.')]")).Text;
            Assert.Equal(msg, lastnameRequired);
        }

        [Then(@"a validacao do campo Username deve ser ""(.*)""")]
        public void ThenAValidacaoDoCampoUsernameDeveSer_P0(string msg)
        {
            string usernameRequired = _webDriver.FindElement(By.XPath("//div[contains(text(),'Your username is required.')]")).Text;
            Assert.Equal(msg, usernameRequired);
        }

        [Then(@"a validacao do campo Address deve ser ""(.*)""")]
        public void ThenAValidacaoDoCampoAddressDeveSer_P0(string msg)
        {
            string addressRequired = _webDriver.FindElement(By.XPath("//div[contains(text(),'Please enter your shipping address.')]")).Text;
            Assert.Equal(msg, addressRequired);
        }

        [Then(@"a validacao do campo Country deve ser ""(.*)""")]
        public void ThenAValidacaoDoCampoCountryDeveSer_P0(string msg)
        {
            string countryRequired = _webDriver.FindElement(By.XPath("//div[contains(text(),'Please select a valid country.')]")).Text;
            Assert.Equal(msg, countryRequired);
        }

        [Then(@"a validacao do campo State deve ser ""(.*)""")]
        public void ThenAValidacaoDoCampoStateDeveSer_P0(string msg)
        {
            string stateRequired = _webDriver.FindElement(By.XPath("//div[contains(text(),'Please provide a valid state.')]")).Text;
            Assert.Equal(msg, stateRequired);
        }

        [Then(@"a validacao do campo Zip deve ser ""(.*)""")]
        public void ThenAValidacaoDoCampoZipDeveSer_P0(string msg)
        {
            string zipRequired = _webDriver.FindElement(By.XPath("//div[contains(text(),'Zip code required.')]")).Text;
            Assert.Equal(msg, zipRequired);
        }

        [Then(@"a validacao do campo Name on card deve ser ""(.*)""")]
        public void ThenAValidacaoDoCampoNameOnCardDeveSer_P0(string msg)
        {
            string nameOnCardRequired = _webDriver.FindElement(By.XPath("//div[contains(text(),'Name on card is required')]")).Text;
            Assert.Equal(msg, nameOnCardRequired);
        }

        [Then(@"a validacao do campo Credit card number deve ser ""(.*)""")]
        public void ThenAValidacaoDoCampoCreditCardNumberDeveSer_P0(string msg)
        {
            string creditCardNumberRequired = _webDriver.FindElement(By.XPath("//div[contains(text(),'Credit card number is required')]")).Text;
            Assert.Equal(msg, creditCardNumberRequired);
        }

        [Then(@"a validacao do campo Expiration deve ser ""(.*)""")]
        public void ThenAValidacaoDoCampoExpirationDeveSer_P0(string msg)
        {
            string expirationRequired = _webDriver.FindElement(By.XPath("//div[contains(text(),'Expiration date required')]")).Text;
            Assert.Equal(msg, expirationRequired);
        }

        [Then(@"a validacao do campo CVV deve ser ""(.*)""")]
        public void ThenAValidacaoDoCampoCVVDeveSer_P0(string msg)
        {
            string cvvRequired = _webDriver.FindElement(By.XPath("//div[contains(text(),'Security code required')]")).Text;
            Assert.Equal(msg, cvvRequired);
        }
    }
}
