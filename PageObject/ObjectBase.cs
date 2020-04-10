using System;
using OpenQA.Selenium;
namespace unitTests.PageObject
{
    public class ObjectBase
    {
        protected readonly IWebDriver Driver;
        public ObjectBase(IWebDriver driver) => Driver = driver;
    }
}
