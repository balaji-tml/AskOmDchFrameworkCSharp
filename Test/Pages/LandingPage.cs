using AskOmDchFramework9Nov1.Test.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskOmDchFramework9Nov1.Test.Pages
{
    public class LandingPage : BasePage
    {
        public LandingPage(IWebDriver driver) : base(driver)
        {
        }

        private By storeLINK = By.CssSelector("#menu-item-1227 > a");

        public StorePage ClickOnStoreLink()
        {
            driver.FindElement(storeLINK).Click();
            return new StorePage(driver);
        }
    }
}
