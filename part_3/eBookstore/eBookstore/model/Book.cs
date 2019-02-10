using System.Drawing;

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

        public bool Matches(string text)
        {
            return this.StringsMatch(this.Title, text)
                || this.StringsMatch(this.Summary, text)
                || this.StringsMatch(this.Category, text)
                || this.StringsMatch(this.Author, text)
                || this.StringsMatch(this.Publisher, text);
        }

        public bool StringsMatch(string key, string value)
        {
            key = key.ToLower().Trim();
            value = value.ToLower().Trim();

            return key.Contains(value);
        }
    }
}
