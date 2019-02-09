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

        public String Title { get; set; }

        public String Summary { get; set; }

        public String Author { get; set; }

        public String Publisher { get; set; }

        public DateTime PublishedDate { get; set; }

        public double BasePrice { get; set; }

        public double Discount { get; set; }

        public double Price
        {
            get { return this.BasePrice - (this.BasePrice * (this.Discount / 100)); }
        }
    }
}
