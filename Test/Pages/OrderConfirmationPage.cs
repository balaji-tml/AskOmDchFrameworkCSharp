using AskOmDchFramework9Nov1.Test.Base;
using OpenQA.Selenium;

namespace AskOmDchFramework9Nov1.Test.Pages
{
    public class OrderConfirmationPage : BasePage
    {
        public OrderConfirmationPage(IWebDriver driver) : base(driver)
        {
        }

        private By confirmMSG = By.XPath("//p[contains(text(),'Thank you. Your order has been received.')]");

        public string getConfirmMessage()
        {
            return driver.FindElement(confirmMSG).Text;
        }
    }
}