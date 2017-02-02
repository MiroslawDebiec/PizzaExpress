using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaExpress.Domain
{
    public class OrderManager
    {
        public static void CreateOrder(DTO.OrderDTO orderDTO)
        {
            if (orderDTO.Name.Trim().Length == 0) throw new Exception("Name is required!");
            if (orderDTO.Address.Trim().Length == 0) throw new Exception("Address is required!");
            if (orderDTO.PostCode.Trim().Length == 0) throw new Exception("Postcode is required!");
            if (orderDTO.Phone.Trim().Length == 0) throw new Exception("Phone is required!");
            if (orderDTO.Email.Trim().Length == 0) throw new Exception("Email is required!");

            orderDTO.OrderId = Guid.NewGuid();
            orderDTO.TotalCost = PizzaPriceManager.CalculateCost(orderDTO);
            Persistance.OrderRepository.CreateOrder(orderDTO);
        }

        public static object GetOrders()
        {
            return Persistance.OrderRepository.GetOrders();
        }

        public static void CompleteOrder(Guid orderId)
        {
            Persistance.OrderRepository.CompleteOrder(orderId);
        }
    }
}
