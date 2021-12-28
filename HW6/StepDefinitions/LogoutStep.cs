using HW6.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace HW6.StepDefinitions
{

    [Binding]
    class LogoutStep
    {
        private IWebDriver driver;

        [Given(@"I am login in website")]
        public void IAmLoginInWebsite()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://localhost:5000";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            LoginPage login = new LoginPage(driver);
            login.login("user", "user");
            Assert.AreNotEqual(login.GetNamePage(), "Login");
        }

        [When(@"I tap logout")]

        public void ITapLogout()
        {
            Menu menu = new Menu(driver);
            menu.Logout();
        }

        [Then(@"I chek disconnect")]

        public void IChekDisconnect()
        {
            driver.Quit();
        }
    }
}
