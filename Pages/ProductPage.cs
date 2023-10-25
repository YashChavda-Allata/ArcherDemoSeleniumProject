using DemoProject.Locators;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Pages
{
    public class ProductPage
    {
        private readonly IWebDriver _driver;
        public ProductPage(IWebDriver driver)
        {
            _driver = driver;
        }

        IWebElement productPrice => _driver.FindElement(ProductPageLocators.productPrice);

        public string getProductPrice() => productPrice.Text;
    }
}
