﻿using eBookstore.data;
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
        }
    }
}
