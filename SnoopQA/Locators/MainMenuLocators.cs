using OpenQA.Selenium;

namespace SnoopQA.Locators
{
    class MainMenuLocators
    {
        public static By _singInButton { get; set; } = By.XPath("//a[normalize-space()='Sign In']");
    }
}
