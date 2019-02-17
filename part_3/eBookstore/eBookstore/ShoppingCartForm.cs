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
            this.shoppingCartItemBindingSource.DataSource = null;
            this.shoppingCartItemBindingSource.DataSource = this._shoppingCart.Items;
        }

        private void UpdateItemsInCartLabel()
        {
            int count = this._shoppingCart.Count();
            this.itemsInCartLabel.Text = $"{count} βιβλία προς παραγγελία";
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
            this._shoppingCart.RemoveAllBooks();
            
            MessageBox.Show(
                "Το καλάθι αγορών σας έχει αδιάσει.",
                "Καλάθι Αγορών",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void shoppingCartItemDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex > -1)
            {
                DataGridViewCell cell = this.shoppingCartItemDataGridView[e.ColumnIndex, e.RowIndex];

                this._shoppingCart.ShoppingCardUpdateEventHandlers();
            }
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            _makeOrderForm?.Close();
            _makeOrderForm = new MakeOrderForm(this._shoppingCart, this._user);
            _makeOrderForm.Show();
        }

        private void ShoppingCartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._shoppingCart.ShoppingCardUpdateEventHandlers -= this.OnShoppingCardUpdate;
            _makeOrderForm?.Close();
        }
        
        private void shoppingCartItemDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            ShoppingCartItem item = (ShoppingCartItem) e.Row.DataBoundItem;
            this._shoppingCart.RemoveBook(item.Book);

            e.Cancel = true;
        }
    }
}
