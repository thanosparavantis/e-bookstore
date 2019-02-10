using eBookstore.data;
using eBookstore.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBookstore
{
    public partial class CustomerForm : Form
    {
        private BookList _bookList;
        private User _user;

        public CustomerForm(User user)
        {
            this._user = user;

            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            this._bookList = new BookList();
            this.UpdateBookData();
            this.UpdateBooksLabels();
            this.UpdateUserLabel();
            this.SetupSearchBox();
        }

        private void UpdateBookData()
        {
            bookBindingSource.DataSource = this._bookList.Data;
        }

        private void UpdateBooksLabels()
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

        private void SetupSearchBox()
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

            this.bookBindingSource.DataSource = query.Count() > 0 ? query : null;
            this.UpdateBooksLabels();
        }

        private void bookDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                this.UpdateBooksLabels();
            }
            else
            {
                string bookTitle = (string)this.bookDataGridView[1, e.RowIndex].Value;
                this.UpdateBookLabelsForTitle(bookTitle);
            }
        }
    }
}
