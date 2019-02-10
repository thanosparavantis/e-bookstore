using eBookstore.data;
using eBookstore.model;
using System;
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
            this.InitializeBookData();
            this.InitializeBooksLabel();
            this.InitializeUserLabel();
        }

        private void InitializeBooksLabel()
        {
            int amount = this._bookList.Data.Length;
            this.booksLabel.Text = $"{amount} Βιβλία";
        }

        private void InitializeUserLabel()
        {
            string username = this._user.Username;
            string role = this._user.Role;
            this.userLabel.Text = $"{username} ({role})";
        }

        private void InitializeBookData()
        {
            this.bookBindingSource.DataSource = this._bookList.Data;
            //foreach (Book book in this._bookList.Data)
            //{
            //    this.bookBindingSource.Add(book);
            //}
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = this.searchTextBox.Text;
            bookBindingSource.Filter = $"Title LIKE '{text}' OR Summary LIKE '{text}' OR Author LIKE '{text}'";
        }
    }
}
