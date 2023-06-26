﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.Pages
{
    public class SearchPage
    {
        private IWebDriver driver;
        public SearchPage(IWebDriver driver) {
            this.driver = driver; 
        }
        By searchTextbox = By.XPath("//input[@id='search']");
        public ResultPage searchText(string text)
        {
            driver.FindElement(searchTextbox).SendKeys(text);
            driver.FindElement(searchTextbox).SendKeys(Keys.Enter);
            return new ResultPage(driver);
        }
    }
}
