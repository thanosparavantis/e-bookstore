using eBookstore.data;
using eBookstore.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace eBookstore
{
    public partial class CustomerForm : Form
    {
        // --------------------------------------------
        // Properties
        // --------------------------------------------

        private BookList _bookList;
        private User _user;
        private ShoppingCart _shoppingCart;
        private BookDetailForm _bookDetailForm;
        private ShoppingCartForm _shoppingCartForm;

        // --------------------------------------------
        // Initialization
        // --------------------------------------------

        public CustomerForm(User user)
        {
            InitializeComponent();

            this._user = user;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            this._bookList = new BookList();
            this._shoppingCart = new ShoppingCart();
            this._shoppingCart.ShoppingCartUpdateEventHandlers += this.OnShoppingCartUpdate;

            this.UpdateComponents();
        }

        // --------------------------------------------
        // Component Updates
        // --------------------------------------------

        private void UpdateComponents()
        {
            this.UpdateBookData();
            this.UpdateBookLabels();
            this.UpdateUserLabel();
            this.UpdateSearchBox();
            this.UpdateShoppingCartButton();
        }

        private void UpdateBookData()
        {
            bookBindingSource.DataSource = this._bookList.Data;
        }

        private void UpdateBookLabels()
        {
            int amount = this.bookBindingSource.Count;
            string suffix = amount > 1 ? "Books" : "Book";

            string text = $"{amount} {suffix}";
            this.booksLabel.Text = text;
            this.booksToolStripStatusLabel.Text = text;
        }

        private void UpdateBookLabelsForTitle(string bookTitle)
        {
            this.booksLabel.Text = bookTitle;
            this.booksToolStripStatusLabel.Text = bookTitle;
        }

        private void UpdateUserLabel()
        {
            string username = this._user.Username;
            string role = this._user.Role;
            this.userLabel.Text = $"{username} ({role})";
        }

        private void UpdateSearchBox()
        {
            this.searchTextBox.AutoCompleteCustomSource = this._bookList.AutoCompleteTerms;
        }

        // --------------------------------------------
        // Event Listeners
        // --------------------------------------------

        public void OnShoppingCartUpdate()
        {
            this.UpdateShoppingCartButton();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = this.searchTextBox.Text;
            this.SearchBooks(text);
        }

        private void bookDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                this.UpdateBookLabels();
            }
            else
            {
                string bookTitle = (string)this.bookDataGridView[1, e.RowIndex].Value;
                this.UpdateBookLabelsForTitle(bookTitle);
            }
        }

        private void bookDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            object value = this.bookDataGridView[e.ColumnIndex, e.RowIndex].Value;

            if (value is string && (string)value == "Details")
                return;

            Book book = (Book)this.bookDataGridView.Rows[e.RowIndex].DataBoundItem;
            this.ClickBook(book);
        }

        private void bookDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
                return;

            object value = this.bookDataGridView[e.ColumnIndex, e.RowIndex].Value;

            if (value is string && (string)value == "Details")
            {
                Book book = (Book)this.bookDataGridView.Rows[e.RowIndex].DataBoundItem;
                this.ClickBook(book);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void shoppingCartButton_Click(object sender, EventArgs e)
        {
            this._bookDetailForm?.Close();

            this._shoppingCartForm?.Close();
            this._shoppingCartForm = new ShoppingCartForm(this._shoppingCart, this._user);
            this._shoppingCartForm.Show();
        }

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._bookDetailForm?.Close();
            this._shoppingCartForm?.Close();
        }

        private void CustomerForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.E)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter && this.bookDataGridView.SelectedRows.Count > 0)
            {
                e.Handled = true;

                Book book = (Book) this.bookDataGridView.SelectedRows[0].DataBoundItem;
                this.ClickBook(book);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("eBookStore - UI/UX 2018-19 \np16036 - Ioannidis Panagiotis \np16112 - Paravantis Athanasios", "About");
        }

        // --------------------------------------------
        // Methods
        // --------------------------------------------

        private void UpdateShoppingCartButton()
        {
            int itemAmount = this._shoppingCart.Count();
            string text = $"({itemAmount}) Shopping Cart";
            string textEmpty = "Shopping Cart";
            this.shoppingCartButton.Text = itemAmount > 0 ? text : textEmpty;
        }

        private void SearchBooks(string text)
        {
            var query = from Book book in this._bookList.Data
                        where book.Matches(text)
                        select book;

            List<Book> result = query.ToList();

            this.bookBindingSource.DataSource = query.Count() > 0 ? result : null;
            this.UpdateBookLabels();
        }

        private void ClickBook(Book book)
        {
            this._shoppingCartForm?.Close();

            this._bookDetailForm?.Close();
            this._bookDetailForm = new BookDetailForm(book, this._shoppingCart);
            this._bookDetailForm.Show();
        }
    }
}
