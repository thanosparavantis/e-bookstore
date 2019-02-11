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

        public int Amount { get; set; }
    }
}
