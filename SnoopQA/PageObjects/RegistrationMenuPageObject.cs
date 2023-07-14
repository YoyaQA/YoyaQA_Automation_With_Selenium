using OpenQA.Selenium;
using SnoopQA.Locators;

namespace SnoopQA.PageObjects
{
    class RegistrationMenuPageObject
    {
        private IWebDriver _webDriver;
        public RegistrationMenuPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

       public RegistrationMenuPageObject RegistrationFill(string id, string password, string repeatPassword, string firstname, string lastName, string Email, string phone, string address, string city, string state, string zip, string country)
        {
        _webDriver.FindElement(RegistrarionMenuLocators._userId).SendKeys(id);
        _webDriver.FindElement(RegistrarionMenuLocators._password).SendKeys(password);
        _webDriver.FindElement(RegistrarionMenuLocators._repeatedPassword).SendKeys(repeatPassword);
        _webDriver.FindElement(RegistrarionMenuLocators._firstName).SendKeys(firstname);
        _webDriver.FindElement(RegistrarionMenuLocators._lastName).SendKeys(lastName);
        _webDriver.FindElement(RegistrarionMenuLocators._email).SendKeys(Email);
        _webDriver.FindElement(RegistrarionMenuLocators._phone).SendKeys(phone);
        _webDriver.FindElement(RegistrarionMenuLocators._address1).SendKeys(address);
        _webDriver.FindElement(RegistrarionMenuLocators._address2).SendKeys(address);
        _webDriver.FindElement(RegistrarionMenuLocators._city).SendKeys(city);
        _webDriver.FindElement(RegistrarionMenuLocators._state).SendKeys(state);
        _webDriver.FindElement(RegistrarionMenuLocators._zip).SendKeys(zip);
        _webDriver.FindElement(RegistrarionMenuLocators._country).SendKeys(country);

            return new RegistrationMenuPageObject(_webDriver);

        }
        public MainMenuPageObject RegisterButton()
        {
            _webDriver.FindElement(RegistrarionMenuLocators._regButton).Click();
            return new MainMenuPageObject(_webDriver);
        }
    }
}
