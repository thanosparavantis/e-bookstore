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
    public partial class CoffeeForm : Form
    {
        public CoffeeForm()
        {
            InitializeComponent();
        }

        private void item1Order_Click(object sender, EventArgs e)
        {
            int pos = -1;

            if (orderListView.Items.Count > 0)
            {
                for (int i = 0; i < orderListView.Items.Count; i++)
                {
                    if (orderListView.Items[i].Text.Equals("coffee"))
                    {
                        pos = i;
                        orderListView.Items[i].SubItems[1].Text =
                            (Int32.Parse(orderListView.Items[i].SubItems[1].Text) + Int32.Parse(item1TextBox.Text)).ToString();
                    }
                }
            }
            
            if (pos == -1)
            {
                ListViewItem item = new ListViewItem("coffee");
                item.Tag = "2,5";
                item.SubItems.Add(item1TextBox.Text);
                orderListView.Items.Add(item);
            }

            calculateTotalCost();
        }

        private void calculateTotalCost()
        {
            float totalCost = 0;
            if (orderListView.Items.Count > 0)
            {
                for (int i = 0; i < orderListView.Items.Count; i++)
                {
                    totalCost += float.Parse(orderListView.Items[i].SubItems[1].Text) *
                                 float.Parse(orderListView.Items[i].Tag.ToString());
                }
            }

            totalCostLabel.Text = totalCost.ToString("f");

        }

        private void item2Order_Click(object sender, EventArgs e)
        {
            int pos = -1;

            if (orderListView.Items.Count > 0)
            {
                for (int i = 0; i < orderListView.Items.Count; i++)
                {
                    if (orderListView.Items[i].Text.Equals("choco"))
                    {
                        pos = i;
                        orderListView.Items[i].SubItems[1].Text =
                            (Int32.Parse(orderListView.Items[i].SubItems[1].Text) + Int32.Parse(item2TextBox.Text)).ToString();
                    }
                }
            }

            if (pos == -1)
            {
                ListViewItem item = new ListViewItem("choco");
                item.Tag = "2";
                item.SubItems.Add(item2TextBox.Text);
                orderListView.Items.Add(item);
            }

            calculateTotalCost();
        }

        private void item3Order_Click(object sender, EventArgs e)
        {
            int pos = -1;

            if (orderListView.Items.Count > 0)
            {
                for (int i = 0; i < orderListView.Items.Count; i++)
                {
                    if (orderListView.Items[i].Text.Equals("cake"))
                    {
                        pos = i;
                        orderListView.Items[i].SubItems[1].Text =
                            (Int32.Parse(orderListView.Items[i].SubItems[1].Text) + Int32.Parse(item3TextBox.Text)).ToString();
                    }
                }
            }

            if (pos == -1)
            {
                ListViewItem item = new ListViewItem("cake");
                item.Tag = "3";
                item.SubItems.Add(item3TextBox.Text);
                orderListView.Items.Add(item);
            }

            calculateTotalCost();
        }

        private void item1Increase_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(item1TextBox.Text) < 20)
                item1TextBox.Text = ((Int32.Parse(item1TextBox.Text) + 1).ToString());
        }

        private void item1Decrease_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(item1TextBox.Text) > 1)
                item1TextBox.Text = ((Int32.Parse(item1TextBox.Text) - 1).ToString());
        }

        private void item2Increase_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(item2TextBox.Text) < 20)
                item2TextBox.Text = ((Int32.Parse(item2TextBox.Text) + 1).ToString());
        }

        private void item2Decrease_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(item2TextBox.Text) > 1)
                item2TextBox.Text = ((Int32.Parse(item2TextBox.Text) - 1).ToString());
        }

        private void item3Increase_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(item3TextBox.Text) < 20)
                item3TextBox.Text = ((Int32.Parse(item3TextBox.Text) + 1).ToString());
        }

        private void item3Decrease_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(item3TextBox.Text) > 1)
                item3TextBox.Text = ((Int32.Parse(item3TextBox.Text) - 1).ToString());
        }

        private void itemOrderIncrease_Click(object sender, EventArgs e)
        {
            if (orderListView.SelectedItems.Count > 0)
                orderListView.SelectedItems[0].SubItems[1].Text = ((Int32.Parse(orderListView.SelectedItems[0].SubItems[1].Text) + 1).ToString());

            calculateTotalCost();
        }

        private void itemOrderDecrease_Click(object sender, EventArgs e)
        {
            if (orderListView.SelectedItems.Count > 0)
            {
                if (Int32.Parse(orderListView.SelectedItems[0].SubItems[1].Text) > 1)
                    orderListView.SelectedItems[0].SubItems[1].Text = ((Int32.Parse(orderListView.SelectedItems[0].SubItems[1].Text) - 1).ToString());
            }

            calculateTotalCost();
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            if (orderListView.SelectedItems.Count > 0)
                orderListView.Items.Remove(orderListView.SelectedItems[0]);

            calculateTotalCost();
        }

        private void nfcPayButton_Click(object sender, EventArgs e)
        {
            if (float.Parse(totalCostLabel.Text) > 0.0)
            {
                orderListView.Items.Clear();
                item1TextBox.Text = item2TextBox.Text = item3TextBox.Text = "1";
                calculateTotalCost();
                MessageBox.Show("Your order will be ready soon! Thanks a lot!");
            }   
        }

        private void increaseItemMouseEnter(object sender, EventArgs e)
        {
            mouseHoverToolStripStatusLabel.Text = "Click to increase the amount of this product!";
        }
        private void decreaseItemMouseEnter(object sender, EventArgs e)
        {
            mouseHoverToolStripStatusLabel.Text = "Click to decrease the amount of this product!";
        }

        private void clearToolStripLabel(object sender, EventArgs e)
        {
            mouseHoverToolStripStatusLabel.Text = "";

        }

        private void itemOrder_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverToolStripStatusLabel.Text = "Click to add this product in your order list!";
        }

        private void itemOrderIncrease_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverToolStripStatusLabel.Text = "Click to increase the amount of the selected product!";
        }

        private void itemOrderDecrease_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverToolStripStatusLabel.Text = "Click to decrease the amount of the selected product!";
        }

        private void removeItemButton_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverToolStripStatusLabel.Text = "Click to remove the selected product!";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("eBookStore - UI/UX 2018-19 \np16036 - Ioannidis Panagiotis \np16112 - Paravantis Athanasios", "About");
        }

        private void CoffeeForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E && e.Control)
                this.Hide();

            if (e.KeyCode == Keys.Add && e.Control)
                itemOrderIncrease.PerformClick();

            if (e.KeyCode == Keys.Subtract && e.Control)
                itemOrderDecrease.PerformClick();

            if (e.KeyCode == Keys.R && e.Control)
                removeItemButton.PerformClick();

            if (e.KeyCode == Keys.F1)
                System.Windows.Forms.Help.ShowHelp(this, "./help_files/eBookStore_coffee_shop.chm");

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, "./help_files/eBookStore_coffee_shop.chm");

        }
    }
}
