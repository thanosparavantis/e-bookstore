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
            string msg2 = "";
            if (usbOption.Checked)
                msg2 = "Also will be saved as digital files in your USB stick.";
            else if (emailOption.Checked)
                msg2 = "Also will be sent as digital files to your email.";

            MessageBox.Show("Your blank and white " + msg +" are ready! " + msg2);
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            string msg = (printOption.Checked) ? "copies" : "scanned pages";
            string msg2 = "";
            if (usbOption.Checked)
                msg2 = "Also will be saved as digital files in your USB stick.";
            else if (emailOption.Checked)
                msg2 = "Also will be sent as digital files to your email.";

            MessageBox.Show("Your colored " + msg + " are ready! " + msg2);
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

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void clearToolStripLabel(object sender, EventArgs e)
        {
            toolStripLabel.Text = "";
        }

        private void powerButton_MouseEnter(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Turn on/off the machine.";
        }

        private void resetButton_MouseEnter(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Reset settings.";
        }

        private void increaceButton_MouseEnter(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Increase number of pages.";
        }

        private void decreaseButton_MouseEnter(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Decrease number of pages.";
        }

        private void blackWhiteButton_MouseEnter(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Create black and white copies/scans.";
        }

        private void ColorButton_MouseEnter(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Create colored copies/scans.";

        }

        private void CancelButton_MouseEnter(object sender, EventArgs e)
        {
            toolStripLabel.Text = "Stop the current proccess.";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("eBookStore - UI/UX 2018-19 \np16036 - Ioannidis Panagiotis \np16112 - Paravantis Athanasios", "About");
        }

        private void PrinterForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E && e.Control)
                this.Hide();

            if (e.KeyCode == Keys.Add && e.Control)
                increaceButton.PerformClick();

            if (e.KeyCode == Keys.Subtract && e.Control)
                decreaseButton.PerformClick();

            if (e.KeyCode == Keys.B && e.Control)
                blackWhiteButton.PerformClick();

            if (e.KeyCode == Keys.C && e.Control)
                ColorButton.PerformClick();

            if (e.KeyCode == Keys.R && e.Control)
                resetButton.PerformClick();

            if (e.KeyCode == Keys.O && e.Control)
                powerButton.PerformClick();

            if (e.KeyCode == Keys.C && e.Control && e.Shift)
                CancelButton.PerformClick();

            if (e.KeyCode == Keys.F1)
                System.Windows.Forms.Help.ShowHelp(this, "./help_files/eBookStore_printer_scanner.chm");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, "./help_files/eBookStore_printer_scanner.chm");
        }
    }
}
