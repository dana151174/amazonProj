using OnlineStore.WrapperFactory;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDana
{
    public class AmazonAutoTest
    {
        IWebDriver driver;
        Amazon amazon;

        [SetUp]
        public void Setup()
        {
            BrowserFactory browserFactory = new BrowserFactory();
            browserFactory.InitBrowser("Chrome");
            browserFactory.LoadApplication("https://www.amazon.com/");
            driver = BrowserFactory.Driver;
            //amazon = new Amazon(driver);
            //pages = new Pages(driver);
            //home = new Home(driver);
            //amazonSearchBar = new AmazonSearchBar(driver);
            amazon = new Amazon(driver);
        }

        [Test]
        public void SearchForMouse()
        {
            driver.Navigate().GoToUrl("https://www.amazon.com/");
            amazon.Pages.Home.SearchBar.Text = "mouse";
            amazon.Pages.Home.SearchBar.Click();
        }

        [TearDown]
        public void closeBrowser()
        {
            // driver.Close();
        }
    }
}
