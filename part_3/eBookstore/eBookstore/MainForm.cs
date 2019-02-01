using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eBookstore.controller;
using eBookstore.data;
using eBookstore.model;

namespace eBookstore
{
    public partial class MainForm : Form
    {

        UserList userList = new UserList();
        private PrinterForm printerForm;
        private ManagerForm managerForm;
        private CoffeeForm coffeeForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            User user = LoginController.UserLogin(usernameTextBox.Text, passwordTextBox.Text, userList);

            if (user != null)
            {
                if(user.Role.Equals("administrator"))
                {
                    if (managerForm == null)
                        managerForm = new ManagerForm();
                    managerForm?.Show();
                } else if (user.Role.Equals("customer"))
                {
                    CustomerForm customerForm = new CustomerForm();
                    customerForm.Show();
                }
            }
            else
            {
                //Error
            }
        }

        private void printerButton_Click(object sender, EventArgs e)
        {
            if (printerForm == null)
                printerForm = new PrinterForm();
            printerForm?.Show();
        }

        private void coffeShopButton_Click(object sender, EventArgs e)
        {
            if (coffeeForm == null)
                coffeeForm = new CoffeeForm();
            coffeeForm?.Show();
        }
    }
}
