using DemoProject.Locators;
using OpenQA.Selenium;

namespace DemoProject.Pages
{
    public class ProductListPage
    {
        private readonly IWebDriver _driver;
        public ProductListPage(IWebDriver driver)
        {
            _driver = driver;
        }

        IWebElement productFromList(string productName) => _driver.FindElement(By.XPath("//div[contains(text(),'" + productName + "')]"));

        public void clickProduct(string productName) => productFromList(productName).Click();
    }
}
