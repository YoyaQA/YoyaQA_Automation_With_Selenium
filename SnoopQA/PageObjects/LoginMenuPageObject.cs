using OpenQA.Selenium;
using SnoopQA.Locators;

namespace SnoopQA.PageObjects
{
    class LoginMenuPageObject
    {
        
        private IWebDriver _webDriver;
        public LoginMenuPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;

        }
        public LoginMenuPageObject LoginFill(string login, string passwrod)
        {
            _webDriver.FindElement(LoginMenuLocators._loginInput).SendKeys(login);
            _webDriver.FindElement(LoginMenuLocators._passwordInput).Clear();
            _webDriver.FindElement(LoginMenuLocators._passwordInput).SendKeys(passwrod);
            return new LoginMenuPageObject(_webDriver);
        }
        public MainMenuPageObject LoginSuccsess()
        {
            _webDriver.FindElement(LoginMenuLocators._loginButton).Click();
            return new MainMenuPageObject(_webDriver);
        }
        public RegistrationMenuPageObject RegisterButton()
        {
            _webDriver.FindElement(LoginMenuLocators._registerButton).Click();
            return new RegistrationMenuPageObject(_webDriver);
        }



            




    }



}









          



