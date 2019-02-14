using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBookstore.model
{
    public sealed class ShoppingCartItem
    {
        public Book Book { get; set; }

        public string BookTitle { get; set; }

        public string BookBasePriceText { get; set; }

        public string BookDiscountText { get; set; }

        public string BookPriceText { get; set; }

        public int Amount { get; set; }
    }
}
