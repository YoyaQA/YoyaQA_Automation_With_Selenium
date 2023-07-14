using OpenQA.Selenium;
using SnoopQA.Locators;


namespace SnoopQA.PageObjects
{
    class WelcomePageObject
    {
        private IWebDriver _webDriver;
        public WelcomePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public MainMenuPageObject EnterShop()
        {
            _webDriver.FindElement(WelcomePageLocators._EnterButton).Click();
            return new MainMenuPageObject(_webDriver);



        }
            



    }
}
