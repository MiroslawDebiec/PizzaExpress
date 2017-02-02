using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaExpress.DTO;

namespace PizzaExpress.Domain
{
    public class PizzaPriceManager
    {
        public static decimal CalculateCost(DTO.OrderDTO order)
        {
            decimal cost = 0.0M;
            var prices = getPizzaPrices();
            cost += calculateSize(order, prices);
            cost += calculateCrust(order, prices);
            cost += CalculateToppings(order, prices);

            return cost;
        }

        private static decimal CalculateToppings(OrderDTO order, PizzaPriceDTO prices)
        {
            decimal cost = 0.0M;
            cost += (order.Sausage) ? prices.SausageCost : 0M;
            cost += (order.Onions) ? prices.OnionsCost : 0M;
            cost += (order.GreenPeppers) ? prices.GreenPepperCost : 0M;
            cost += (order.Pepperoni) ? prices.PepperoniCost : 0M;
            return cost;
        }

        private static decimal calculateCrust(OrderDTO order, PizzaPriceDTO prices)
        {
            decimal cost = 0.0M;
            if (order.Crust == DTO.Enums.CrustType.Regular) cost = prices.RegularCrustCost;
            else if (order.Crust == DTO.Enums.CrustType.Thick) cost = prices.ThickCrustCost;
            else cost = prices.ThinCrustCost;
            return cost;
        }

        private static decimal calculateSize(OrderDTO order, PizzaPriceDTO prices)
        {
            decimal cost = 0.0M;
            switch (order.Size)
            {
                case DTO.Enums.SizeType.Small:
                    cost = prices.SmallSizeCost;
                    break;
                case DTO.Enums.SizeType.Medium:
                    cost = prices.MediumSizeCost;
                    break;
                case DTO.Enums.SizeType.Large:
                    cost = prices.LargeSizeCost;
                    break;
                default:
                    break;
            }
            return cost;
        }

        private static DTO.PizzaPriceDTO getPizzaPrices()
        {
            var prices = Persistance.PizzaPriceRepository.GetPizzaPrice();
            return prices;
        }
    }
}
