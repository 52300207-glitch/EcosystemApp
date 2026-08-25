using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.DTO
{
    public class OrderDTO
    {
        private string ID;
        private DateTime OrderDate;
        private decimal TotalAmount;
        private string TransactionType;
        private CustomerDTO Customer;
        private EmployeeDTO Employee;
        //thêm EmployeeDTO khi cần nhân viên giao hàng
        private string DeliveryEmployeeID;
        private string Status;
        private List<OrderDetailDTO> OrderDetails;
        private List<OrderPackagingDTO> OrderPackagings;
        private string DeliveryAddress;
        private string OrderAddress;

        //constructor

        public OrderDTO() { }

        //constructor
        public OrderDTO(DateTime orderDate, string transactionType, CustomerDTO customer, EmployeeDTO employee,
            string deliveryEmployeeID, string status, List<OrderDetailDTO> orderDetails, List<OrderPackagingDTO> orderPackagings, string deliveryAddress, string orderAddress)
        {
            OrderDate = orderDate;
            TransactionType = transactionType;
            Customer = customer;
            Employee = employee;
            DeliveryEmployeeID = deliveryEmployeeID;
            Status = status;
            OrderDetails = orderDetails;
            OrderPackagings = orderPackagings;
            TotalAmount = 0;
            DeliveryAddress = deliveryAddress;
            OrderAddress = orderAddress;
        }

        public OrderDTO (string id, DateTime orderDate, string transactionType, CustomerDTO customer,
            EmployeeDTO employee, string deliveryEmployeeID,  string status, List<OrderDetailDTO> orderDetails, List<OrderPackagingDTO> orderPackagings,
            decimal totalAmount, string deliveryAddress, string orderAddress)
        {
            ID = id;
            OrderDate = orderDate;
            TransactionType = transactionType;
            Customer = customer;
            Employee = employee;
            Status = status;
            OrderDetails = orderDetails;
            OrderPackagings = orderPackagings;
            TotalAmount = totalAmount;
            DeliveryEmployeeID = deliveryEmployeeID;
            DeliveryAddress = deliveryAddress;
            OrderAddress = orderAddress;

        }
        public OrderDTO(string id, DateTime orderDate, string transactionType, CustomerDTO customer,
            EmployeeDTO employee, string deliveryEmployeeID, string status, List<OrderDetailDTO> orderDetails, List<OrderPackagingDTO> orderPackagings, string deliveryAddress, string orderAddress)
        {
            ID = id;
            OrderDate = orderDate;
            TransactionType = transactionType;
            Customer = customer;
            Employee = employee;
            DeliveryEmployeeID = deliveryEmployeeID;
            Status = status;
            OrderDetails = orderDetails;
            OrderPackagings = orderPackagings;

            DeliveryAddress = deliveryAddress;
            OrderAddress = orderAddress;
        }





        //getter and setter
        public string GetID() { return ID; }

        public CustomerDTO GetCustomer() { return Customer; }

        public EmployeeDTO GetEmployee() { return Employee; }

        public decimal GetTotalAmount() { return TotalAmount; }

        public DateTime GetOrderDate() { return OrderDate; }

        public string GetStatus() { return Status; }

        public string GetDeliveryEmployeeID() { return DeliveryEmployeeID; }

        public string GetTransactionType() { return TransactionType; }

        public List<OrderDetailDTO> GetOrderDetails() { return OrderDetails; }

        public List<OrderPackagingDTO> GetOrderPackagings() { return OrderPackagings; }

        public string GetDeliveryAddress() { return DeliveryAddress; }
        public string GetOrderAddress() { return OrderAddress; }

        public void SetDeliveryAddress(string deliveryAddress) { DeliveryAddress = deliveryAddress; }

        public void SetOrderAddress(string orderAddress) { OrderAddress = orderAddress; }

        public void SetID(string id) { ID = id; }

        public void SetCustomer(CustomerDTO customer) { Customer = customer; }

        public void SetEmployee(EmployeeDTO employee) { Employee = employee; }

        public void SetTotalAmount(decimal totalAmount) { TotalAmount = totalAmount; }

        public void SetOrderDate(DateTime orderDate) { OrderDate = orderDate; }

        public void SetStatus(string status) { Status = status; }

        public void SetTransactionType(string transactionType) { TransactionType = transactionType; }

        public void SetDeliveryEmployeeID(string deliveryEmployeeID) { DeliveryEmployeeID = deliveryEmployeeID; }

        public void SetOrderDetails(List<OrderDetailDTO> orderDetails) { OrderDetails = orderDetails; }

        public void SetOrderPackaging(List<OrderPackagingDTO> orderPackagings) { OrderPackagings = orderPackagings; }

    }
}
