using OpenQA.Selenium;

namespace SnoopQA.Locators
{
    class RegistrarionMenuLocators
    {
        public static By _name { get; set; } = By.Name("username");
        public static By _passwrod { get; set; } = By.Name("password");
        public static By _repeatedPassword { get; set; } = By.Name("repeatedPassword");
        public static By _firstName { get; set; } = By.Name("firstName");
        public static By _lastName { get; set; } = By.Name("lastName");
        public static By _email { get; set; } = By.Name("account.email");
        public static By _phone { get; set; } = By.Name("account.phone");
        public static By _address1 { get; set; } = By.Name("account.address1");
        public static By _address2 { get; set; } = By.Name("account.address2");
        public static By _city { get; set; } = By.Name("account.city");
        public static By _state { get; set; } = By.Name("account.state");
        public static By _zip { get; set; } = By.Name("account.zip");
        public static By _country { get; set; } = By.Name("account.country");
        public static By _regButton { get; set; } = By.Name("newAccount");

    }
}
