using System;
using System.Collections.Generic;
using System.Text;

namespace HW6.NewProduct
{
    class NewProducts
    {
        string ProductName;
        string CategoryId;
        string SupplierId;
        string UnitPrice;
        string QuantityPerUnit;
        string UnitsInStock;
        string UnitsOnOrder;
        string ReorderLevel;

        public NewProducts(string ProductName, string CategoryId, string SupplierId, string UnitPrice,
            string QuantityPerUnit, string UnitsInStock, string UnitsOnOrder, string ReorderLevel)
        {
            this.ProductName = ProductName;
            this.CategoryId = CategoryId;
            this.SupplierId = SupplierId;
            this.UnitPrice = UnitPrice;
            this.QuantityPerUnit = QuantityPerUnit;
            this.UnitsInStock = UnitsInStock;
            this.UnitsOnOrder = UnitsOnOrder;
            this.ReorderLevel = ReorderLevel;
        }

        public string getProductName()
        {
            return ProductName;
        }
        public string getCategoryId()
        {
            return CategoryId;
        }
        public string getSupplierId()
        {
            return SupplierId;
        }
        public string getUnitPrice()
        {
            return UnitPrice;
        }
        public string getQuantityPerUnit()
        {
            return QuantityPerUnit;
        }
        public string getUnitsInStock()
        {
            return UnitsInStock;
        }
        public string getUnitsOnOrder()
        {
            return UnitsOnOrder;
        }
        public string getReorderLevel()
        {
            return ReorderLevel;
        }
    }
}
