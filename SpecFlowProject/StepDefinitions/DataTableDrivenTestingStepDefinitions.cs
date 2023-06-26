using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow.Assist;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public sealed class DataTableDrivenTestingStepDefinitions
    {
        private IWebDriver driver;
        public DataTableDrivenTestingStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Then(@"Enter search keyword in youtube")]
        public void ThenEnterSearchKeywordInYoutube(Table table)
        {
           var searchCriteria= table.CreateSet<SearchKeyTestData>();
            foreach (var item in searchCriteria)
            {
                driver.FindElement(By.XPath("//input[@id='search']")).Clear();
                driver.FindElement(By.XPath("//input[@id='search']")).SendKeys(item.searchKey);
                driver.FindElement(By.XPath("//input[@id='search']")).SendKeys(Keys.Enter);
                Thread.Sleep(5000);
            }
        }
    }
    public class SearchKeyTestData {
        public string searchKey { get; set; }
    }
}