using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaExpress.Persistance
{
    public class OrderRepository
    {
        public static void CreateOrder(DTO.OrderDTO orderDTO)
        {
            var db = new PizzaExpressDbEntities();

            var order = convertToEntity(orderDTO);

            db.Orders.Add(order);
            db.SaveChanges();
        }

        private static Order convertToEntity(DTO.OrderDTO orderDTO)
        {
            var order = new Order();
            order.OrderId = orderDTO.OrderId;
            order.Size = orderDTO.Size;
            order.Crust = orderDTO.Crust;
            order.PaymentType = orderDTO.PaymentType;
            order.Pepperoni = orderDTO.Pepperoni;
            order.Onions = orderDTO.Onions;
            order.GreenPeppers = orderDTO.GreenPeppers;
            order.Sausage = orderDTO.Sausage;
            order.Name = orderDTO.Name;
            order.Address = orderDTO.Address;
            order.PostCode = orderDTO.PostCode;
            order.Phone = orderDTO.Phone;
            order.Email = orderDTO.Email;
            order.TotalCost = orderDTO.TotalCost;

            return order;
        }

        public static void CompleteOrder(Guid orderId)
        {
            var db = new PizzaExpressDbEntities();
            var order = db.Orders.FirstOrDefault(p => p.OrderId == orderId);
            order.Completed = true;
            db.SaveChanges();
        }

        public static List<DTO.OrderDTO> GetOrders()
        {
            var db = new PizzaExpressDbEntities();
            var orders = db.Orders.Where(p => p.Completed == false).ToList();
            var ordersDTO = convertToDTO(orders);
            return ordersDTO;
        }

        private static List<DTO.OrderDTO> convertToDTO(List<Order> orders)
        {
            var ordersDTO = new List<DTO.OrderDTO>();
            foreach (var order in orders)
            {
                var orderDTO = new DTO.OrderDTO();
                orderDTO.OrderId = order.OrderId;
                orderDTO.Size = order.Size;
                orderDTO.Crust = order.Crust;
                orderDTO.Sausage = order.Sausage;
                orderDTO.Onions = order.Onions;
                orderDTO.GreenPeppers = order.GreenPeppers;
                orderDTO.Pepperoni = order.Pepperoni;
                orderDTO.Name = order.Name;
                orderDTO.Address = order.Address;
                orderDTO.PostCode = order.PostCode;
                orderDTO.Phone = order.Phone;
                orderDTO.Email = order.Email;
                orderDTO.PaymentType = order.PaymentType;
                orderDTO.TotalCost = order.TotalCost;
                orderDTO.Completed = order.Completed;

                ordersDTO.Add(orderDTO);
            }
            return ordersDTO;
        }
    }
}
