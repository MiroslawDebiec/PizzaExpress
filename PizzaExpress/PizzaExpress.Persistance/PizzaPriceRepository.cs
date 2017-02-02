using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaExpress.Persistance
{
    public class PizzaPriceRepository
    {
        public static DTO.PizzaPriceDTO GetPizzaPrice()
        {
            var db = new PizzaExpressDbEntities();
            var prices = db.PizzaPrices.First();
            var dto = convertToDTO(prices);
            return dto; 
        } 


        private static DTO.PizzaPriceDTO convertToDTO(PizzaPrice pizzaPrice)
        {
            var dto = new DTO.PizzaPriceDTO();

            dto.SmallSizeCost = pizzaPrice.SmallSizeCost;
            dto.MediumSizeCost = pizzaPrice.MediumSizeCost;
            dto.LargeSizeCost = pizzaPrice.LargeSizeCost;
            dto.RegularCrustCost = pizzaPrice.RegularCrustCost;
            dto.ThinCrustCost = pizzaPrice.ThinCrustCost;
            dto.ThickCrustCost = pizzaPrice.ThickCrustCost;
            dto.OnionsCost = pizzaPrice.OnionsCost;
            dto.PepperoniCost = pizzaPrice.PepperoniCost;
            dto.SausageCost = pizzaPrice.SausageCost;
            dto.GreenPepperCost = pizzaPrice.GreenPepperCost;

            return dto;
        }
    }
}
