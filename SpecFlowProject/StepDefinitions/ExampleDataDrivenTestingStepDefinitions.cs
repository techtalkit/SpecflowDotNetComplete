using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public sealed class ExampleDataDrivenTestingStepDefinitions
    {
        private IWebDriver driver;
        public ExampleDataDrivenTestingStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Then(@"Search with (.*)")]
        public void ThenSearchWithSpecflowByTestersTalk(string searchKey)
        {
            driver.FindElement(By.XPath("//input[@id='search']")).SendKeys(searchKey);
            driver.FindElement(By.XPath("//input[@id='search']")).SendKeys(Keys.Enter);
            Thread.Sleep(5000);
        }



    }
}