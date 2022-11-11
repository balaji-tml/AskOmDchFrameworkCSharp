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
            landingPage.ClickOnStoreLink();
            StorePage storePage = new StorePage(driver);
            storePage.EnterValueForSearchProductField("blue");
            storePage.ClickOnSearchProductButton();
            storePage.ClickOnAddToCartButtonForBlueShoes();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(5000);
            storePage.ClickOnViewShoppingCartButton();
            CartPage cartPage = new CartPage(driver);
            cartPage.ClickOnProceedToCheckoutButton();
            CheckoutPage checkoutPage = new CheckoutPage(driver);
            checkoutPage.EnterFirstName("FirstName");
            checkoutPage.EnterLastName("LastName");
            checkoutPage.EnterCompanyName("CompanyName");
            checkoutPage.EnterBillingAddress("123,BTM Layout");
            checkoutPage.EnterBillingCity("Beverly Hills");
            checkoutPage.EnterBillingPostcode("90210");
            checkoutPage.EnterPhone("9898980980");
            checkoutPage.EnterEmail("FirstName.LastName@email.com");
            Thread.Sleep(5000);
            checkoutPage.ClickOnPlaceOrderButton();

            


        }

    }
}
