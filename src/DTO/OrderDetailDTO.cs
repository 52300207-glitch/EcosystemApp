using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.DTO
{
    public class OrderDetailDTO
    {
        private string ID;
        private ProductDTO Product;
        private int ProductQuantity;
        private decimal TotalPrice;
        private OrderDetailDTO() { }
        public OrderDetailDTO(string id, ProductDTO product, int productQuantity)
        {
            ID = id;
            Product = product;
            ProductQuantity = productQuantity;
            TotalPrice = product.GetSellingPrice() * productQuantity;
        }

        public OrderDetailDTO(string id, ProductDTO product, int productQuantity, decimal totalPice)
        {
            ID = id;
            Product = product;
            ProductQuantity = productQuantity;
            TotalPrice = totalPice;
        }
        // getters
        public string GetID() { return ID; }
        public ProductDTO GetProduct() { return Product; }
        public int GetQuantity() { return ProductQuantity; }
        public decimal GetToTalPrice() { return TotalPrice; }

        //setters
        public void SetQuantity(int productQuantity) { ProductQuantity = productQuantity; }
        public void SetTotalPrice(decimal totalPrice) { TotalPrice = totalPrice; }

        public string ToString()
        {
            return $"OrderItemDTO[ID={ID}, Product={Product.GetName()}, Quantity={ProductQuantity}, Price={TotalPrice}]";
        }

    }
}
