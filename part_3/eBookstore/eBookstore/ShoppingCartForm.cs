using eBookstore.data;
using System;
using System.Windows.Forms;

namespace eBookstore
{
    public partial class ShoppingCartForm : Form
    {
        private ShoppingCart _shoppingCart;

        public ShoppingCartForm(ShoppingCart shoppingCart)
        {
            this._shoppingCart = shoppingCart;

            InitializeComponent();
        }

        private void ShoppingCartForm_Load(object sender, EventArgs e)
        {
            this.UpdateComponents();
        }

        private void UpdateComponents()
        {
            this.UpdateShoppingCartItemData();
            this.UpdateItemsInCartLabel();
            this.UpdateTotalCostLabel();
            this.UpdateResetButton();
        }

        private void UpdateShoppingCartItemData()
        {
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

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this._shoppingCart.RemoveAllBooks();
            this.shoppingCartItemBindingSource.Clear();

            this.UpdateComponents();

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

                this._shoppingCart.CallShoppingCartUpdateEvent();
                this.UpdateComponents();
            }
        }
    }
}
