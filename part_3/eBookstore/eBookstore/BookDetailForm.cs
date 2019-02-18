using eBookstore.data;
using eBookstore.model;
using System;
using System.Drawing;
using System.Windows.Forms;
using static eBookstore.CustomerForm;

namespace eBookstore
{
    public partial class BookDetailForm : Form
    {
        // --------------------------------------------
        // Properties
        // --------------------------------------------

        private Book _book;
        private ShoppingCart _shoppingCart;

        // --------------------------------------------
        // Initialization
        // --------------------------------------------

        public BookDetailForm(Book book, ShoppingCart shoppingCart)
        {
            InitializeComponent();

            this._book = book;
            this._shoppingCart = shoppingCart;
        }

        private void BookDetailForm_Load(object sender, EventArgs e)
        {
            this.UpdateForm();
            this.UpdateCoverPictureBox();
            this.UpdateTitleLabel();
            this.UpdateSummaryLabel();
            this.UpdateAuthorLabel();
            this.UpdatePublisherLabel();
            this.UpdateISBNLabel();
            this.UpdateCategoryLabel();
            this.UpdatePagesLabel();
            this.UpdateYearPublishedLabel();
            this.UpdateBasePriceLabel();
            this.UpdateDiscountLabel();
            this.UpdatePriceLabel();
            this.UpdateShoppingCartButton();
        }

        // --------------------------------------------
        // Component Updates
        // --------------------------------------------

        private void UpdateForm()
        {
            this.Text = this._book.Title;
        }

        private void UpdateCoverPictureBox()
        {
            this.coverPictureBox.Image = this._book.Cover;
        }

        private void UpdateTitleLabel()
        {
            this.titleLabel.Text = this._book.Title;
        }

        private void UpdateSummaryLabel()
        {
            this.summaryLabel.Text = this._book.Summary;
        }

        private void UpdateAuthorLabel()
        {
            this.authorLabel.Text = this._book.Author;
        }

        private void UpdatePublisherLabel()
        {
            this.publisherLabel.Text = this._book.Publisher;
        }

        private void UpdateISBNLabel()
        {
            this.ISBNLabel.Text = this._book.ISBN;
        }

        private void UpdateCategoryLabel()
        {
            this.categoryLabel.Text = this._book.Category;
        }

        private void UpdatePagesLabel()
        {
            this.pagesLabel.Text = this._book.Pages.ToString();
        }

        private void UpdateYearPublishedLabel()
        {
            this.yearPublishedLabel.Text = this._book.YearPublished.ToString();
        }

        private void UpdateBasePriceLabel()
        {
            this.basePriceLabel.Text = this._book.BasePriceText;

            if (this._book.Discount > 0)
            {
                this.basePriceLabel.Font = new Font(this.basePriceLabel.Font, FontStyle.Strikeout);
            }
        }

        private void UpdateDiscountLabel()
        {
            this.discountLabel.Text = this._book.DiscountText;

            if (this._book.Discount > 0)
            {
                this.discountLabel.Font = new Font(this.discountLabel.Font, FontStyle.Bold);
                this.discountLabel.ForeColor = Color.Firebrick;
            }
        }

        private void UpdatePriceLabel()
        {
            this.priceLabel.Text = this._book.PriceText;

        }

        private void UpdateShoppingCartButton()
        {
            if (this._shoppingCart.Contains(this._book))
            {
                this.shoppingCartButton.Text = "Remove from shopping cart";
                this.shoppingCartButton.ForeColor = Color.Firebrick;
            }
            else
            {
                this.shoppingCartButton.Text = "Add to shopping cart";
                this.shoppingCartButton.ForeColor = Color.DarkGreen;
            }
        }

        // --------------------------------------------
        // Event Listeners
        // --------------------------------------------

        private void shoppingCartButton_Click(object sender, EventArgs e)
        {
            if (this._shoppingCart.Contains(this._book))
            {
                this._shoppingCart.RemoveBook(this._book);

                MessageBox.Show(
                    "The book has been removed from your shopping cart.",
                    this._book.Title,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                this._shoppingCart.AddBook(this._book);

                MessageBox.Show(
                    "The book has been added to your shopping cart.",
                    this._book.Title,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            this.UpdateShoppingCartButton();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookDetailForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.E) this.Close();
        }
    }
}
