using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AskOmDchFramework9Nov1.Test.Base
{
    [TestClass]
    public class BaseTest
    {
        protected IWebDriver? driver;
        protected IJavaScriptExecutor? jse;

        [TestInitialize]
        public void setUp()
        {
            driver = new ChromeDriver();
            jse = (IJavaScriptExecutor)driver;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void tearDown()
        {
            driver.Quit();  
        }
    }
}
