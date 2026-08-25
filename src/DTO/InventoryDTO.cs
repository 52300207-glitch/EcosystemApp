using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.DTO
{
    public class InventoryDTO
    {
        private string ID;
        private ProductDTO Product;
        private PackageDTO Package;
        private string WareHouseID;
        private int StockQuantity;

        public InventoryDTO() { }
        public InventoryDTO(string ID, ProductDTO product, string  wareHouseID, int stockQuantity)
        {
            this.ID = ID;
            this.Product = product;
            this.Package = null;
            this.WareHouseID = wareHouseID;
            this.StockQuantity = stockQuantity;
        }

        public InventoryDTO(string ID, PackageDTO package, string wareHouseID, int stockQuantity)
        {
            this.ID = ID;
            this.Product = null;
            this.Package = package;
            this.WareHouseID = wareHouseID;
            this.StockQuantity = stockQuantity;
        }

        // getter và setter

        public ProductDTO GetProduct() { return Product; }
        public PackageDTO GetPackage() { return Package; }
        public string GetWareHouseID() { return WareHouseID; }
        public int GetStockQuantity() { return StockQuantity; }

        public void SetStockQuantity(int stockQuantity) { this.StockQuantity = stockQuantity; }

    }
}
