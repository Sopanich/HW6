using HW6.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace HW6.StepDefinitions
{
    [Binding]
    class LoginStep
    {
        private IWebDriver driver;

        [Given(@"I open url")]
        public void GivenIOpenUrl()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://localhost:5000";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
        }

        [When(@"I write in the login window in the password window")]
        public void WhenIWriteInTheLoginWindowInThePasswirdWindow()
        {
            LoginPage login = new LoginPage(driver);
            login.login("user", "user");
            Assert.AreNotEqual(login.GetNamePage(), "Login");
        }

        [Then(@"I check connect to website")]
        public void ICheckConnectToWebsite()
        {
            LoginPage login = new LoginPage(driver);
            Assert.AreNotEqual(login.GetNamePage(), "Login");
            driver.Close();

        }

    }
}
