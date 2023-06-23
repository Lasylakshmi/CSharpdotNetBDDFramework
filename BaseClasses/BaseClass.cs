using BoDi;
using LivingDoc.SpecFlowPlugin;
using log4net;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SeleniumCucumberBDDDemo.Configuration;
using SeleniumCucumberBDDDemo.CustomException;
using SeleniumCucumberBDDDemo.Pages;
using SeleniumCucumberBDDDemo.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCucumberBDDDemo.BaseClasses
{
    [Binding]

    public class BaseClass
    {
        public static void NavigateToUrl(string Url)
        {

            ObjectRepository.Driver.Navigate().GoToUrl(Url);
            //Logger.Info(" Navigate To Page " + Url);
        }
    } 
}
