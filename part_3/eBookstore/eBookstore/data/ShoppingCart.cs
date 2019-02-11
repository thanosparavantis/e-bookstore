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
        public delegate void ShoppingCartUpdateEvent();
        private ShoppingCartUpdateEvent _shoppingCartUpdateEvent;

        public List<ShoppingCartItem> Items { get; set; }

        public ShoppingCart(ShoppingCartUpdateEvent shoppingCartUpdateEvent)
        {
            this._shoppingCartUpdateEvent = shoppingCartUpdateEvent;
            this.Items = new List<ShoppingCartItem>();
        }

        public void AddBook(Book book, int amount = 1)
        {
            ShoppingCartItem shoppingCartItem = new ShoppingCartItem()
            {
                Book = book,
                Amount = amount
            };

            this.Items.Add(shoppingCartItem);

            this._shoppingCartUpdateEvent();
        }

        public void RemoveBook(Book book)
        {
            var query = from ShoppingCartItem item in this.Items
                        where !item.Book.Equals(book)
                        select item;

            this.Items = query.ToList();

            this._shoppingCartUpdateEvent();
        }

        public int Count()
        {
            return this.Items.Count();
        }

        public bool Contains(Book book)
        {
            var query = from ShoppingCartItem item in this.Items
                        where item.Book.Equals(book)
                        select item;

            return query.Count() > 0;
        }
    }
}
