using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProject.Pages;


namespace SpecFlowProject.StepDefinitions
{
    
        [Binding]
        public sealed class PageObjectModelStepDefinitions
        {
            private IWebDriver driver;
            SearchPage searchPage;
            ResultPage resultPage;
            ChannelPage channelPage;
            public PageObjectModelStepDefinitions(IWebDriver driver)
            {
                this.driver = driver;
            }
        [Given(@"Enter the youtube url")]
        public void GivenEnterTheYoutubeUrl()
        {
            driver.Url = "https://www.youtube.com/";
            Thread.Sleep(4000);
        }

        [When(@"Search for the testers talk in youtube")]
        public void WhenSearchForTheTestersTalkInYoutube()
        {
            searchPage = new SearchPage(driver);
            resultPage=searchPage.searchText("testers talk");
            Thread.Sleep(3000);
        }

        [When(@"Navigate to the Channel")]
        public void WhenNavigateToTheChannel()
        {
            channelPage=resultPage.clickonChannel();
            Thread.Sleep(3000);
        }

        [Then(@"Verify the title of the webpage")]
        public void ThenVerifyTheTitleOfTheWebpage()
        {
            Assert.AreEqual("Testers Talk - Youtube", channelPage.getTitle());
            Thread.Sleep(3000);
        }


    }


}