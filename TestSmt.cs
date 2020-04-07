using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace unitTests
{
    [TestFixture]
    public class FirstTest
    {
    
        private readonly IWebDriver driver;
        private readonly string url = "http://automationpractice.com/index.php";
        private TimeSpan implicitWait = TimeSpan.FromMilliseconds(300);

        public FirstTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = implicitWait;
            driver.Navigate().GoToUrl(url);
            
        }

        [Test]

        public void TestingModule1() //Make first step to buy any item(1.Summary)
        {
            string searchLineInput = "//input[@id='search_query_top']";
            string searchItem = "Faded Short Sleeve T-shirts";
            driver.FindElement(By.XPath(searchLineInput)).Click();
            driver.FindElement(By.XPath(searchLineInput)).Clear();
            driver.FindElement(By.XPath(searchLineInput)).SendKeys(searchItem + Keys.Enter);

            string chooseItemToBuy = "//div[@class='product-image-container']";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromMilliseconds(600));
            wait1.Until(ExpectedConditions.ElementExists(By.XPath(chooseItemToBuy)));
            wait1.Until(ExpectedConditions.ElementToBeClickable(By.XPath(chooseItemToBuy)));
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.XPath(chooseItemToBuy)))
                  .Perform();
            action.MoveToElement(driver.FindElement(By.XPath(chooseItemToBuy)))
                  .Click()
                  .Perform();
            driver.Manage().Timeouts().ImplicitWait = implicitWait;

            string quantityOfItemRow = "//input[@id='quantity_wanted']";
            string addItemToCart = "//span[text()='Add to cart']";
            string quantityOfItems = "2";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(6));
            wait2.Until(ExpectedConditions.ElementExists(By.XPath(quantityOfItemRow)));
            driver.FindElement(By.XPath(quantityOfItemRow)).Click();
            driver.Manage().Timeouts().ImplicitWait = implicitWait;
            driver.FindElement(By.XPath(quantityOfItemRow)).Clear();
            driver.FindElement(By.XPath(quantityOfItemRow)).SendKeys(quantityOfItems);
            driver.FindElement(By.XPath(addItemToCart)).Click();

            string exitButton = "//span[@class='cross']";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(6));
            wait3.Until(ExpectedConditions.ElementIsVisible(By.XPath(exitButton)));
            wait3.Until(ExpectedConditions.ElementToBeClickable(By.XPath(exitButton)));
            driver.Manage().Timeouts().ImplicitWait = implicitWait;
            driver.FindElement(By.XPath(exitButton)).Click();

            string shoppingCart = "//div[@class='shopping_cart']//a[@title='View my shopping cart']";
            Actions action2 = new Actions(driver);
            action2.MoveToElement(driver
                   .FindElement(By.XPath(shoppingCart)))
                   .Click()
                   .Perform();

            string proceedCheckout = "//a[@title='Proceed to checkout']/span[text()='Proceed to checkout']";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            WebDriverWait wait4 = new WebDriverWait(driver, TimeSpan.FromSeconds(6));
            wait4.Until(ExpectedConditions.ElementIsVisible(By
                 .XPath(proceedCheckout)));
            wait4.Until(ExpectedConditions.ElementToBeClickable(By
                 .XPath(proceedCheckout)));
            driver.Manage().Timeouts().ImplicitWait = implicitWait;
            driver.FindElement(By.XPath(proceedCheckout)).Click();
            

            
        }


        [Test]

        public void TestingWishList()
        {
            string loginPage = "//a[@class='login']";
            driver.FindElement(By.XPath(loginPage)).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            WebDriverWait _wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(600));
            string emailXpath = "//input[@id='email']";
            _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(emailXpath)));
            _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(emailXpath)));
            string email = "text@mail.ru";
            string password = "nazar2319";
            driver.FindElement(By.XPath(emailXpath)).SendKeys(email + Keys.Tab + password);
            driver.Manage().Timeouts().ImplicitWait = implicitWait;
            string signIn = "//button[@id='SubmitLogin']";
            driver.FindElement(By.XPath(signIn)).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            WebDriverWait _wait2 = new WebDriverWait(driver, TimeSpan.FromMilliseconds(600));
            string myWishesList = "//a[@title='My wishlists']";
            _wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath(myWishesList)));
            _wait2.Until(ExpectedConditions.ElementToBeClickable(By.XPath(myWishesList)));
            driver.FindElement(By.XPath(myWishesList)).Click();
            driver.Manage().Timeouts().ImplicitWait = implicitWait;

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
            WebDriverWait _wait3 = new WebDriverWait(driver, TimeSpan.FromMilliseconds(600));
            string nameListInput = "//input[@id='name']";
            _wait3.Until(ExpectedConditions.ElementIsVisible(By.XPath(nameListInput)));
            _wait3.Until(ExpectedConditions.ElementToBeClickable(By.XPath(nameListInput)));
            string newList = "myNewList";
            driver.FindElement(By.XPath(nameListInput)).SendKeys(newList);
            string buttonSaveList = "//button[@id='submitWishlist']";
            driver.FindElement(By.XPath(buttonSaveList)).Click();


        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}

