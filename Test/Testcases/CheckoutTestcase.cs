using AskOmDchFramework9Nov1.Test.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;



namespace AskOmDchFramework9Nov1.Test.Testcases
{
    [TestClass]
    public class CheckoutTestcase : Base.BaseTest

    {
        [TestMethod]
        public void checkoutAsGuestLogin()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("https://askomdch.com/");
            LandingPage landingPage = new LandingPage(driver);
            landingPage.clickOnStoreLink();
            StorePage storePage = new StorePage(driver);
            storePage.enterValueForSearchProductField("blue");
            storePage.clickOnSearchProductButton();
            storePage.clickOnAddToCartButtonForBlueShoes();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(5000);
            storePage.clickOnViewShoppingCartButton();
            CartPage cartPage = new CartPage(driver);
            cartPage.clickOnProceedToCheckoutButton();
            CheckoutPage checkoutPage = new CheckoutPage(driver);
            checkoutPage.enterFirstName("FirstName");
            checkoutPage.enterLastName("LastName");
            checkoutPage.enterCompanyName("CompanyName");
            checkoutPage.enterBillingAddress("123,BTM Layout");
            checkoutPage.enterBillingCity("Beverly Hills");
            checkoutPage.enterBillingPostcode("90210");
            checkoutPage.enterPhone("9898980980");
            checkoutPage.enterEmail("FirstName.LastName@email.com");
            checkoutPage.clickOnPlaceOrderButton();

            


        }

    }
}
