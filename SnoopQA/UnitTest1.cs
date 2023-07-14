using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using SnoopQA.Data;
using SnoopQA.Locators;
using SnoopQA.PageObjects;


namespace UnitTestProject1
{

    public class UnitTest1
    {
        private IWebDriver _webDriver;
        private readonly string _url = "https://petstore.octoperf.com/";
        public bool CheckAnything(string any) =>
            _webDriver.PageSource.Contains(any);
        

        [OneTimeSetUp]
        public void Setup()
        {

            // Ініціалізуємо екземпляр веб-драйвера Chrome
            _webDriver = new ChromeDriver(Environment.CurrentDirectory);

            // 1. Перейти на сайт https://petstore.octoperf.com/
            _webDriver.Navigate().GoToUrl(_url);
        }


        [Test]

        public void Login()
        {
            WelcomePageObject login = new WelcomePageObject(_webDriver);
            login
                .EnterShop()
                .SingInButton()
                .LoginFill(TestData.Login, TestData.Passwrod)
                .LoginSuccsess();

            Assert.True(CheckAnything(TestData.loginSuccess));
        }
        [Test]
        public void Registration()
        {
            WelcomePageObject reg = new WelcomePageObject(_webDriver);
            reg
                .EnterShop()
                .SingInButton()
                .RegisterButton()
                .RegistrationFill(TestData.RandomUserId, TestData.Password, TestData.Password, TestData.FirstName, TestData.LastName, TestData.Email, TestData.Phone, TestData.Address, TestData.Address, TestData.City, TestData.State, TestData.ZipCode, TestData.Country)
                .RegisterButton();
            Assert.True(CheckAnything(TestData.RegisterSuccess));
        }
        [TearDown]
        public void EndTest()
        {
            if (CheckAnything(TestData.LoginSuccsess) == true)
            {
                MainMenuPageObject manin = new MainMenuPageObject(_webDriver);
                main.SignOutButton();  
            }
            _webDriver.Navigate().GoToUrl(_url);
        }
    }


 }

