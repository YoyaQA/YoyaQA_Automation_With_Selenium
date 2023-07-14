using OpenQA.Selenium;

namespace SnoopQA.Locators
{
    class WelcomePageLocators
    {
        public static By _EnterButton { get; set; } = By.XPath("//a[normalize-space()='Enter the Store']");
    }
}
