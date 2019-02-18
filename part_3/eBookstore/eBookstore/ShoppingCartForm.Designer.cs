namespace eBookstore
{
    partial class ShoppingCartForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.itemsInCartLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.shoppingCartItemDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.closeButton = new System.Windows.Forms.Button();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.bookTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDiscountTextDataGridViewTextColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPriceTextDataGridVieTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeDataGridViewButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.amountDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.shoppingCartItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartItemDataGridView)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.shoppingCartItemDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.itemsInCartLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.totalCostLabel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(668, 44);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // itemsInCartLabel
            // 
            this.itemsInCartLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsInCartLabel.AutoSize = true;
            this.itemsInCartLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsInCartLabel.Location = new System.Drawing.Point(0, 0);
            this.itemsInCartLabel.Margin = new System.Windows.Forms.Padding(0);
            this.itemsInCartLabel.Name = "itemsInCartLabel";
            this.itemsInCartLabel.Size = new System.Drawing.Size(334, 44);
            this.itemsInCartLabel.TabIndex = 0;
            this.itemsInCartLabel.Text = "(items in cart)";
            this.itemsInCartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.Location = new System.Drawing.Point(334, 0);
            this.totalCostLabel.Margin = new System.Windows.Forms.Padding(0);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(334, 44);
            this.totalCostLabel.TabIndex = 1;
            this.totalCostLabel.Text = "(total cost)";
            this.totalCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // shoppingCartItemDataGridView
            // 
            this.shoppingCartItemDataGridView.AllowUserToAddRows = false;
            this.shoppingCartItemDataGridView.AllowUserToResizeColumns = false;
            this.shoppingCartItemDataGridView.AllowUserToResizeRows = false;
            this.shoppingCartItemDataGridView.AutoGenerateColumns = false;
            this.shoppingCartItemDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.shoppingCartItemDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.shoppingCartItemDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.shoppingCartItemDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.shoppingCartItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shoppingCartItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookTitleDataGridViewTextBoxColumn,
            this.bookBasePriceDataGridViewTextBoxColumn,
            this.bookDiscountTextDataGridViewTextColumn,
            this.bookPriceTextDataGridVieTextBoxColumn,
            this.amountDataGridViewComboBoxColumn,
            this.removeDataGridViewButtonColumn});
            this.shoppingCartItemDataGridView.DataSource = this.shoppingCartItemBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.shoppingCartItemDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.shoppingCartItemDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shoppingCartItemDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.shoppingCartItemDataGridView.Location = new System.Drawing.Point(5, 60);
            this.shoppingCartItemDataGridView.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.shoppingCartItemDataGridView.MultiSelect = false;
            this.shoppingCartItemDataGridView.Name = "shoppingCartItemDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.shoppingCartItemDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.shoppingCartItemDataGridView.RowHeadersVisible = false;
            this.shoppingCartItemDataGridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.shoppingCartItemDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.shoppingCartItemDataGridView.Size = new System.Drawing.Size(674, 441);
            this.shoppingCartItemDataGridView.TabIndex = 1;
            this.shoppingCartItemDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shoppingCartItemDataGridView_CellContentClick);
            this.shoppingCartItemDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.shoppingCartItemDataGridView_CellEndEdit);
            this.shoppingCartItemDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.shoppingCartItemDataGridView_UserDeletingRow);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.closeButton, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.purchaseButton, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.resetButton, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 506);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(674, 50);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.AutoSize = true;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(370, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(150, 50);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Cancel";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // purchaseButton
            // 
            this.purchaseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseButton.AutoSize = true;
            this.purchaseButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.purchaseButton.Location = new System.Drawing.Point(524, 0);
            this.purchaseButton.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(150, 50);
            this.purchaseButton.TabIndex = 2;
            this.purchaseButton.Text = "Purchase";
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.resetButton.Location = new System.Drawing.Point(0, 0);
            this.resetButton.Margin = new System.Windows.Forms.Padding(0);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(200, 50);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Clear shopping cart";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // bookTitleDataGridViewTextBoxColumn
            // 
            this.bookTitleDataGridViewTextBoxColumn.DataPropertyName = "BookTitle";
            this.bookTitleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.bookTitleDataGridViewTextBoxColumn.Name = "bookTitleDataGridViewTextBoxColumn";
            this.bookTitleDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookTitleDataGridViewTextBoxColumn.Width = 57;
            // 
            // bookBasePriceDataGridViewTextBoxColumn
            // 
            this.bookBasePriceDataGridViewTextBoxColumn.DataPropertyName = "BookBasePriceText";
            this.bookBasePriceDataGridViewTextBoxColumn.HeaderText = "Start Price";
            this.bookBasePriceDataGridViewTextBoxColumn.Name = "bookBasePriceDataGridViewTextBoxColumn";
            this.bookBasePriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookBasePriceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bookBasePriceDataGridViewTextBoxColumn.Width = 92;
            // 
            // bookDiscountTextDataGridViewTextColumn
            // 
            this.bookDiscountTextDataGridViewTextColumn.DataPropertyName = "BookDiscountText";
            this.bookDiscountTextDataGridViewTextColumn.HeaderText = "Discount";
            this.bookDiscountTextDataGridViewTextColumn.Name = "bookDiscountTextDataGridViewTextColumn";
            this.bookDiscountTextDataGridViewTextColumn.ReadOnly = true;
            this.bookDiscountTextDataGridViewTextColumn.Width = 83;
            // 
            // bookPriceTextDataGridVieTextBoxColumn
            // 
            this.bookPriceTextDataGridVieTextBoxColumn.DataPropertyName = "BookPriceText";
            this.bookPriceTextDataGridVieTextBoxColumn.HeaderText = "Price";
            this.bookPriceTextDataGridVieTextBoxColumn.Name = "bookPriceTextDataGridVieTextBoxColumn";
            this.bookPriceTextDataGridVieTextBoxColumn.ReadOnly = true;
            this.bookPriceTextDataGridVieTextBoxColumn.Width = 61;
            // 
            // removeDataGridViewButtonColumn
            // 
            this.removeDataGridViewButtonColumn.HeaderText = "Action";
            this.removeDataGridViewButtonColumn.Name = "removeDataGridViewButtonColumn";
            this.removeDataGridViewButtonColumn.Text = "Remove";
            this.removeDataGridViewButtonColumn.UseColumnTextForButtonValue = true;
            this.removeDataGridViewButtonColumn.Width = 50;
            // 
            // amountDataGridViewComboBoxColumn
            // 
            this.amountDataGridViewComboBoxColumn.DataPropertyName = "AmountText";
            this.amountDataGridViewComboBoxColumn.HeaderText = "Quantity";
            this.amountDataGridViewComboBoxColumn.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.amountDataGridViewComboBoxColumn.Name = "amountDataGridViewComboBoxColumn";
            this.amountDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.amountDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.amountDataGridViewComboBoxColumn.Width = 81;
            // 
            // shoppingCartItemBindingSource
            // 
            this.shoppingCartItemBindingSource.DataSource = typeof(eBookstore.model.ShoppingCartItem);
            // 
            // ShoppingCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "ShoppingCartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping Cart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShoppingCartForm_FormClosing);
            this.Load += new System.EventHandler(this.ShoppingCartForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartItemDataGridView)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingCartItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label itemsInCartLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.DataGridView shoppingCartItemDataGridView;
        private System.Windows.Forms.BindingSource shoppingCartItemBindingSource;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookBasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDiscountTextDataGridViewTextColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPriceTextDataGridVieTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn amountDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn removeDataGridViewButtonColumn;
    }
}