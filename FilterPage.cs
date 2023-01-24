using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDana
{
    public class FilterPage
    {
        private IWebDriver driver;

        public FilterPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void FilterByPrice(string price) 
        {
            driver.FindElement(By.XPath("//*[@id='gh-as-a']")).Click();
            driver.FindElement(By.XPath("//*[@id='_mPrRngCbx']")).Click();
            driver.FindElement(By.XPath("//*[@name='_udlo']")).SendKeys(price);
            driver.FindElement(By.XPath("//*[@id='searchBtnLowerLnk']")).Click();
        }
    }
}

    