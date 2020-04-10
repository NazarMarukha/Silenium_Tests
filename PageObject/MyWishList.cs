using System;
using OpenQA.Selenium;

namespace unitTests.PageObject
{
    public class MyWishList : ObjectBase
    {
        private static readonly string nameListInput = "//input[@id='name']";
        private static readonly string buttonSaveList = "//button[@id='submitWishlist']";

        public MyWishList(IWebDriver driver) : base(driver) { }

        public MyWishList EnterNewListName(string newList)
        {
            Driver.FindElement(By.XPath(nameListInput)).Click();
            Driver.FindElement(By.XPath(nameListInput)).SendKeys(newList);
            return this;
        }

        public MyWishList ClickSaveNewList()
        {
            Driver.FindElement(By.XPath(buttonSaveList)).Click();
            return this;
        }

    }
}
