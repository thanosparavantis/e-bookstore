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
        private CustomerForm customerForm;
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

                    usernameTextBox.Clear();
                    passwordTextBox.Clear();

                    this.Hide();
                    managerForm?.ShowDialog();
                    this.Show(); ;
                } else if (user.Role.Equals("customer"))
                {
                    if (customerForm == null)
                        customerForm = new CustomerForm();

                    usernameTextBox.Clear();
                    passwordTextBox.Clear();

                    this.Hide();
                    customerForm?.ShowDialog();
                    this.Show();
                }
                usernameLabel.ForeColor = SystemColors.ControlText;
                passwordLabel.ForeColor = SystemColors.ControlText;
            }
            else
            {
                usernameLabel.ForeColor = Color.Red;
                passwordLabel.ForeColor = Color.Red;
                MessageBox.Show("Usernane or password are wrong! Try again!");
            }
        }

        private void printerButton_Click(object sender, EventArgs e)
        {
            if (printerForm == null)
                printerForm = new PrinterForm();
            this.Hide();
            printerForm?.ShowDialog();
            this.Show();
        }

        private void coffeShopButton_Click(object sender, EventArgs e)
        {
            if (coffeeForm == null)
                coffeeForm = new CoffeeForm();
            this.Hide();
            coffeeForm?.ShowDialog();
            this.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("eBookStore - UI/UX 2018-19 \np16036 - Ioannidis Panagiotis \np16112 Paravantis Athanasios", "About");
        }
    }
}
