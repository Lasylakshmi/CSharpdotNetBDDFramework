using SeleniumCucumberBDDDemo.Interfaces;
using OpenQA.Selenium;
using SeleniumCucumberBDDDemo.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeleniumCucumberBDDDemo.Settings
{
    public class ObjectRepository
    {
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }

        //public static HomePage hPage;
        public static LoginPage lPage;
        public static EnterLogins ePage;
    }
}
