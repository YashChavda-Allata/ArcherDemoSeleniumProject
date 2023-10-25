using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoProject
{
    public class SauceDemo
    {
        [Fact]
        public void VerifyUserIsAbleToVerifyPriceForTheProduct()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();
            driver.FindElement(By.XPath("//div[contains(text(),'Sauce Labs Backpack')]")).Click();
            IWebElement price = driver.FindElement(By.XPath("//div[@class='inventory_details_price']"));
            Assert.Equal("$29.99", price.Text);
            driver.Quit();
        }
    }
}