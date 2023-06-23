using OpenQA.Selenium;
using SeleniumCucumberBDDDemo.ComponentHelper;
using SeleniumCucumberBDDDemo.Drivers;
using SeleniumCucumberBDDDemo.Pages;
using SeleniumCucumberBDDDemo.Settings;
using TechTalk.SpecFlow;
using SeleniumCucumberBDDDemo.Hooks;
using SeleniumCucumberBDDDemo.BaseClasses;
using System.Security.Policy;

namespace SeleniumCucumberBDDDemo.StepDefinitions
{
    [Binding]
    public class IamsLogin : BaseClass
    {
        LoginPage loginPage = new LoginPage(ObjectRepository.Driver);
        // private IWebDriver driver;
        // private LoginPage lPage;
        // private readonly ScenarioContext _scenarioContext;

        //private readonly LoginPage lPage;

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        /* public IamsLogin(ScenarioContext scenarioContext) {
             _scenarioContext=scenarioContext;
         }
        /* [Given(@"I open bstackdemo homepage")]
         public void GivenIOpenBstackdemoHomepage()
         {
             driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup();
             driver.Url= "https://bstackdemo.com/";
         }*/
        [Given(@"User is at Home Page with url ""(.*)""")]
        public void GivenUserIsAtHomePageWithUrl(string url)
        {
            //NavigationHelper.NavigateToUrl(url);
            NavigateToUrl(url);
          //  loginPage.NavigateToHome();


        }

        [Given(@"I click signin link text")]
        public void GivenIClickSigninLinkText()
        {
            loginPage.NavigateToHome();
        }

        [Given(@"I enter the login details")]
        public void GivenIEnterTheLoginDetails()
        {
            throw new PendingStepException();
        }

        [Given(@"I click login button")]
        public void GivenIClickLoginButton()
        {
            throw new PendingStepException();
        }

        [Then(@"Profile Name should appear")]
        public void ThenProfileNameShouldAppear()
        {
            throw new PendingStepException();
        }

    }
}