using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace unitTests.PageObject
{
    public class ProductPage : ObjectBase
    {

        public static readonly string quantityOfItemRow = "//input[@id='quantity_wanted']";
        private Actions action;
        private WebDriverWait wait;
        public ProductPage(IWebDriver driver) : base(driver) { } 
        
        public ProductPage EnterQuantityOfItem(string quantityOfItems)
        {
            Driver.FindElement(By.XPath(quantityOfItemRow)).Click();
            Driver.FindElement(By.XPath(quantityOfItemRow)).Clear();
            Driver.FindElement(By.XPath(quantityOfItemRow)).SendKeys(quantityOfItems);
            return this;
        }

        public ProductPage AddItemToCart(string addItemToCart)
        {
            Driver.FindElement(By.XPath(addItemToCart)).Click();
            return this;
        }

        public ProductPage WaitingSubmenuOpens(string exitButton, TimeSpan implicitWait)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            wait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(6000));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(exitButton)));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(exitButton)));
            Driver.Manage().Timeouts().ImplicitWait = implicitWait;
            return this;
        }

        public ProductPage CloseSubmenu(string exitButton)
        {
           
            Driver.FindElement(By.XPath(exitButton)).Click();
            return this;
        }

        public OrderPage OpenShoppingCart(string shoppingCart)
        {
            action = new Actions(Driver);
            action.MoveToElement(Driver
                  .FindElement(By.XPath(shoppingCart)))
                  .Perform();
            action.DoubleClick()
                  .Perform();
            return new OrderPage(Driver);
        }
    }
}
