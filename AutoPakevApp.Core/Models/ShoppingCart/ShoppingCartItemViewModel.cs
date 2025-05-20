using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPakevApp.Core.Models.ShoppingCart
{
    public class ShoppingCartItemViewModel
    {
        public int ItemId { get; set; }

        public int PartId { get; set; }

        public string PartName  { get; set; } = string.Empty;

        public int Quantity { get; set; }   

        public decimal Price {  get; set; }

        public decimal TotalPrice => Price * Quantity;
    }
}
