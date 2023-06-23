using OpenQA.Selenium;
using SeleniumCucumberBDDDemo.BaseClasses;
using SeleniumCucumberBDDDemo.ComponentHelper;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCucumberBDDDemo.Pages
{
    public class EnterLogins : PageBase
    {
        private IWebDriver driver;

        [FindsBy(How = How.LinkText, Using = "Testng")]
        private IWebElement Testng;
        //private IWebElement Testng => driver.FindElement(By.LinkText("Testng"));

        public EnterLogins(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

    }
}
