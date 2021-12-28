using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using HW6.Pages;
using HW6.BuisnessLogic;
using HW6.NewProduct;
using HW6.ProductMaker;
using NUnit.Framework;

namespace HW6.StepDefinitions
{

    [Binding]
    class AddNewProductStep
    {
        private IWebDriver driver;

        [Given(@"I logging in")]
        public void GivenILoggingin()
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

        [When(@"I tap AllProduct and CreateProduct")]
        public void WhenITapAllProductAndCreateProduct()
        {
            Menu menuPage = new Menu(driver);
            ProductPage product = menuPage.GoToProducts();
            Logic productPage = product.AddNewProduct();

            NewProducts newProduct = ProductMakers.Make();
            productPage.CreateProduct(newProduct);

        }

        [Then(@"I check")]
        public void ThenICheck()
        {
            Assert.AreEqual(driver.FindElement(By.XPath("//h2")).Text, "All Products");
            driver.Quit();
        }
    }
}
