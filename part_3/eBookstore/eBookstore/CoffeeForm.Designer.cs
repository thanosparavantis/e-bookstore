namespace eBookstore
{
    partial class CoffeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoffeeForm));
            this.item1Order = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mouseHoverToolStripStatusLabel = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item1Increase = new System.Windows.Forms.Button();
            this.item1Decrease = new System.Windows.Forms.Button();
            this.item1TextBox = new System.Windows.Forms.TextBox();
            this.item2TextBox = new System.Windows.Forms.TextBox();
            this.item2Decrease = new System.Windows.Forms.Button();
            this.item2Increase = new System.Windows.Forms.Button();
            this.item2Order = new System.Windows.Forms.Button();
            this.item3TextBox = new System.Windows.Forms.TextBox();
            this.item3Decrease = new System.Windows.Forms.Button();
            this.item3Increase = new System.Windows.Forms.Button();
            this.item3Order = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itemOrderDecrease = new System.Windows.Forms.Button();
            this.itemOrderIncrease = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.orderListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nfcPayButton = new System.Windows.Forms.PictureBox();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nfcPayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // item1Order
            // 
            this.item1Order.Location = new System.Drawing.Point(324, 35);
            this.item1Order.Name = "item1Order";
            this.item1Order.Size = new System.Drawing.Size(83, 77);
            this.item1Order.TabIndex = 3;
            this.item1Order.Text = "Order";
            this.toolTip.SetToolTip(this.item1Order, "Add item to the list");
            this.item1Order.UseVisualStyleBackColor = true;
            this.item1Order.Click += new System.EventHandler(this.item1Order_Click);
            this.item1Order.MouseEnter += new System.EventHandler(this.itemOrder_MouseEnter);
            this.item1Order.MouseLeave += new System.EventHandler(this.clearToolStripLabel);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mouseHoverToolStripStatusLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 318);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(882, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mouseHoverToolStripStatusLabel
            // 
            this.mouseHoverToolStripStatusLabel.Name = "mouseHoverToolStripStatusLabel";
            this.mouseHoverToolStripStatusLabel.Size = new System.Drawing.Size(10, 22);
            this.mouseHoverToolStripStatusLabel.Text = ".";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + E";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exitToolStripMenuItem.Text = "Close";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // item1Increase
            // 
            this.item1Increase.Location = new System.Drawing.Point(242, 34);
            this.item1Increase.Name = "item1Increase";
            this.item1Increase.Size = new System.Drawing.Size(75, 23);
            this.item1Increase.TabIndex = 1;
            this.item1Increase.Text = "+";
            this.toolTip.SetToolTip(this.item1Increase, "Increase amount");
            this.item1Increase.UseVisualStyleBackColor = true;
            this.item1Increase.Click += new System.EventHandler(this.item1Increase_Click);
            this.item1Increase.MouseEnter += new System.EventHandler(this.increaseItemMouseEnter);
            this.item1Increase.MouseLeave += new System.EventHandler(this.clearToolStripLabel);
            // 
            // item1Decrease
            // 
            this.item1Decrease.Location = new System.Drawing.Point(243, 89);
            this.item1Decrease.Name = "item1Decrease";
            this.item1Decrease.Size = new System.Drawing.Size(75, 23);
            this.item1Decrease.TabIndex = 2;
            this.item1Decrease.Text = "-";
            this.toolTip.SetToolTip(this.item1Decrease, "Decrease amount");
            this.item1Decrease.UseVisualStyleBackColor = true;
            this.item1Decrease.Click += new System.EventHandler(this.item1Decrease_Click);
            this.item1Decrease.MouseEnter += new System.EventHandler(this.decreaseItemMouseEnter);
            this.item1Decrease.MouseLeave += new System.EventHandler(this.clearToolStripLabel);
            // 
            // item1TextBox
            // 
            this.item1TextBox.Enabled = false;
            this.item1TextBox.Location = new System.Drawing.Point(243, 63);
            this.item1TextBox.Name = "item1TextBox";
            this.item1TextBox.Size = new System.Drawing.Size(74, 20);
            this.item1TextBox.TabIndex = 9;
            this.item1TextBox.Text = "1";
            this.item1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // item2TextBox
            // 
            this.item2TextBox.Enabled = false;
            this.item2TextBox.Location = new System.Drawing.Point(243, 161);
            this.item2TextBox.Name = "item2TextBox";
            this.item2TextBox.Size = new System.Drawing.Size(74, 20);
            this.item2TextBox.TabIndex = 13;
            this.item2TextBox.Text = "1";
            this.item2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // item2Decrease
            // 
            this.item2Decrease.Location = new System.Drawing.Point(243, 187);
            this.item2Decrease.Name = "item2Decrease";
            this.item2Decrease.Size = new System.Drawing.Size(75, 23);
            this.item2Decrease.TabIndex = 5;
            this.item2Decrease.Text = "-";
            this.toolTip.SetToolTip(this.item2Decrease, "Decrease amount");
            this.item2Decrease.UseVisualStyleBackColor = true;
            this.item2Decrease.Click += new System.EventHandler(this.item2Decrease_Click);
            this.item2Decrease.MouseEnter += new System.EventHandler(this.decreaseItemMouseEnter);
            this.item2Decrease.MouseLeave += new System.EventHandler(this.clearToolStripLabel);
            // 
            // item2Increase
            // 
            this.item2Increase.Location = new System.Drawing.Point(242, 132);
            this.item2Increase.Name = "item2Increase";
            this.item2Increase.Size = new System.Drawing.Size(75, 23);
            this.item2Increase.TabIndex = 4;
            this.item2Increase.Text = "+";
            this.toolTip.SetToolTip(this.item2Increase, "Increase amount");
            this.item2Increase.UseVisualStyleBackColor = true;
            this.item2Increase.Click += new System.EventHandler(this.item2Increase_Click);
            this.item2Increase.MouseEnter += new System.EventHandler(this.increaseItemMouseEnter);
            this.item2Increase.MouseLeave += new System.EventHandler(this.clearToolStripLabel);
            // 
            // item2Order
            // 
            this.item2Order.Location = new System.Drawing.Point(324, 133);
            this.item2Order.Name = "item2Order";
            this.item2Order.Size = new System.Drawing.Size(83, 77);
            this.item2Order.TabIndex = 6;
            this.item2Order.Text = "Order";
            this.toolTip.SetToolTip(this.item2Order, "Add item to the list");
            this.item2Order.UseVisualStyleBackColor = true;
            this.item2Order.Click += new System.EventHandler(this.item2Order_Click);
            this.item2Order.MouseEnter += new System.EventHandler(this.itemOrder_MouseEnter);
            this.item2Order.MouseLeave += new System.EventHandler(this.clearToolStripLabel);
            // 
            // item3TextBox
            // 
            this.item3TextBox.Enabled = false;
            this.item3TextBox.Location = new System.Drawing.Point(243, 258);
            this.item3TextBox.Name = "item3TextBox";
            this.item3TextBox.Size = new System.Drawing.Size(74, 20);
            this.item3TextBox.TabIndex = 17;
            this.item3TextBox.Text = "1";
            this.item3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // item3Decrease
            // 
            this.item3Decrease.Location = new System.Drawing.Point(243, 284);
            this.item3Decrease.Name = "item3Decrease";
            this.item3Decrease.Size = new System.Drawing.Size(75, 23);
            this.item3Decrease.TabIndex = 8;
            this.item3Decrease.Text = "-";
            this.toolTip.SetToolTip(this.item3Decrease, "Decrease amount");
            this.item3Decrease.UseVisualStyleBackColor = true;
            this.item3Decrease.Click += new System.EventHandler(this.item3Decrease_Click);
            this.item3Decrease.MouseEnter += new System.EventHandler(this.decreaseItemMouseEnter);
            this.item3Decrease.MouseLeave += new System.EventHandler(this.clearToolStripLabel);
            // 
            // item3Increase
            // 
            this.item3Increase.Location = new System.Drawing.Point(242, 229);
            this.item3Increase.Name = "item3Increase";
            this.item3Increase.Size = new System.Drawing.Size(75, 23);
            this.item3Increase.TabIndex = 7;
            this.item3Increase.Text = "+";
            this.toolTip.SetToolTip(this.item3Increase, "Increase amount");
            this.item3Increase.UseVisualStyleBackColor = true;
            this.item3Increase.Click += new System.EventHandler(this.item3Increase_Click);
            this.item3Increase.MouseEnter += new System.EventHandler(this.increaseItemMouseEnter);
            this.item3Increase.MouseLeave += new System.EventHandler(this.clearToolStripLabel);
            // 
            // item3Order
            // 
            this.item3Order.Location = new System.Drawing.Point(324, 230);
            this.item3Order.Name = "item3Order";
            this.item3Order.Size = new System.Drawing.Size(83, 77);
            this.item3Order.TabIndex = 9;
            this.item3Order.Text = "Order";
            this.toolTip.SetToolTip(this.item3Order, "Add item to the list");
            this.item3Order.UseVisualStyleBackColor = true;
            this.item3Order.Click += new System.EventHandler(this.item3Order_Click);
            this.item3Order.MouseEnter += new System.EventHandler(this.itemOrder_MouseEnter);
            this.item3Order.MouseLeave += new System.EventHandler(this.clearToolStripLabel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.itemOrderDecrease);
            this.groupBox1.Controls.Add(this.itemOrderIncrease);
            this.groupBox1.Controls.Add(this.removeItemButton);
            this.groupBox1.Controls.Add(this.orderListView);
            this.groupBox1.Location = new System.Drawing.Point(414, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 273);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
            // 
            // itemOrderDecrease
            // 
            this.itemOrderDecrease.Location = new System.Drawing.Point(88, 244);
            this.itemOrderDecrease.Name = "itemOrderDecrease";
            this.itemOrderDecrease.Size = new System.Drawing.Size(75, 23);
            this.itemOrderDecrease.TabIndex = 12;
            this.itemOrderDecrease.Text = "-";
            this.toolTip.SetToolTip(this.itemOrderDecrease, "Decrease amount of the selected item");
            this.itemOrderDecrease.UseVisualStyleBackColor = true;
            this.itemOrderDecrease.Click += new System.EventHandler(this.itemOrderDecrease_Click);
            this.itemOrderDecrease.MouseEnter += new System.EventHandler(this.itemOrderDecrease_MouseEnter);
            this.itemOrderDecrease.MouseLeave += new System.EventHandler(this.clearToolStripLabel);
            // 
            // itemOrderIncrease
            // 
            this.itemOrderIncrease.Location = new System.Drawing.Point(7, 244);
            this.itemOrderIncrease.Name = "itemOrderIncrease";
            this.itemOrderIncrease.Size = new System.Drawing.Size(75, 23);
            this.itemOrderIncrease.TabIndex = 11;
            this.itemOrderIncrease.Text = "+";
            this.toolTip.SetToolTip(this.itemOrderIncrease, "Increase amount of the selected ittem");
            this.itemOrderIncrease.UseVisualStyleBackColor = true;
            this.itemOrderIncrease.Click += new System.EventHandler(this.itemOrderIncrease_Click);
            this.itemOrderIncrease.MouseEnter += new System.EventHandler(this.itemOrderIncrease_MouseEnter);
            this.itemOrderIncrease.MouseLeave += new System.EventHandler(this.clearToolStripLabel);
            // 
            // removeItemButton
            // 
            this.removeItemButton.ForeColor = System.Drawing.Color.DarkRed;
            this.removeItemButton.Location = new System.Drawing.Point(169, 244);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(75, 23);
            this.removeItemButton.TabIndex = 13;
            this.removeItemButton.Text = "Remove";
            this.toolTip.SetToolTip(this.removeItemButton, "Remove selected item");
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            this.removeItemButton.MouseEnter += new System.EventHandler(this.removeItemButton_MouseEnter);
            this.removeItemButton.MouseLeave += new System.EventHandler(this.clearToolStripLabel);
            // 
            // orderListView
            // 
            this.orderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.orderListView.FullRowSelect = true;
            this.orderListView.GridLines = true;
            this.orderListView.Location = new System.Drawing.Point(7, 19);
            this.orderListView.Name = "orderListView";
            this.orderListView.Size = new System.Drawing.Size(237, 219);
            this.orderListView.TabIndex = 0;
            this.orderListView.UseCompatibleStateImageBehavior = false;
            this.orderListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 154;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.Width = 77;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nfcPayButton);
            this.groupBox2.Controls.Add(this.totalCostLabel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(671, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 272);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(82, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "euro";
            // 
            // nfcPayButton
            // 
            this.nfcPayButton.Image = ((System.Drawing.Image)(resources.GetObject("nfcPayButton.Image")));
            this.nfcPayButton.Location = new System.Drawing.Point(6, 108);
            this.nfcPayButton.Name = "nfcPayButton";
            this.nfcPayButton.Size = new System.Drawing.Size(188, 158);
            this.nfcPayButton.TabIndex = 4;
            this.nfcPayButton.TabStop = false;
            this.toolTip.SetToolTip(this.nfcPayButton, "Touch credit card");
            this.nfcPayButton.Click += new System.EventHandler(this.nfcPayButton_Click);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.totalCostLabel.Location = new System.Drawing.Point(50, 39);
            this.totalCostLabel.Margin = new System.Windows.Forms.Padding(0);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(99, 38);
            this.totalCostLabel.TabIndex = 2;
            this.totalCostLabel.Text = "0.0";
            this.totalCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(54, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total cost:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::eBookstore.Properties.Resources.pancakes_price;
            this.pictureBox4.Location = new System.Drawing.Point(12, 230);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(225, 77);
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 132);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(225, 77);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::eBookstore.Properties.Resources.coffee_price;
            this.pictureBox2.Location = new System.Drawing.Point(12, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(225, 77);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 1000;
            this.toolTip.AutoPopDelay = 10000;
            this.toolTip.InitialDelay = 1000;
            this.toolTip.ReshowDelay = 500;
            // 
            // CoffeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 343);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.item3TextBox);
            this.Controls.Add(this.item3Decrease);
            this.Controls.Add(this.item3Increase);
            this.Controls.Add(this.item3Order);
            this.Controls.Add(this.item2TextBox);
            this.Controls.Add(this.item2Decrease);
            this.Controls.Add(this.item2Increase);
            this.Controls.Add(this.item2Order);
            this.Controls.Add(this.item1TextBox);
            this.Controls.Add(this.item1Decrease);
            this.Controls.Add(this.item1Increase);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.item1Order);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CoffeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Shop";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CoffeeForm_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nfcPayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button item1Order;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button item1Increase;
        private System.Windows.Forms.Button item1Decrease;
        private System.Windows.Forms.TextBox item1TextBox;
        private System.Windows.Forms.TextBox item2TextBox;
        private System.Windows.Forms.Button item2Decrease;
        private System.Windows.Forms.Button item2Increase;
        private System.Windows.Forms.Button item2Order;
        private System.Windows.Forms.TextBox item3TextBox;
        private System.Windows.Forms.Button item3Decrease;
        private System.Windows.Forms.Button item3Increase;
        private System.Windows.Forms.Button item3Order;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button itemOrderDecrease;
        private System.Windows.Forms.Button itemOrderIncrease;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.ListView orderListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox nfcPayButton;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel mouseHoverToolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
    }
}