using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.DTO
{
    public class ProductDTO
    {
        private string ID;
        private string Name;
        private string Category;
        private string Unit;
        private decimal SellingPrice;

        //constructor
        private ProductDTO() { }
        public ProductDTO(string id, string name, string category, string unit, decimal sellingPrice)
        {
            ID = id;
            Name = name;
            Category = category;
            Unit = unit;
            SellingPrice = sellingPrice;
        }

        public ProductDTO(string id, string name, string unit, decimal sellingPrice)
        {
            ID = id;
            Name = name;
            Category = "";
            Unit = unit;
            SellingPrice = sellingPrice;
        }
        // getters
        public string GetID() { return ID; }
        public string GetName() { return Name; }
        public string GetCategory() { return Category; }
        public decimal GetSellingPrice() { return SellingPrice; }
        public string GetUnit() { return Unit; }

        // setters
        public void SetPrice(decimal sellPrice) { SellingPrice = sellPrice; }
        public void SetName(string name) { Name = name; }
        public void SetCategory(string category) {Category = category; }
        public void SetUnit(string unit) { Unit = unit; }
        
        public void SetID(string id) { ID = id; }
    }
}
