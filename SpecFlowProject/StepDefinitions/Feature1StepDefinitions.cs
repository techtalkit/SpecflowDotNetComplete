using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public sealed class Feature1StepDefinitions
    {
        private IWebDriver driver;
        public Feature1StepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }
        
        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
            //new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = "https://www.youtube.com/";
            Thread.Sleep(5000);
        }

        [Then(@"Search for the Tester Talk")]
        public void ThenSearchForTheTesterTalk()
        {
            driver.FindElement(By.XPath("//input[@id='search1']")).SendKeys("Testers Talk");
            driver.FindElement(By.XPath("//input[@id='search']")).SendKeys(Keys.Enter);
            Thread.Sleep(5000);
            //driver.Quit();
        }

    }
}