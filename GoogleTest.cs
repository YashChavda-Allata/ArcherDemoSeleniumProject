using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoProject
{
    public class GoogleTest
    {
        [Fact]
        public void VerifyUserIsAbleToOpenTheWebPage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Quit();
        }
    }
}