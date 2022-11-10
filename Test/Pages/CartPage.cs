using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskOmDchFramework9Nov1.Test.Pages
{
    internal class CartPage : Base.BasePage
    {
        public CartPage(IWebDriver driver) : base(driver)
        {
        }

        private By proceedToCheckoutBTN = By.XPath("//a[contains(text(),'Proceed to checkout')]");


        public void clickOnProceedToCheckoutButton()
        {
            driver.FindElement(proceedToCheckoutBTN).Click();
        }
    }
}
