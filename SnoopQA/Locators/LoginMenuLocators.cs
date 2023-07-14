using OpenQA.Selenium;

namespace SnoopQA.Locators
{
    class LoginMenuLocators
    {
        public static By _loginInput { get; set; } = By.XPath("//input[@name='username']");
        public static By _passwordInput { get; set; } = By.XPath("//input[@name='password']");
        public static By _loginButton { get; set; } = By.XPath("//input[@name='signon']");
        public static By _registerButton { get; set; } = By.XPath("//a[normalize-space()='Register Now!']");

    }
}
