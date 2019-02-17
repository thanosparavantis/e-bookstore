using eBookstore.data;
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
    public partial class MakeOrderForm : Form
    {
        private ShoppingCart _shoppingCart;
        private User _user;
        private ShoppingCartForm _shoppingCartForm;

        public MakeOrderForm(ShoppingCart shoppingCart, User user)
        {
            InitializeComponent();

            this._shoppingCart = shoppingCart;
            this._user = user;
        }

        private void MakeOrderForm_Load(object sender, EventArgs e)
        {
            this.UpdateComponents();
        }

        private void UpdateComponents()
        {
            this.UpdateUsernameLabel();
            this.UpdateEmailLabel();
            this.UpdateAddressLabel();
            this.UpdateZipLabel();
            this.UpdateCityLabel();
            this.UpdatePhoneLabel();
        }

        private void UpdateUsernameLabel()
        {
            this.usernameLabel.Text = this._user.Username;
        }

        private void UpdateEmailLabel()
        {
            this.emailLabel.Text = this._user.Email;
        }

        private void UpdateAddressLabel()
        {
            this.addressLabel.Text = this._user.Address;
        }

        private void UpdateZipLabel()
        {
            this.zipLabel.Text = this._user.Zip;
        }

        private void UpdateCityLabel()
        {
            this.cityLabel.Text = this._user.City;
        }

        private void UpdatePhoneLabel()
        {
            this.phoneLabel.Text = this._user.Phone;
        }

        private void MakeOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
