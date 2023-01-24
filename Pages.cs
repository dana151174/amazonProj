﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDana
{
    public class Pages
    {
        private IWebDriver driver;
        public Home home;
        public Results reslts;


        public Pages(IWebDriver driver)
        {
            this.driver = driver;
        }

        public Home Home 
        { 
            get 
            { 
                if(this.Home == null) 
                { 
                    this.home = new Home(driver);
                }
                return this.home; 
            } 
        }

        public Results Reslts 
        { 
            get 
            { 
                if(this.Reslts== null) 
                { 
                    this.reslts = new Results(driver);
                }
                return this.reslts;
            }
        }
    }
}
