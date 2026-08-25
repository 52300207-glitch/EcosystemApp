using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.DTO
{
    public class InvoiceDetailDTO
    {
        private string ID;
        private ProductDTO Product;
        private PackageDTO Package;
        private int Quantity;
        private decimal TotalAmount;

        public InvoiceDetailDTO() { }
        public InvoiceDetailDTO(string id, ProductDTO product , int quantity, decimal totalAmount) 
        {
            this.ID = id;
            this.Product = product;
            this.Package = null;
            this.Quantity = quantity;
            this.TotalAmount = totalAmount;
        }

        public InvoiceDetailDTO(string id, ProductDTO product, PackageDTO package, int quantity, decimal totalAmount)
        {
            this.ID = id;
            this.Product = product;
            this.Package = package;
            this.Quantity = quantity;
            this.TotalAmount = totalAmount;
        }

        public InvoiceDetailDTO(string id, PackageDTO package, decimal totalAmount)
        {
            this.ID = id;
            this.Product = null;
            this.Package = package;
            this.Quantity = 1;
            this.TotalAmount = totalAmount;
        }


        // getter
        public string GetID() { return ID; }
        public ProductDTO GetProduct() { return Product; }

        public PackageDTO GetPackage() { return Package; }
        public int GetQuantity() { return Quantity; }
        public void SetQuantity(int quantity) { this.Quantity = quantity; }

        public void SetTotalAmount(decimal totalAmount) { this.TotalAmount = totalAmount; }
        public decimal GetTotalAmount() { return TotalAmount; }
    }
}
