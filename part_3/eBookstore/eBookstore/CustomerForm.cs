using eBookstore.data;
using eBookstore.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static eBookstore.data.ShoppingCart;

namespace eBookstore
{
    public partial class CustomerForm : Form
    {
        private BookList _bookList;
        private User _user;
        private ShoppingCart _shoppingCart;
        private BookDetailForm _bookDetailForm;
        private ShoppingCartForm _shoppingCartForm;

        public CustomerForm(User user)
        {
            InitializeComponent();

            this._user = user;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            this._bookList = new BookList();
            this._shoppingCart = new ShoppingCart();
            this._shoppingCart.ShoppingCardUpdateEventHandlers += this.OnShoppingCartUpdate;

            this.UpdateComponents();
        }

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
            string suffix = amount > 1 ? "Βιβλία" : "Βιβλίο";

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

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = this.searchTextBox.Text;
            this.SearchBooks(text);
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
            {
                return;
            }

            string bookTitle = (string)this.bookDataGridView[1, e.RowIndex].Value;
            Book book = this._bookList.GetBookByTitle(bookTitle);
            
            this._shoppingCartForm?.Close();

            this._bookDetailForm?.Close();
            this._bookDetailForm = new BookDetailForm(book, this._shoppingCart);
            this._bookDetailForm.Show();
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

        private void UpdateShoppingCartButton()
        {
            int itemAmount = this._shoppingCart.Count();
            string text = $"({itemAmount}) Καλάθι Αγορών";
            string textEmpty = "Καλάθι Αγορών";
            this.shoppingCartButton.Text = itemAmount > 0 ? text : textEmpty;
        }

        public void OnShoppingCartUpdate()
        {
            this.UpdateShoppingCartButton();
        }

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._bookDetailForm?.Close();
            this._shoppingCartForm?.Close();
        }
    }
}
