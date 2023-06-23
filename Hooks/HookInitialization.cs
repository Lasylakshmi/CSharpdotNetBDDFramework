using LivingDoc.SpecFlowPlugin;
//using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using SeleniumCucumberBDDDemo.BaseClasses;
using SeleniumCucumberBDDDemo.ComponentHelper;
using SeleniumCucumberBDDDemo.Configuration;
using SeleniumCucumberBDDDemo.CustomException;
using SeleniumCucumberBDDDemo.Drivers;
using SeleniumCucumberBDDDemo.Settings;
using TechTalk.SpecFlow;
using SeleniumCucumberBDDDemo.Reports;
using Reporter = SeleniumCucumberBDDDemo.Reports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumCucumberBDDDemo.Hooks
{
    [Binding]
    public class HookInitialization
    {
        private readonly ScenarioContext _scenarioContext;
        public HookInitialization (ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;

        private static ChromeDriver GetChromeDriver()
        {
            ChromeDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;
        }
        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("start-maximized");
            //option.AddArgument("--headless");
            //option.AddExtension(@"C:\Users\rahul.rathore\Desktop\Cucumber\extension_3_0_12.crx");
            //Logger.Info(" Using Chrome Options ");
            return option;
        }

        private static InternetExplorerDriver GetIEDriver()
        {
            InternetExplorerDriver driver = new InternetExplorerDriver(GetIEOptions());
            return driver;
        }
        private static InternetExplorerOptions GetIEOptions()
        {
            InternetExplorerOptions options = new InternetExplorerOptions();
            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            options.EnsureCleanSession = true;
            options.ElementScrollBehavior = InternetExplorerElementScrollBehavior.Bottom;
           // Logger.Info(" Using Internet Explorer Options ");
            return options;
        }

        [BeforeStep]
        [BeforeScenario]

        public static void InitWebdriver(TestContext tc)
        {

            ObjectRepository.Config = new AppConfigReader();
          //  Reporter.GetReportManager();
          //  Reporter.AddTestCaseMetadataToHtmlReport(tc);
            switch (ObjectRepository.Config.GetBrowser())
            {
                /* case BrowserType.Firefox:
                     ObjectRepository.Driver = GetFirefoxDriver();
                     Logger.Info(" Using Firefox Driver  ");

                     break;*/

                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                  //  Logger.Info(" Using Chrome Driver  ");
                    break;

                case BrowserType.IExplorer:
                    ObjectRepository.Driver = GetIEDriver();
                    //Logger.Info(" Using Internet Explorer Driver  ");
                    break;

                /*  case BrowserType.PhantomJs:
                      ObjectRepository.Driver = GetPhantomJsDriver();
                      Logger.Info(" Using PhantomJs Driver  ");
                      break;*/

                default:
                    throw new NoSutiableDriverFound("Driver Not Found : " + ObjectRepository.Config.GetBrowser().ToString());
            }
            ObjectRepository.Driver.Manage()
                .Timeouts().PageLoad = TimeSpan.FromSeconds(ObjectRepository.Config.GetPageLoadTimeOut());
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeOut());
            BrowserHelper.BrowserMaximize();
        }
        
        [AfterScenario]
       public static void TearDown()
        {
            if (ObjectRepository.Driver != null)
            {
               ObjectRepository.Driver.Close();
               ObjectRepository.Driver.Quit();
            }
           // Logger.Info(" Stopping the Driver  ");
        }
    }
}