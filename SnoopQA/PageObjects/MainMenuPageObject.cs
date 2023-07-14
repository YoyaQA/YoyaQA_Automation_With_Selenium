using OpenQA.Selenium;
using SnoopQA.Locators;

namespace SnoopQA.PageObjects
{
    class MainMenuPageObject
    {
        private IWebDriver _webDriver;
        public MainMenuPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public LoginMenuPageObject SingInButton()
        {
            _webDriver.FindElement(MainMenuLocators._singInButton).Click();
            return new LoginMenuPageObject(_webDriver);
        }




    }
}
