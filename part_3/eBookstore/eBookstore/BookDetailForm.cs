using eBookstore.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBookstore
{
    public partial class BookDetailForm : Form
    {
        private Book _book;

        public BookDetailForm(Book book)
        {
            this._book = book;

            InitializeComponent();
        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            this.Text = this._book.Title;
            this.coverPictureBox.Image = this._book.Cover;
            this.titleLabel.Text = this._book.Title;
            this.summaryLabel.Text = this._book.Summary;
            this.authorLabel.Text = this._book.Author;
            this.publisherLabel.Text = this._book.Publisher;
            this.ISBNLabel.Text = this._book.ISBN;
            this.categoryLabel.Text = this._book.Category;
            this.pagesLabel.Text = this._book.Pages.ToString();
            this.yearPublishedLabel.Text = this._book.YearPublished.ToString();
            this.basePriceLabel.Text = this._book.BasePrice.ToString();
            this.discountLabel.Text = this._book.Discount.ToString();
            this.priceLabel.Text = this._book.Price.ToString();
        }

        private void BookDetailForm_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Now");
        }

        private void BookDetailForm_Deactivate(object sender, EventArgs e)
        {
            MessageBox.Show("Now");

        }
    }
}
