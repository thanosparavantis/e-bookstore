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
                    ManagerForm managerForm = new ManagerForm();
                    managerForm.Show();
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
    }
}
