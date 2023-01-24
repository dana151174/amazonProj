using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDana
{
    public class Results
    {
        private IWebDriver driver;
        private IList<IWebElement> items;
        //private Dictionary<string, string> option;
        private SearchBar amazonSearchBar;

        public Results(IWebDriver driver) 
        {
            this.driver= driver;
            this.amazonSearchBar = new SearchBar(driver);
            //options["price lower then"] = "60";
            //options["free shipping"] = "true";
            //options["price higher or eauals"] = "50";
        }

        //public List<Item> getResultsBy(Dictionary<String, String> dict)
        //{
        //    foreach(KeyValuePair<String, String> filter in dict)
        //    {
        //        String xpath = "//span[@class='a-price'";
        //        switch (filter.Key)
        //        {

        //        }
        //        switch (filter.Value)
        //        {

        //        }
        //    }
        //    amazonSearchBar.Search("mouse");
        //    String price1 = "//span[@class='a-price'";
        //    String s = "//span[@class='a-price' and number(substring(.,2,5))>30]";

        //    IList <IWebElement> elements = driver.FindElements(By.XPath("//span[@class='a-price' and number(substring(.,2,5))>30]"));
        //    foreach (IWebElement e in elements)
        //    {
        //        System.Console.WriteLine(e.Text);
        //    }
        //}
    }
}
