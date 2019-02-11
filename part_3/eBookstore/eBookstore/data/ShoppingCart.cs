using eBookstore.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBookstore.data
{
    public sealed class ShoppingCart
    {
        private List<ShoppingCartItem> _items;

        public ShoppingCart()
        {
            this._items = new List<ShoppingCartItem>();
        }

        public void AddBook(Book book, int amount)
        {
            ShoppingCartItem shoppingCartItem = new ShoppingCartItem()
            {
                Book = book,
                Amount = amount
            };

            this._items.Add(shoppingCartItem);
        }
    }
}
