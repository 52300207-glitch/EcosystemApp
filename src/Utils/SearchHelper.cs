using EcosystemApp.DAL;
using EcosystemApp.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.Utils
{
    public class SearchHelper
    {
        public List<OrderDTO> SearchOrdersByKeyword(List<OrderDTO> orders, string keyword)
        {
            if(keyword.Equals(""))
            {
                return orders;
            }
            else
            {
                List<OrderDTO> searchedOrders = new List<OrderDTO>();
                foreach (var order in orders)
                {
                    bool isContained = false;
                    keyword = RemoveDiacritics(keyword).ToLower();
                    string id = RemoveDiacritics(order.GetID().ToLower());
                    string customerName = RemoveDiacritics(order.GetCustomer().GetFullName().ToLower());
                    string totalAmount = RemoveDiacritics(order.GetTotalAmount().ToString().ToLower());

                    isContained = customerName.Contains(keyword) ||
                                id.Contains(keyword) ||
                                totalAmount.Contains(keyword);
                    if (isContained) 
                    {
                        searchedOrders.Add(order);
                    }
                }
                return searchedOrders;
            }
        }

        public  List<ProductDTO> SearchProductsByKeyword(List<ProductDTO> products, string keyword)
        {
            if (keyword.Equals(""))
            {
                return products;
            }
            else
            {
                if (keyword == null || keyword.Length == 0)
                {
                    return null;
                }

                var filtered = products
                    .Where(p => RemoveDiacritics(p.GetName()).ToLower().Contains(RemoveDiacritics(keyword).ToLower()))
                    .Take(10)
                    .ToList();

                return filtered.Count == 0 ? new List<ProductDTO>() : filtered;
            }
        }

        public List<InventoryDTO> SearchInventoriesByKeyword(List<InventoryDTO> inventories, string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return inventories;

            keyword = RemoveDiacritics(keyword).ToLower();

            List<InventoryDTO> filtered = new List<InventoryDTO>();

            foreach (var inv in inventories)
            {

                // Lấy tên hiển thị
                string name = inv.GetProduct() != null
                    ? inv.GetProduct().GetName()
                    : (inv.GetPackage() != null
                        ? inv.GetPackage().GetPackagingType()?.GetTypeName() ?? ""
                        : "");

                // Kiểm tra điều kiện search
                bool match = RemoveDiacritics(name).ToLower().Contains(keyword);

                if (match)
                    filtered.Add(inv);
            }

            return filtered;
        }

        public List<EmployeeDTO> SearchEmployeesByKeyword(List<EmployeeDTO> employees, string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return employees;

            keyword = RemoveDiacritics(keyword.Trim()).ToLower();
            List<EmployeeDTO> filtered = new List<EmployeeDTO>();

            foreach (var emp in employees)
            {
                string fullName = RemoveDiacritics(emp.GetFullName() ?? "").ToLower();
                string phone = RemoveDiacritics(emp.GetPhoneNumber() ?? "").ToLower();
                string email = RemoveDiacritics(emp.GetEmail() ?? "").ToLower();
                string position = RemoveDiacritics(emp.GetPosition() ?? "").ToLower();
                string station = RemoveDiacritics(emp.GetStation()?.GetID() ?? "").ToLower();

                if (fullName.Contains(keyword) || phone.Contains(keyword) || email.Contains(keyword)
                    || position.Contains(keyword) || station.Contains(keyword))
                {
                    filtered.Add(emp);
                }
            }

            return filtered;
        }
        private string RemoveDiacritics(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            var normalized = text.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();

            foreach (var ch in normalized)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(ch);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(ch);
                }
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }

        public List<PackagingTypeDTO> SearchPackagingTypeByKeyword(List<PackagingTypeDTO> types, string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return types;

            keyword = RemoveDiacritics(keyword).ToLower();

            List<PackagingTypeDTO> filtered = new List<PackagingTypeDTO>();

            foreach (var type in types)
            {
                // Lấy tên hiển thị
                string name = type.GetTypeName() ?? "";

                bool match = RemoveDiacritics(name).ToLower().Contains(keyword);

                if (match)
                    filtered.Add(type);
            }

            return filtered;
        }

    }
}
