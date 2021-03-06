﻿using eBookstore.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBookstore.data
{
    public sealed class ShoppingCart
    {
        public delegate void ShoppingCartUpdateEvent();
        public ShoppingCartUpdateEvent ShoppingCartUpdateEventHandlers;

        public List<ShoppingCartItem> Items { get; set; }

        public ShoppingCart()
        {
            this.Items = new List<ShoppingCartItem>();
        }

        public void AddBook(Book book, int amount = 1)
        {
            ShoppingCartItem shoppingCartItem = new ShoppingCartItem()
            {
                Book = book,
                BookTitle = book.Title,
                BookBasePriceText = book.BasePriceText,
                BookDiscountText = book.DiscountText,
                BookPriceText = book.PriceText,
                Amount = amount
            };

            this.Items.Add(shoppingCartItem);

            this.ShoppingCartUpdateEventHandlers();
        }

        public void RemoveBook(Book book)
        {
            var query = from ShoppingCartItem item in this.Items
                        where !item.Book.Matches(book.Title)
                        select item;

            this.Items = query.ToList();

            this.ShoppingCartUpdateEventHandlers();
        }

        public void RemoveAllBooks()
        {
            this.Items.Clear();

            this.ShoppingCartUpdateEventHandlers();
        }

        public int Count()
        {
            int sum = 0;
            this.Items.ForEach(item => sum += item.Amount);

            return sum;
        }

        public bool IsEmpty()
        {
            return this.Count() == 0;
        }

        public bool Contains(Book book)
        {
            var query = from ShoppingCartItem item in this.Items
                        where item.Book.Equals(book)
                        select item;

            return query.Count() > 0;
        }

        public double GetTotalCost()
        {
            double cost = 0;
            this.Items.ForEach(item => cost += (item.Book.Price * item.Amount));

            return cost;
        }

        public string GetTotalCostText()
        {
            return this.GetTotalCost().ToString("C", new CultureInfo("en-FR")); ;
        }
    }
}
