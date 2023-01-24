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
    public class UnitTest2
    {
        IWebDriver driver;
        SearchPage searchPage;
        FilterPage filterPage;

        [SetUp]
        public void Setup()
        {
            BrowserFactory browserFactory = new BrowserFactory();
            browserFactory.InitBrowser("Chrome");
            browserFactory.LoadApplication("https://www.ebay.com/");
            driver = BrowserFactory.Driver; 
            searchPage = new SearchPage(driver);
            filterPage = new FilterPage(driver);
        }

        [Test]
        public void SearchForMouse ()
        {
            driver.Navigate().GoToUrl("https://www.ebay.com/");
            searchPage.Search("mouse");
            filterPage.FilterByPrice("50");   
        }

        [TearDown]
        public void closeBrowser()
        {
            // driver.Close();
        }
    }
}

