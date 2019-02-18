using eBookstore.data;
using eBookstore.model;
using System;
using System.Windows.Forms;

namespace eBookstore
{
    public partial class ShoppingCartForm : Form
    {
        private ShoppingCart _shoppingCart;
        private MakeOrderForm _makeOrderForm;
        private User _user;

        public ShoppingCartForm(ShoppingCart shoppingCart, User user)
        {
            InitializeComponent();

            this._shoppingCart = shoppingCart;
            this._user = user;
        }

        private void ShoppingCartForm_Load(object sender, EventArgs e)
        {
            this._shoppingCart.ShoppingCardUpdateEventHandlers += this.OnShoppingCardUpdate;
            this.UpdateComponents();
        }

        private void UpdateComponents()
        {
            this.UpdateShoppingCartItemData();
            this.UpdateItemsInCartLabel();
            this.UpdateTotalCostLabel();
            this.UpdateResetButton();
            this.UpdatePurchaseButton();
        }

        private void UpdateShoppingCartItemData()
        {
            this.shoppingCartItemBindingSource.DataSource = this._shoppingCart.Items;
        }

        private void UpdateItemsInCartLabel()
        {
            int count = this._shoppingCart.Count();
            string text = count > 1 ? $"{count} books selected" : $"{count} book selected";
            this.itemsInCartLabel.Text = text;
        }

        private void UpdateTotalCostLabel()
        {
            this.totalCostLabel.Text = this._shoppingCart.GetTotalCostText();
        }

        private void UpdateResetButton()
        {
            this.resetButton.Enabled = !this._shoppingCart.IsEmpty();
        }

        private void UpdatePurchaseButton()
        {
            this.purchaseButton.Enabled = !this._shoppingCart.IsEmpty();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void OnShoppingCardUpdate()
        {
            this.UpdateComponents();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            int count = this._shoppingCart.Count();
            string title = count > 1 ? $"Remove {count} books" : $"Remove {count} book";

            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want remove all items from your shopping cart?",
                title,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Cancel)
                return;

            this.shoppingCartItemBindingSource.Clear();
            this._shoppingCart.RemoveAllBooks();
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            _makeOrderForm?.Close();
            _makeOrderForm = new MakeOrderForm(this._shoppingCart, this._user);
            _makeOrderForm.Show();
        }

        private void shoppingCartItemDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex > -1)
            {
                DataGridViewCell cell = this.shoppingCartItemDataGridView[e.ColumnIndex, e.RowIndex];

                this._shoppingCart.ShoppingCardUpdateEventHandlers();
            }
        }

        private void ShoppingCartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._shoppingCart.ShoppingCardUpdateEventHandlers -= this.OnShoppingCardUpdate;
            _makeOrderForm?.Close();
        }
        
        private void shoppingCartItemDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            ShoppingCartItem item = (ShoppingCartItem) e.Row.DataBoundItem;

            this.RemoveBook(item.Book);

            e.Cancel = true;
        }

        private void shoppingCartItemDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            object value = this.shoppingCartItemDataGridView[e.ColumnIndex, e.RowIndex].Value;

            if (value is string && (string)value == "Remove")
            {
                ShoppingCartItem item = (ShoppingCartItem)this.shoppingCartItemDataGridView.Rows[e.RowIndex].DataBoundItem;

                this.RemoveBook(item.Book);
            }
        }

        private void RemoveBook(Book book)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to remove this book from your shopping cart?",
                book.Title,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Cancel)
                return;

            this._shoppingCart.RemoveBook(book);
        }
    }
}
