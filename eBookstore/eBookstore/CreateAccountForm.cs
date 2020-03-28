using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eBookstore.data;
using eBookstore.model;

namespace eBookstore
{
    public partial class CreateAccountForm : Form
    {
        private UserList userList;

        public CreateAccountForm(UserList userList)
        {
            InitializeComponent();
            this.userList = userList;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            int a;
            bool hasError = false;
            string msg = "";

            usernameLabel.ForeColor = passwordLabel.ForeColor = emailLabel.ForeColor = addressLabel.ForeColor =
                cityLabel.ForeColor = zipLabel.ForeColor = phoneLabel.ForeColor = SystemColors.ControlText;


            if (String.IsNullOrEmpty(usernameTextBox.Text))
            {
                usernameLabel.ForeColor = Color.Red;
                hasError = true;
                msg += "- Username is empty. \n";
            }

            if (String.IsNullOrEmpty(passwordTextBox.Text))
            {
                passwordLabel.ForeColor = Color.Red;
                hasError = true;
                msg += "- Password is empty. \n";
            }

            if (String.IsNullOrEmpty(emailTextBox.Text))
            {
                emailLabel.ForeColor = Color.Red;
                hasError = true;
                msg += "- Email is empty. \n";
            }

            if (!String.IsNullOrEmpty(emailTextBox.Text))
            {
                try
                {
                    MailAddress m = new MailAddress(emailTextBox.Text);
                }
                catch (FormatException)
                {
                    emailLabel.ForeColor = Color.Red;
                    hasError = true;
                    msg += "- Email format is not valid. \n";
                }
            }

            if (String.IsNullOrEmpty(addressTextBox.Text))
            {
                addressLabel.ForeColor = Color.Red;
                hasError = true;
                msg += "- Address is empty. \n";
            }

            if (String.IsNullOrEmpty(cityTextBox.Text))
            {
                cityLabel.ForeColor = Color.Red;
                hasError = true;
                msg += "- City is empty. \n";
            }

            if (String.IsNullOrEmpty(zipTextBox.Text))
            {
                zipLabel.ForeColor = Color.Red;
                hasError = true;
                msg += "- Zip is empty. \n";
            }

            if (!Int32.TryParse(zipTextBox.Text, out a))
            {
                zipLabel.ForeColor = Color.Red;
                hasError = true;
                msg += "- Zip should be number. \n";
            }

            if (String.IsNullOrEmpty(phoneTextBox.Text))
            {
                phoneLabel.ForeColor = Color.Red;
                hasError = true;
                msg += "- Phone is empty. \n";
            }

            if (!Int32.TryParse(phoneTextBox.Text, out a))
            {
                phoneLabel.ForeColor = Color.Red;
                hasError = true;
                msg += "- Phone should be number. \n";
            }

            if (hasError)
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            userList.addNewUser( usernameTextBox.Text, passwordTextBox.Text, emailTextBox.Text, cityTextBox.Text, zipTextBox.Text, addressTextBox.Text, phoneTextBox.Text);
            this.Hide();
        }

        public UserList getUpdatedUserList()
        {
            return userList;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void clearLabelStatusText(object sender, EventArgs e)
        {
            mouseHoverToolStripStatusLabel.Text = "";
        }

        private void createButton_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverToolStripStatusLabel.Text = "Create new user acount.";
        }

        private void cancelButton_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverToolStripStatusLabel.Text = "Cancel account creation.";
        }

        private void CreateAccountForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E && e.Control)
                this.Hide();

            if (e.KeyCode == Keys.F1)
                System.Windows.Forms.Help.ShowHelp(this, "./help_files/eBookStore_create_new_user.chm");
        }
    }
}
