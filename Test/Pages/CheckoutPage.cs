using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskOmDchFramework9Nov1.Test.Pages
{
    public class CheckoutPage : Base.BasePage
    {
        public CheckoutPage(IWebDriver driver) : base(driver)
        {
        }

        private By firstNameTXT = By.Id("billing_first_name");
        private By lastNameTXT = By.Id("billing_last_name");
        private By companyNameTXT = By.Id("billing_company");
        private By billingAddressTXT = By.Id("billing_address_1");
        private By cityTXT = By.Id("billing_city");
        private By postcodeTXT = By.Id("billing_postcode");
        private By phoneTXT = By.Id("billing_phone");
        private By emailTXT = By.Id("billing_email");
        private By placeOrderBTN = By.XPath("//button[contains(text(),'Place order')]");
        //private By confirmMSG = By.XPath("//p[contains(text(),'Thank you. Your order has been received.')]");
        

        public void EnterFirstName(string firstName)
        {
            driver.FindElement(firstNameTXT).SendKeys(firstName);
        }

        public void EnterLastName(string lastName)
        {
            driver.FindElement(lastNameTXT).SendKeys(lastName);
        }

        public void EnterCompanyName(string companyName)
        {
            driver.FindElement(companyNameTXT).SendKeys(companyName);
        }

        public void EnterBillingAddress(string billingAddress)
        {
            driver.FindElement(billingAddressTXT).SendKeys(billingAddress);
        }

        public void EnterBillingCity(string billingCity)
        {
            driver.FindElement(cityTXT).SendKeys(billingCity);
        }

        public void EnterBillingPostcode(string postcode)
        {
            driver.FindElement(postcodeTXT).SendKeys(postcode);
        }

        public void EnterPhone(string phone)
        {
            driver.FindElement(phoneTXT).SendKeys(phone);
        }

        public void EnterEmail(string email)
        {
            driver.FindElement(emailTXT).SendKeys(email);
        }

        public OrderConfirmationPage ClickOnPlaceOrderButton()
        {
            driver.FindElement(placeOrderBTN).Click();
            return new OrderConfirmationPage(driver);
        }

        //public string getConfirmMessage()
        //{
        //    return driver.FindElement(confirmMSG).Text;
        //}

    }




}





