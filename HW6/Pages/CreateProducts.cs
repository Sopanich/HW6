using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Interactions;

namespace HW6.Pages
{
    class CreateProducts : AbstractPage
    {
        public CreateProducts(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='ProductName']")]
        private IWebElement ProductName;

        [FindsBy(How = How.XPath, Using = "//*[@id='CategoryId']")]
        private IWebElement CategoryId;

        [FindsBy(How = How.XPath, Using = "//*[@id='SupplierId']")]
        private IWebElement SupplierId;

        [FindsBy(How = How.XPath, Using = "//*[@id='UnitPrice']")]
        private IWebElement UnitPrice;

        [FindsBy(How = How.XPath, Using = "//*[@id='QuantityPerUnit']")]
        private IWebElement QuantityPerUnit;

        [FindsBy(How = How.XPath, Using = "//*[@id='UnitsInStock']")]
        private IWebElement UnitsInStock;

        [FindsBy(How = How.XPath, Using = "//*[@id='UnitsOnOrder']")]
        private IWebElement UnitsOnOrder;

        [FindsBy(How = How.XPath, Using = "//*[@id='ReorderLevel']")]
        private IWebElement ReorderLevel;

        [FindsBy(How = How.XPath, Using = "//input[contains(@class,'btn')]")]
        private IWebElement SendBtn;

        public void Create(string Name, string Cat, string Sup, string UnitP, string Quantity,
            string UnitsS, string UnitsOn, string Reorder)
        {
            new SelectElement(CategoryId).SelectByText(Cat);
            new SelectElement(SupplierId).SelectByText(Sup);
            IAction action = new Actions(driver)
                .Click(ProductName)
                .SendKeys(Name)
                .Click(UnitPrice)
                .SendKeys(UnitP)
                .Click(QuantityPerUnit)
                .SendKeys(Quantity)
                .Click(UnitsInStock)
                .SendKeys(UnitsS)
                .Click(UnitsOnOrder)
                .SendKeys(UnitsOn)
                .Click(ReorderLevel)
                .SendKeys(Reorder)
                .Click(SendBtn);
            action.Perform();
        }
    }
}
