using DemoProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoProject
{
    public class SauceDemoPOM
    {
        IWebDriver driver;
        LoginPage loginPage;
        ProductPage productPage;
        ProductListPage productListPage;


        [Theory]
        [InlineData("Sauce Labs Backpack", "$29.99")]
        [InlineData("Sauce Labs Bike Light", "$9.99")]
        [InlineData("Sauce Labs Bolt T-Shirt", "$15.99")]
        [InlineData("Sauce Labs Fleece Jacket", "$49.99")]
        public void VerifyUserIsAbleToVerifyPriceForTheProduct(string productName,string productPrice)
        {
            driver= new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            loginPage = new LoginPage(driver);
            productPage = new ProductPage(driver);
            productListPage = new ProductListPage(driver);
            
            loginPage.OpenUrl("https://www.saucedemo.com/v1/");
            loginPage.EnterUsername("standard_user");
            loginPage.EnterPassword("secret_sauce");
            loginPage.ClickLoginBtn();
            productListPage.clickProduct(productName);
            
            Assert.Equal(productPrice, productPage.getProductPrice());
            driver.Quit();
        }
    }
}