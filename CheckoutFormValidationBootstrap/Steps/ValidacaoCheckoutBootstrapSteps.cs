using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace XUnitTestProject1.Steps
{
    [Binding]
    public class ValidacaoCheckoutBootstrapSteps
    {
        private readonly IWebDriver _webDriver;

        public ValidacaoCheckoutBootstrapSteps(ScenarioContext scenarioContext)
        {
            _webDriver = scenarioContext["WEB_DRIVER"] as IWebDriver;
        }

        [Given]
        public void GivenEuAcessoAPagina_P0(string homepage)
        {
            _webDriver.Url = $"{homepage}";
        }

        [Then]
        public void ThenOTituloDaPaginaDeveSer_P0(string title)
        {
            Assert.Equal(title, _webDriver.Title);
        }
    }
}

