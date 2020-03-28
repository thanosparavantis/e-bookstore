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
        private CreateAccountForm createAccountForm;

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
                        customerForm = new CustomerForm(user);

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
                MessageBox.Show("Usernane or password are wrong! Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            MessageBox.Show("eBookStore - UI/UX 2018-19 \np16036 - Ioannidis Panagiotis \np16112 - Paravantis Athanasios", "About");
        }

        private void clearToolStripLabel(object sender, EventArgs e)
        {
            mouseHoverToolStripStatusLabel.Text = "";
        }

        private void loginButton_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverToolStripStatusLabel.Text = "Type your username/password and login!";
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverToolStripStatusLabel.Text = "Exit the application!";
        }

        private void coffeShopButton_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverToolStripStatusLabel.Text = "Click to order your coffee and more!!!";
        }

        private void printerButton_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverToolStripStatusLabel.Text = "Click to print/scan your documents or books!";
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E && e.Control)
                Application.Exit();

            if (e.KeyCode == Keys.F1)
                helpToolStripMenuItem.PerformClick();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newUserLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (createAccountForm == null)
                createAccountForm = new CreateAccountForm(userList);

            usernameTextBox.Clear();
            passwordTextBox.Clear();

            this.Hide();
            createAccountForm?.ShowDialog();
            userList = createAccountForm.getUpdatedUserList();
            this.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, "./help_files/eBookStore_main_form.chm");
        }
    }
}
