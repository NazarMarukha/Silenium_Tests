using System;
using OpenQA.Selenium;

namespace unitTests.PageObject
{
    public class MainPage : ObjectBase
    {
        private static readonly By inputLine = By.XPath("//input[@id='search_query_top']");
        private static readonly string signInButton = "//a[@class='login']";

        public MainPage(IWebDriver driver) : base(driver)
        {
        }

        public SearchPage SearchLineInput(string itemName)
        {
            Driver.FindElement(inputLine).Click();
            Driver.FindElement(inputLine).Clear();
            Driver.FindElement(inputLine).SendKeys(itemName + Keys.Enter);
            return new SearchPage(Driver);
        }

        public Authentication ClickSignInButton()
        {
            Driver.FindElement(By.XPath(signInButton)).Click();
            return new Authentication(Driver);
        }
    
    }
}
