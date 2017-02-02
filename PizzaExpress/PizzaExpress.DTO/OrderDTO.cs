using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaExpress.DTO
{
    public class OrderDTO
    {
        public System.Guid OrderId { get; set; }
        public PizzaExpress.DTO.Enums.SizeType Size { get; set; }
        public PizzaExpress.DTO.Enums.CrustType Crust { get; set; }
        public bool Sausage { get; set; }
        public bool Pepperoni { get; set; }
        public bool Onions { get; set; }
        public bool GreenPeppers { get; set; }
        public decimal TotalCost { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public PizzaExpress.DTO.Enums.PaymentType PaymentType { get; set; }
        public bool Completed { get; set; }
    }
}
