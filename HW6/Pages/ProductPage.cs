using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Interactions;
using HW6.BuisnessLogic;

namespace HW6.Pages
{
    class ProductPage : AbstractPage
    {
        public ProductPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.XPath, Using = "//a[contains(@class,'btn')]")]
        private IWebElement NewProduct;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Шоколад')]")]
        private IWebElement Product;

        [FindsBy(How = How.XPath, Using = "(//*[@data-remove])[78]")]
        private IWebElement remove;

        [FindsBy(How = How.XPath, Using = "//h2")]
        private IWebElement chkPage;

        public string GetNamePage()
        {
            return chkPage.Text;
        }

        public Logic AddNewProduct()
        {
            IAction action = new Actions(driver)
                .Click(NewProduct);
            action.Perform();

            return new Logic(driver);
        }

        public EditProduct ViewProduct()
        {
            IAction action = new Actions(driver)
                .Click(Product);
            action.Perform();
            return new EditProduct(driver);
        }

        public void Remove()
        {
            IAction action = new Actions(driver).Click(remove);
            action.Perform();
            driver.SwitchTo().Alert().Accept();
        }
    }
}
