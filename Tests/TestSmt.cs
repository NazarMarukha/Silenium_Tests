using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using unitTests.PageObject;


namespace unitTests.Tests
{
    [TestFixture]
    public class TestSmt : Settings
    {
    
        private readonly IWebDriver driver;
       
        public MainPage mainPage;
        

        public TestSmt()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = implicitWait;
            driver.Navigate().GoToUrl(Url);
            mainPage = new MainPage(driver);
        }

        [Test]

        public void TestingModule1() //Make first step to buy any item(1.Summary)
        {

            SearchPage searchPage = mainPage.SearchLineInput(nameOfItem);

            ProductPage pageOfProduct = searchPage.ClickOnChoosedItem(chooseItemToBuy);
            pageOfProduct.EnterQuantityOfItem(quantityOfItems)
                         .AddItemToCart(addItemToCart)
                         .WaitingSubmenuOpens(addItemToCart, implicitWait)
                         .CloseSubmenu(exitButton);

            OrderPage orderPage = pageOfProduct.OpenShoppingCart(shoppingCart);
            orderPage.WaitingOrderPageOpens(proceedCheckout, implicitWait)
                     .ProceedToCheckOut(proceedCheckout);
        }


        [Test]

        public void TestingWishList()
        {
            Authentication authenticationPage = mainPage.ClickSignInButton();
            authenticationPage.EnterAccountData(email, password);

            MyAccountPage accountPage = authenticationPage.SingInYourAccount();

            MyWishList myWishList = accountPage.ClickOnMyWishListsButton();
            myWishList.EnterNewListName(newListName)
                      .ClickSaveNewList();
            
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}

