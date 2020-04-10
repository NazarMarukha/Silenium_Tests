using System;
using OpenQA.Selenium;

namespace unitTests.PageObject
{
    public class Authentication : ObjectBase
    {
        private static readonly string emailXpath = "//input[@id='email']";
        private static readonly string signInButton = "//button[@id='SubmitLogin']";
        public Authentication(IWebDriver driver) : base(driver) { }

        public Authentication EnterAccountData(string email, string password)
        {
            Driver.FindElement(By.XPath(emailXpath)).Click();
            Driver.FindElement(By.XPath(emailXpath)).SendKeys(email + Keys.Tab + password);
            return this;
        }

        public MyAccountPage SingInYourAccount()
        {
            Driver.FindElement(By.XPath(signInButton)).Click();
            return new MyAccountPage(Driver);
        }
    }
}
