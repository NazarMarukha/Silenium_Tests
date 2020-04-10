using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace unitTests.PageObject
{
    public class OrderPage : ObjectBase
    {
        private WebDriverWait wait;
        
        

        public OrderPage(IWebDriver driver) : base(driver) { }

        public OrderPage ProceedToCheckOut(string proceedCheckout)
        {
            
            Driver.FindElement(By.XPath(proceedCheckout)).Click();
            return this;
        }

        public OrderPage WaitingOrderPageOpens(string proceedCheckout, TimeSpan implicitWait)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            wait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(6000));
            wait.Until(ExpectedConditions.ElementIsVisible(By
                 .XPath(proceedCheckout)));
            wait.Until(ExpectedConditions.ElementToBeClickable(By
                 .XPath(proceedCheckout)));
            Driver.Manage().Timeouts().ImplicitWait = implicitWait;
            return this;
        }

    }
}
