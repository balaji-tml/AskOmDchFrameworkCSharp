using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;

namespace AskOmDchFramework9Nov1.Test.Base
{
    [TestClass]
    public class BaseTest
    {
        protected IWebDriver? driver;
        protected IJavaScriptExecutor? jse;
        protected static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        [TestInitialize]
        public void SetUp()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
                jse = (IJavaScriptExecutor)driver;
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                Logger.Info("Browser is loaded!");
            }
        }

        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
                Logger.Info("Browser is closed!");
            }
        }
    }
}
