using OpenQA.Selenium;

namespace DemoProject.Locators
{
    public static class LoginPageLocators
    {
       public static By UsernameTxtBox = By.Id("user-name");
       public static By PasswordTxtBox = By.Id("password");
       public static By LoginBtn = By.Id("login-button");

    }
}
