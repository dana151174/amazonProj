using OnlineStore.WrapperFactory;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDana
{
    public class EbayAutoTest 
    {
        private IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            BrowserFactory browserFactory = new BrowserFactory();
            browserFactory.InitBrowser("Chrome");
            browserFactory.LoadApplication("https://www.ebay.com/");
            driver = BrowserFactory.Driver;      
        }

        [Test]
        public void Test1()
        {
            driver.Url = "https://www.ebay.com/";
            var SearchBar = driver.FindElement(By.Id("gh-ac"));
            SearchBar.SendKeys("mouse");
            var SearchButton = driver.FindElement(By.Id("gh-btn"));
            SearchButton.Click();
            var advance = driver.FindElement(By.XPath("//*[@id='gh-as-a']"));
            advance.Click();
            var check = driver.FindElement(By.XPath("//*[@id='_mPrRngCbx']"));
            check.Click();
            var price = driver.FindElement(By.XPath("//*[@name='_udlo']"));
            price.SendKeys("50");
            var search = driver.FindElement(By.XPath("//*[@id='searchBtnLowerLnk']"));
            search.Click();
        }

        [TearDown]
        public void closeBrowser()
        {
            // driver.Close();
        }
    }
}
