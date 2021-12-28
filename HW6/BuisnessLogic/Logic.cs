using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using HW6.Pages;
using HW6.NewProduct;
using SeleniumExtras.PageObjects;


namespace HW6.BuisnessLogic
{
    class Logic : AbstractPage
    {
        public Logic(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void CreateProduct(NewProducts newProduct)
        {
            CreateProducts Page = new CreateProducts(driver);
            Page.Create(newProduct.getProductName(),
                        newProduct.getCategoryId(),
                        newProduct.getSupplierId(),
                        newProduct.getUnitPrice(),
                        newProduct.getQuantityPerUnit(),
                        newProduct.getUnitsInStock(),
                        newProduct.getUnitsOnOrder(),
                        newProduct.getReorderLevel());
        }
    }
}
