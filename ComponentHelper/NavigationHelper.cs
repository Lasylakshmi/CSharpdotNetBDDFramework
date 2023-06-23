using Dynamitey.Internal.Optimization;
using log4net;
using OpenQA.Selenium.Chrome;
using SeleniumCucumberBDDDemo.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCucumberBDDDemo.ComponentHelper
{
    public class NavigationHelper
    { 
        // private static readonly ILog Logger = Log4NetHelper.GetXmlLogger(typeof(NavigationHelper));
        public static void NavigateToUrl1(string Url)
        {
            
            ObjectRepository.Driver.Navigate().GoToUrl(Url);
            //Logger.Info(" Navigate To Page " + Url);
        }
       /* private static ChromeDriver GetChromeDriver()
        {
            ChromeDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;
        }*/
        /*private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("start-maximized");
            //option.AddArgument("--headless");
            //option.AddExtension(@"C:\Users\rahul.rathore\Desktop\Cucumber\extension_3_0_12.crx");
            //Logger.Info(" Using Chrome Options ");
            return option;
        }*/
    }
}
