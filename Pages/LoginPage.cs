using DemoProject.Locators;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoProject.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;
        private readonly Actions _actions;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            _actions = new Actions(driver);
        }

        IWebElement usernameTxtBox => _driver.FindElement(LoginPageLocators.UsernameTxtBox);

        IWebElement passwordTxtBox => _driver.FindElement(LoginPageLocators.PasswordTxtBox);

        IWebElement loginBtn => _driver.FindElement(LoginPageLocators.LoginBtn);

        public void EnterUsername(string username) => usernameTxtBox.SendKeys(username);

        public void EnterPassword(string password) => passwordTxtBox.SendKeys(password);

        public void ClickLoginBtn()
        {
            _wait.Until(ExpectedConditions.ElementToBeClickable(loginBtn));
            _actions.Click(loginBtn).Build().Perform();
        }

        public void LoginToSauceDemo(string username, string password)
        {
            EnterUsername(username);
            EnterPassword(password);
            ClickLoginBtn();
        }

        public void OpenUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

    }
}
