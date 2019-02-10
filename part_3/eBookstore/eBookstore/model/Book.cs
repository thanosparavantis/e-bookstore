using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBookstore.model
{
    class Book
    {
        public Image Cover { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string Category { get; set; }

        public string Author { get; set; }

        public int Pages { get; set; }

        public string Publisher { get; set; }

        public int YearPublished { get; set; }

        public string ISBN { get; set; }

        public double BasePrice { get; set; }

        public double Discount { get; set; }

        public double Price
        {
            get { return this.BasePrice - (this.BasePrice * (this.Discount / 100)); }
        }
    }
}
