using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OnlineStore.WrapperFactory;

namespace TestDana
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]

        public void startBrowser()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximizes");
            driver = new ChromeDriver("C:\\Users\\User\\Desktop\\Drivers");  
            
        }

        [Test]
        public void Test1()
        {
            driver.Url = "https://www.ebay.com/";
            var SearchBar = driver.FindElement(By.Id("gh-ac"));
            SearchBar.SendKeys("mouse");
            var SearchButton = driver.FindElement(By.Id("gh-btn"));
            SearchButton.Click();
            var items = driver.FindElements(By.XPath("//*[@class='s-item__link']"));
            //var advance = driver.FindElement(By.XPath("//*[@id='gh-as-a']"));
            //advance.Click();
            //var check = driver.FindElement(By.XPath("//*[@id='_mPrRngCbx']"));
            //check.Click();
            //var price = driver.FindElement(By.XPath("//*[@name='_udlo']"));
            //price.SendKeys("50");
            //var search = driver.FindElement(By.XPath("//*[@id='searchBtnLowerLnk']"));
            //search.Click();


            //var resultDiv = driver.FindElement(By.Id("srp-river-results"));
            //var element = resultDiv.FindElement(By.XPath("//li"));

            //Assert.Pass();
            //  Assert.IsTrue(items.Count > 0);

            for (int i = 1; i < 4; i++)
            {
                items[i].Click();
            }
        }

        [TearDown]
        public void closeBrowser()
        {
           // driver.Close();
        }
    }
}