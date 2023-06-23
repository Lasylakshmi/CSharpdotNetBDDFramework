using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumCucumberBDDDemo.BaseClasses;
using SeleniumCucumberBDDDemo.ComponentHelper;

namespace SeleniumCucumberBDDDemo.BaseClasses
{
    public class PageBase
    {
        private IWebDriver driver;
        [FindsBy(How = How.Id, Using = "signin")]
        private IWebElement SignInButton;
        public PageBase(IWebDriver _driver)
        {
            PageFactory.InitElements(_driver, this);
            this.driver = _driver;
        }
        public void Logout()
        {
            if (GenericHelper.IsElemetPresent(By.XPath("//div[@id='header']/ul[1]/li[11]/a")))
            {
                ButtonHelper.ClickButton(By.XPath("//div[@id='header']/ul[1]/li[11]/a"));
            }
            GenericHelper.WaitForWebElementInPage(By.Id("welcome"), TimeSpan.FromSeconds(30));

        }

        

        public string Title
        {
            get { return driver.Title; }
        }
        /* public void Logout()
         {
             if (GenericHelper.IsElemetPresent(By.XPath("//div[@id='header']/ul[1]/li[11]/a")))
             {
                 ButtonHelper.ClickButton(By.XPath("//div[@id='header']/ul[1]/li[11]/a"));
             }
             GenericHelper.WaitForWebElementInPage(By.Id("welcome"), TimeSpan.FromSeconds(30));

         }*/
    }

}


