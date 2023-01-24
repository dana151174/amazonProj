using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDana
{
    public class SearchBar
    {
        private IWebDriver driver;
        private string text;
       
        public SearchBar(IWebDriver driver)
        {
            this.driver = driver;
           
        }

        public string Text
        { 
            get 
            {
                var el = driver.FindElement(By.Id("twotabsearchtextbox"));
                return el.Text;
            } 
            set 
            {
                var el = driver.FindElement(By.Id("twotabsearchtextbox"));
                el.SendKeys(value);
            } 
        }
        public void Click()
        {
            
            driver.FindElement(By.Id("nav-search-submit-button")).Click();
        }
    }
}
