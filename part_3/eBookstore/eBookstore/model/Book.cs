using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBookstore.model
{
    class Book
    {
        public String Title
        {
            get;
        }

        public String Summary
        {
            get;
        }

        public String Author
        {
            get;
        }

        public String Publisher
        {
            get;
        }

        public DateTime PublishedDate
        {
            get;
        }

        public double BasePrice
        {
            get;
        }

        public double Discount
        {
            get;
        }

        public double Price
        {
            get { return this.BasePrice - (this.BasePrice * (this.Discount / 100)); }
        }

        public Book(String title, String summary, String author, String publisher,
            DateTime publishedDate, double basePrice, double discount)
        {
            this.Title = title;
            this.Summary = summary;
            this.Author = author;
            this.Publisher = publisher;
            this.PublishedDate = publishedDate;
            this.BasePrice = basePrice;
            this.Discount = discount;
        }
    }
}
