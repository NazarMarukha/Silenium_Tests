using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace unitTests.PageObject
{
    public class SearchPage : ObjectBase
    {

        
        private Actions action;

        public SearchPage(IWebDriver driver) : base(driver) { }
       
        public ProductPage ClickOnChoosedItem(string chooseItemToBuy)
        {
            action = new Actions(Driver);
            action.MoveToElement(Driver.FindElement(By.XPath(chooseItemToBuy)))
                  .Click()
                  .Perform();
            return new ProductPage(Driver);
        }
    }
}
