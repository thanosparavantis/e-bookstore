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
    public partial class PrinterForm : Form
    {
        private static bool powerStatus = false;

        public PrinterForm()
        {
            InitializeComponent();

            label1.Visible = false;
            numberOfCopiesLabel.Visible = false;
            modeGroupBox.Visible = false;
            saveGroupBox.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(numberOfCopiesLabel.Text);
            if (num < 100)
            {
                num++;
                numberOfCopiesLabel.Text = num.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(numberOfCopiesLabel.Text);
            if (num > 1)
            {
                num--;
                numberOfCopiesLabel.Text = num.ToString();
            }    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string msg = (printOption.Checked) ? "copies" : "scanned pages";    
            MessageBox.Show("Your blank and white " + msg +" are ready!");
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            string msg = (printOption.Checked) ? "copies" : "scanned pages";
            MessageBox.Show("Your colored " + msg + " are ready!");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            label1.Visible = numberOfCopiesLabel.Visible = modeGroupBox.Visible = saveGroupBox.Visible =
            resetButton.Enabled = increaceButton.Enabled = decreaseButton.Enabled = blackWhiteButton.Enabled =
            ColorButton.Enabled = (!powerStatus);
            powerStatus = !powerStatus;
            powerButton.Text = (powerStatus) ? "On" : "Off";
            powerButton.ForeColor = (powerStatus) ? Color.Lime : Color.DarkRed;

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            numberOfCopiesLabel.Text = "1";
            printOption.Checked = true;
            noneOption.Checked = true;
        }
    }
}
