using eBookstore.data;
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
            this.UpdateShoppingCartItemData();
            this.UpdateItemsInCartLabel();
            this.UpdateTotalCostLabel();
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
    }
}
