namespace eBookstore
{
    partial class PrinterForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.powerButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.increaceButton = new System.Windows.Forms.Button();
            this.decreaseButton = new System.Windows.Forms.Button();
            this.blackWhiteButton = new System.Windows.Forms.Button();
            this.ColorButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfCopiesLabel = new System.Windows.Forms.Label();
            this.modeGroupBox = new System.Windows.Forms.GroupBox();
            this.ScanOption = new System.Windows.Forms.RadioButton();
            this.printOption = new System.Windows.Forms.RadioButton();
            this.saveGroupBox = new System.Windows.Forms.GroupBox();
            this.usbOption = new System.Windows.Forms.RadioButton();
            this.noneOption = new System.Windows.Forms.RadioButton();
            this.emailOption = new System.Windows.Forms.RadioButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.modeGroupBox.SuspendLayout();
            this.saveGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + E";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
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
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 237);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(676, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel
            // 
            this.toolStripLabel.Name = "toolStripLabel";
            this.toolStripLabel.Size = new System.Drawing.Size(10, 22);
            this.toolStripLabel.Text = ".";
            // 
            // powerButton
            // 
            this.powerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.powerButton.ForeColor = System.Drawing.Color.DarkRed;
            this.powerButton.Location = new System.Drawing.Point(12, 110);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(48, 50);
            this.powerButton.TabIndex = 1;
            this.powerButton.Text = "Off";
            this.toolTip.SetToolTip(this.powerButton, "Turn on/off");
            this.powerButton.UseVisualStyleBackColor = true;
            this.powerButton.Click += new System.EventHandler(this.powerButton_Click);
            this.powerButton.MouseEnter += new System.EventHandler(this.powerButton_MouseEnter);
            this.powerButton.MouseLeave += new System.EventHandler(this.clearToolStripLabel);
            // 
            // resetButton
            // 
            this.resetButton.Enabled = false;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.resetButton.Location = new System.Drawing.Point(84, 110);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(48, 50);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.toolTip.SetToolTip(this.resetButton, "Reset settings");
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            this.resetButton.MouseEnter += new System.EventHandler(this.resetButton_MouseEnter);
            this.resetButton.MouseLeave += new System.EventHandler(this.clearToolStripLabel);
            // 
            // increaceButton
            // 
            this.increaceButton.Enabled = false;
            this.increaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.increaceButton.Location = new System.Drawing.Point(485, 82);
            this.increaceButton.Name = "increaceButton";
            this.increaceButton.Size = new System.Drawing.Size(48, 50);
            this.increaceButton.TabIndex = 3;
            this.increaceButton.Text = "+";
            this.toolTip.SetToolTip(this.increaceButton, "Increase number of pages");
            this.increaceButton.UseVisualStyleBackColor = true;
            this.increaceButton.Click += new System.EventHandler(this.button3_Click);
            this.increaceButton.MouseEnter += new System.EventHandler(this.increaceButton_MouseEnter);
            this.increaceButton.MouseLeave += new System.EventHandler(this.clearToolStripLabel);
            // 
            // decreaseButton
            // 
            this.decreaseButton.Enabled = false;
            this.decreaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.decreaseButton.Location = new System.Drawing.Point(485, 138);
            this.decreaseButton.Name = "decreaseButton";
            this.decreaseButton.Size = new System.Drawing.Size(48, 50);
            this.decreaseButton.TabIndex = 4;
            this.decreaseButton.Text = "-";
            this.toolTip.SetToolTip(this.decreaseButton, "Decrease number of pages");
            this.decreaseButton.UseVisualStyleBackColor = true;
            this.decreaseButton.Click += new System.EventHandler(this.button4_Click);
            this.decreaseButton.MouseEnter += new System.EventHandler(this.decreaseButton_MouseEnter);
            this.decreaseButton.MouseLeave += new System.EventHandler(this.clearToolStripLabel);
            // 
            // blackWhiteButton
            // 
            this.blackWhiteButton.Enabled = false;
            this.blackWhiteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.blackWhiteButton.Location = new System.Drawing.Point(550, 82);
            this.blackWhiteButton.Name = "blackWhiteButton";
            this.blackWhiteButton.Size = new System.Drawing.Size(48, 50);
            this.blackWhiteButton.TabIndex = 5;
            this.blackWhiteButton.Text = "B/W";
            this.toolTip.SetToolTip(this.blackWhiteButton, "Create black n white copies/scans");
            this.blackWhiteButton.UseVisualStyleBackColor = true;
            this.blackWhiteButton.Click += new System.EventHandler(this.button5_Click);
            this.blackWhiteButton.MouseEnter += new System.EventHandler(this.blackWhiteButton_MouseEnter);
            this.blackWhiteButton.MouseLeave += new System.EventHandler(this.clearToolStripLabel);
            // 
            // ColorButton
            // 
            this.ColorButton.Enabled = false;
            this.ColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ColorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ColorButton.Location = new System.Drawing.Point(550, 138);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(48, 50);
            this.ColorButton.TabIndex = 6;
            this.ColorButton.Text = "Color";
            this.toolTip.SetToolTip(this.ColorButton, "Create colored copies/scans");
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            this.ColorButton.MouseEnter += new System.EventHandler(this.ColorButton_MouseEnter);
            this.ColorButton.MouseLeave += new System.EventHandler(this.clearToolStripLabel);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CancelButton.ForeColor = System.Drawing.Color.Red;
            this.CancelButton.Location = new System.Drawing.Point(614, 110);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(48, 50);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.toolTip.SetToolTip(this.CancelButton, "Cancel the current proccess");
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            this.CancelButton.MouseEnter += new System.EventHandler(this.CancelButton_MouseEnter);
            this.CancelButton.MouseLeave += new System.EventHandler(this.clearToolStripLabel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(167, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Number of pages:";
            // 
            // numberOfCopiesLabel
            // 
            this.numberOfCopiesLabel.AutoSize = true;
            this.numberOfCopiesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.numberOfCopiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.numberOfCopiesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numberOfCopiesLabel.Location = new System.Drawing.Point(298, 57);
            this.numberOfCopiesLabel.Name = "numberOfCopiesLabel";
            this.numberOfCopiesLabel.Size = new System.Drawing.Size(19, 20);
            this.numberOfCopiesLabel.TabIndex = 11;
            this.numberOfCopiesLabel.Text = "1";
            // 
            // modeGroupBox
            // 
            this.modeGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.modeGroupBox.Controls.Add(this.ScanOption);
            this.modeGroupBox.Controls.Add(this.printOption);
            this.modeGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modeGroupBox.Location = new System.Drawing.Point(170, 87);
            this.modeGroupBox.Name = "modeGroupBox";
            this.modeGroupBox.Size = new System.Drawing.Size(200, 50);
            this.modeGroupBox.TabIndex = 13;
            this.modeGroupBox.TabStop = false;
            this.modeGroupBox.Text = "Mode";
            // 
            // ScanOption
            // 
            this.ScanOption.AutoSize = true;
            this.ScanOption.Location = new System.Drawing.Point(82, 20);
            this.ScanOption.Name = "ScanOption";
            this.ScanOption.Size = new System.Drawing.Size(65, 17);
            this.ScanOption.TabIndex = 1;
            this.ScanOption.Text = "Scanner";
            this.ScanOption.UseVisualStyleBackColor = true;
            // 
            // printOption
            // 
            this.printOption.AutoSize = true;
            this.printOption.Checked = true;
            this.printOption.Location = new System.Drawing.Point(7, 20);
            this.printOption.Name = "printOption";
            this.printOption.Size = new System.Drawing.Size(55, 17);
            this.printOption.TabIndex = 0;
            this.printOption.TabStop = true;
            this.printOption.Text = "Printer";
            this.printOption.UseVisualStyleBackColor = true;
            // 
            // saveGroupBox
            // 
            this.saveGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.saveGroupBox.Controls.Add(this.usbOption);
            this.saveGroupBox.Controls.Add(this.noneOption);
            this.saveGroupBox.Controls.Add(this.emailOption);
            this.saveGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveGroupBox.Location = new System.Drawing.Point(170, 149);
            this.saveGroupBox.Name = "saveGroupBox";
            this.saveGroupBox.Size = new System.Drawing.Size(200, 50);
            this.saveGroupBox.TabIndex = 14;
            this.saveGroupBox.TabStop = false;
            this.saveGroupBox.Text = "Save";
            // 
            // usbOption
            // 
            this.usbOption.AutoSize = true;
            this.usbOption.Location = new System.Drawing.Point(150, 21);
            this.usbOption.Name = "usbOption";
            this.usbOption.Size = new System.Drawing.Size(44, 17);
            this.usbOption.TabIndex = 2;
            this.usbOption.Text = "Usb";
            this.usbOption.UseVisualStyleBackColor = true;
            // 
            // noneOption
            // 
            this.noneOption.AutoSize = true;
            this.noneOption.Checked = true;
            this.noneOption.Location = new System.Drawing.Point(7, 21);
            this.noneOption.Name = "noneOption";
            this.noneOption.Size = new System.Drawing.Size(51, 17);
            this.noneOption.TabIndex = 0;
            this.noneOption.TabStop = true;
            this.noneOption.Text = "None";
            this.noneOption.UseVisualStyleBackColor = true;
            // 
            // emailOption
            // 
            this.emailOption.AutoSize = true;
            this.emailOption.Location = new System.Drawing.Point(82, 21);
            this.emailOption.Name = "emailOption";
            this.emailOption.Size = new System.Drawing.Size(50, 17);
            this.emailOption.TabIndex = 1;
            this.emailOption.Text = "Email";
            this.emailOption.UseVisualStyleBackColor = true;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 1000;
            this.toolTip.AutoPopDelay = 10000;
            this.toolTip.InitialDelay = 1000;
            this.toolTip.ReshowDelay = 500;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eBookstore.Properties.Resources.cannon_C_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(675, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PrinterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 262);
            this.Controls.Add(this.saveGroupBox);
            this.Controls.Add(this.modeGroupBox);
            this.Controls.Add(this.numberOfCopiesLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.blackWhiteButton);
            this.Controls.Add(this.decreaseButton);
            this.Controls.Add(this.increaceButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.powerButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "PrinterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Printer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrinterForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.modeGroupBox.ResumeLayout(false);
            this.modeGroupBox.PerformLayout();
            this.saveGroupBox.ResumeLayout(false);
            this.saveGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button increaceButton;
        private System.Windows.Forms.Button decreaseButton;
        private System.Windows.Forms.Button blackWhiteButton;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numberOfCopiesLabel;
        private System.Windows.Forms.GroupBox modeGroupBox;
        private System.Windows.Forms.RadioButton ScanOption;
        private System.Windows.Forms.RadioButton printOption;
        private System.Windows.Forms.GroupBox saveGroupBox;
        private System.Windows.Forms.RadioButton noneOption;
        private System.Windows.Forms.RadioButton emailOption;
        private System.Windows.Forms.RadioButton usbOption;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel;
        private System.Windows.Forms.ToolTip toolTip;
    }
}