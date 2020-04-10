using System;
namespace unitTests.Tests
{
    public class Settings
    {
        public static readonly string Url = "http://automationpractice.com/index.php";
        public static readonly TimeSpan implicitWait = TimeSpan.FromMilliseconds(3000);
        public static readonly string nameOfItem = "Faded Short Sleeve T-shirts";
        public static readonly string chooseItemToBuy = "//div[@class='product-image-container']";
        public static readonly string addItemToCart = "//span[text()='Add to cart']";
        public static readonly string exitButton = "//span[@class='cross']";
        public static readonly string quantityOfItems = "2";
        public static readonly string shoppingCart = "//div[@class='shopping_cart']//a[@title='View my shopping cart']";
        public static readonly string proceedCheckout = "//a[@title='Proceed to checkout']/span[text()='Proceed to checkout']";
        public static readonly string email = "text@mail.ru";
        public static readonly string password = "nazar2319";
        public static readonly string newListName = "myNewList";
        public Settings() { }
        
    }
}

