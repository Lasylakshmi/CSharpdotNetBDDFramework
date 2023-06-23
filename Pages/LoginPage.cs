using OpenQA.Selenium;
using SeleniumCucumberBDDDemo.BaseClasses;
using SeleniumCucumberBDDDemo.ComponentHelper;
using SeleniumCucumberBDDDemo.Settings;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCucumberBDDDemo.Pages
{
    public class LoginPage : PageBase
    {
       // private IWebDriver driver;
        [FindsBy(How = How.Id, Using = "Bugzilla_login")]
        private IWebElement LoginTextBox;
        //private IWebElement LoginTextBox => driver.FindElement(By.Id("Bugzilla_login"));

        [FindsBy(How = How.Id, Using = "Bugzilla_password")]
        private IWebElement PassTextBox;
        //private IWebElement PassTextBox => driver.FindElement(By.Id("Bugzilla_password"));

        [FindsBy(How = How.Id, Using = "log_in")]
        [CacheLookup]
        private IWebElement LoginButton;
        //private IWebElement LoginButton => driver.FindElement(By.Id ("log_in"));

        [FindsBy(How = How.Id, Using = "signin")]
        private IWebElement SignInButton;
        //private IWebElement HomeLink => driver.FindElement(By.LinkText("Home"));

        public LoginPage(IWebDriver _driver) : base(_driver)
        {
            ObjectRepository.Driver = _driver;

        }

        public EnterLogins Login(string usename, string password)
        {
            LoginTextBox.SendKeys(usename);
            PassTextBox.SendKeys(password);
            LoginButton.Click();
            GenericHelper.WaitForWebElementInPage(By.LinkText("Testng"), TimeSpan.FromSeconds(30));
            return new EnterLogins(ObjectRepository.Driver);

        }
        public void NavigateToHome()
        {
            
            GenericHelper.WaitForWebElementInPage(By.Id("signin"), TimeSpan.FromSeconds(30));
            SignInButton.Click();
            //Thread.Sleep(8000);
            GenericHelper.WaitForWebElementInPage(By.Id("login-btn"), TimeSpan.FromSeconds(30));
        }

    }
}