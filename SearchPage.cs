using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDana
{
    public class SearchPage
    {
        private IWebDriver driver;

        public SearchPage(IWebDriver driver) 
        {
            this.driver = driver;
        }

        public void Search(string itemName) 
        {
            driver.FindElement(By.Id("gh-ac")).SendKeys(itemName);
            driver.FindElement(By.Id("gh-btn")).Click();
        }
    }
}
