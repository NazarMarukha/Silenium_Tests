using System;
using OpenQA.Selenium;

namespace unitTests.PageObject
{
    public class MyAccountPage : ObjectBase
    {
        private static readonly string myWishList = "//a[@title='My wishlists']";
        public MyAccountPage(IWebDriver driver) : base(driver) { }

        public MyWishList ClickOnMyWishListsButton()
        {
            Driver.FindElement(By.XPath(myWishList)).Click();
            return new MyWishList(Driver);
        }
        
    }
}
