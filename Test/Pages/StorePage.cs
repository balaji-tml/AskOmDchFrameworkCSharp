using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AskOmDchFramework9Nov1.Test.Pages
{
    
    public class StorePage : Base.BasePage
    {
        public StorePage(IWebDriver driver) : base(driver)
        {
        }

        By searchProdTXT = By.Id("woocommerce-product-search-field-0");

        By searchProdBTN = By.XPath("//button[contains(text(),'Search')]");

        By addToCartBtn = By.XPath("//*[@id=\"main\"]/div/ul/li[1]/div[2]/a[2]");

        By ViewShoppingCartBtn = By.XPath("//*[@id=\"ast-site-header-cart\"]/div[1]/a/div/span");

        public void enterValueForSearchProductField(string productName)
        {
            driver.FindElement(searchProdTXT).SendKeys(productName);
        }

        public void clickOnSearchProductButton()
        {
            driver.FindElement(searchProdBTN).Click();  
        }

        public void clickOnAddToCartButtonForBlueShoes()
        {
            driver.FindElement(addToCartBtn).Click();
        }

        public void clickOnViewShoppingCartButton()
        {
            driver.FindElement(ViewShoppingCartBtn).Click();
            //IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            //IWebElement elm = (IWebElement)jse.ExecuteScript("return document.querySelector(\"#ast-site-header-cart > div.ast-site-header-cart-li > a > div > span\")");
            //elm.Click();
        }
    }
}
