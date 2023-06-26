using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public sealed class DataDrivenTestingStepDefinitions
    {
        private IWebDriver driver;
        public DataDrivenTestingStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Then(@"Search for '([^']*)'")]
        public void ThenSearchFor(string searchKey)
        {
            driver.FindElement(By.XPath("//input[@id='search']")).SendKeys(searchKey);
            driver.FindElement(By.XPath("//input[@id='search']")).SendKeys(Keys.Enter);
            Thread.Sleep(5000);
        }


    }
}