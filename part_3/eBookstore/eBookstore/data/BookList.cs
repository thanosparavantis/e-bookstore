using eBookstore.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBookstore.data
{
    class BookList
    {
        public Book[] Data { get; } =
        {
            new Book(
                title:          "Book Title 1",
                summary:        "Book Summary 1",
                author:         "Book Author 1",
                publisher:      "Book Publisher 1",
                publishedDate:  DateTime.Now,
                basePrice:      64.0,
                discount:       10.0
            ),
            new Book(
                title:          "Book Title 2",
                summary:        "Book Summary 2",
                author:         "Book Author 2",
                publisher:      "Book Publisher 2",
                publishedDate:  DateTime.Now,
                basePrice:      32.0,
                discount:       10.0
            ),
        };
    }
}
