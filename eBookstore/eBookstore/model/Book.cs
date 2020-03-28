using System.Drawing;
using System.Globalization;

namespace eBookstore.model
{
    public sealed class Book
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

        public string BasePriceText
        {
            get
            {
                return this.BasePrice.ToString("C", new CultureInfo("en-FR"));
            }
        }

        public double Discount { get; set; }

        public string DiscountText
        {
            get
            {
                return this.Discount > 0 ? string.Format("{0}%", this.Discount) : "-";
            }
        }

        public double Price
        {
            get { return this.BasePrice - (this.BasePrice * (this.Discount / 100)); }
        }

        public string PriceText
        {
            get
            {
                return this.Price.ToString("C", new CultureInfo("en-FR"));
            }
        }

        public bool Matches(string text)
        {
            return this.StringsMatch(this.Title, text)
                || this.StringsMatch(this.Summary, text)
                || this.StringsMatch(this.Category, text)
                || this.StringsMatch(this.Author, text)
                || this.StringsMatch(this.Publisher, text);
        }

        private bool StringsMatch(string key, string value)
        {
            key = key.ToLower().Trim();
            value = value.ToLower().Trim();

            return key.Contains(value);
        }
    }
}
