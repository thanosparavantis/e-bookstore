﻿namespace eBookstore
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lightGroupBox = new System.Windows.Forms.GroupBox();
            this.light1Label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.light1Button = new System.Windows.Forms.Button();
            this.light2Button = new System.Windows.Forms.Button();
            this.light2Label = new System.Windows.Forms.Label();
            this.light3Button = new System.Windows.Forms.Button();
            this.light3Label = new System.Windows.Forms.Label();
            this.light4Button = new System.Windows.Forms.Button();
            this.light4Label = new System.Windows.Forms.Label();
            this.light5Button = new System.Windows.Forms.Button();
            this.light5Label = new System.Windows.Forms.Label();
            this.light5Indicator = new System.Windows.Forms.PictureBox();
            this.light4Indicator = new System.Windows.Forms.PictureBox();
            this.light3Indicator = new System.Windows.Forms.PictureBox();
            this.light2Indicator = new System.Windows.Forms.PictureBox();
            this.light1Indicator = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.climaGroupBox = new System.Windows.Forms.GroupBox();
            this.tempratureLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.climaButton = new System.Windows.Forms.Button();
            this.climaDecreaseButton = new System.Windows.Forms.Button();
            this.climaIncreaseButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.lightGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.light5Indicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light4Indicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light3Indicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light2Indicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light1Indicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.climaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1251, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Options";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
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
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 588);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1251, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lightGroupBox
            // 
            this.lightGroupBox.Controls.Add(this.light5Button);
            this.lightGroupBox.Controls.Add(this.light5Label);
            this.lightGroupBox.Controls.Add(this.light4Button);
            this.lightGroupBox.Controls.Add(this.light4Label);
            this.lightGroupBox.Controls.Add(this.light3Button);
            this.lightGroupBox.Controls.Add(this.light3Label);
            this.lightGroupBox.Controls.Add(this.light2Button);
            this.lightGroupBox.Controls.Add(this.light2Label);
            this.lightGroupBox.Controls.Add(this.light1Button);
            this.lightGroupBox.Controls.Add(this.light1Label);
            this.lightGroupBox.Location = new System.Drawing.Point(1041, 40);
            this.lightGroupBox.Name = "lightGroupBox";
            this.lightGroupBox.Size = new System.Drawing.Size(200, 164);
            this.lightGroupBox.TabIndex = 3;
            this.lightGroupBox.TabStop = false;
            this.lightGroupBox.Text = "Lights";
            // 
            // light1Label
            // 
            this.light1Label.AutoSize = true;
            this.light1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.light1Label.Location = new System.Drawing.Point(7, 20);
            this.light1Label.Name = "light1Label";
            this.light1Label.Size = new System.Drawing.Size(46, 16);
            this.light1Label.TabIndex = 0;
            this.light1Label.Text = "Light 1";
            // 
            // light1Button
            // 
            this.light1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.light1Button.Location = new System.Drawing.Point(6, 39);
            this.light1Button.Name = "light1Button";
            this.light1Button.Size = new System.Drawing.Size(91, 23);
            this.light1Button.TabIndex = 1;
            this.light1Button.Text = "Off";
            this.light1Button.UseVisualStyleBackColor = true;
            this.light1Button.Click += new System.EventHandler(this.light1OnButton_Click);
            // 
            // light2Button
            // 
            this.light2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.light2Button.Location = new System.Drawing.Point(102, 39);
            this.light2Button.Name = "light2Button";
            this.light2Button.Size = new System.Drawing.Size(91, 23);
            this.light2Button.TabIndex = 4;
            this.light2Button.Text = "Off";
            this.light2Button.UseVisualStyleBackColor = true;
            this.light2Button.Click += new System.EventHandler(this.light2Button_Click);
            // 
            // light2Label
            // 
            this.light2Label.AutoSize = true;
            this.light2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.light2Label.Location = new System.Drawing.Point(103, 20);
            this.light2Label.Name = "light2Label";
            this.light2Label.Size = new System.Drawing.Size(46, 16);
            this.light2Label.TabIndex = 3;
            this.light2Label.Text = "Light 2";
            // 
            // light3Button
            // 
            this.light3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.light3Button.Location = new System.Drawing.Point(6, 84);
            this.light3Button.Name = "light3Button";
            this.light3Button.Size = new System.Drawing.Size(91, 23);
            this.light3Button.TabIndex = 7;
            this.light3Button.Text = "Off";
            this.light3Button.UseVisualStyleBackColor = true;
            this.light3Button.Click += new System.EventHandler(this.light3Button_Click);
            // 
            // light3Label
            // 
            this.light3Label.AutoSize = true;
            this.light3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.light3Label.Location = new System.Drawing.Point(7, 65);
            this.light3Label.Name = "light3Label";
            this.light3Label.Size = new System.Drawing.Size(46, 16);
            this.light3Label.TabIndex = 6;
            this.light3Label.Text = "Light 3";
            // 
            // light4Button
            // 
            this.light4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.light4Button.Location = new System.Drawing.Point(102, 84);
            this.light4Button.Name = "light4Button";
            this.light4Button.Size = new System.Drawing.Size(91, 23);
            this.light4Button.TabIndex = 10;
            this.light4Button.Text = "Off";
            this.light4Button.UseVisualStyleBackColor = true;
            this.light4Button.Click += new System.EventHandler(this.light4Button_Click);
            // 
            // light4Label
            // 
            this.light4Label.AutoSize = true;
            this.light4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.light4Label.Location = new System.Drawing.Point(103, 65);
            this.light4Label.Name = "light4Label";
            this.light4Label.Size = new System.Drawing.Size(46, 16);
            this.light4Label.TabIndex = 9;
            this.light4Label.Text = "Light 4";
            // 
            // light5Button
            // 
            this.light5Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.light5Button.Location = new System.Drawing.Point(6, 129);
            this.light5Button.Name = "light5Button";
            this.light5Button.Size = new System.Drawing.Size(91, 23);
            this.light5Button.TabIndex = 13;
            this.light5Button.Text = "Off";
            this.light5Button.UseVisualStyleBackColor = true;
            this.light5Button.Click += new System.EventHandler(this.light5Button_Click);
            // 
            // light5Label
            // 
            this.light5Label.AutoSize = true;
            this.light5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.light5Label.Location = new System.Drawing.Point(7, 110);
            this.light5Label.Name = "light5Label";
            this.light5Label.Size = new System.Drawing.Size(46, 16);
            this.light5Label.TabIndex = 12;
            this.light5Label.Text = "Light 5";
            // 
            // light5Indicator
            // 
            this.light5Indicator.Image = ((System.Drawing.Image)(resources.GetObject("light5Indicator.Image")));
            this.light5Indicator.Location = new System.Drawing.Point(694, 406);
            this.light5Indicator.Name = "light5Indicator";
            this.light5Indicator.Size = new System.Drawing.Size(16, 16);
            this.light5Indicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.light5Indicator.TabIndex = 8;
            this.light5Indicator.TabStop = false;
            // 
            // light4Indicator
            // 
            this.light4Indicator.Image = ((System.Drawing.Image)(resources.GetObject("light4Indicator.Image")));
            this.light4Indicator.Location = new System.Drawing.Point(449, 406);
            this.light4Indicator.Name = "light4Indicator";
            this.light4Indicator.Size = new System.Drawing.Size(16, 16);
            this.light4Indicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.light4Indicator.TabIndex = 7;
            this.light4Indicator.TabStop = false;
            // 
            // light3Indicator
            // 
            this.light3Indicator.Image = ((System.Drawing.Image)(resources.GetObject("light3Indicator.Image")));
            this.light3Indicator.Location = new System.Drawing.Point(228, 406);
            this.light3Indicator.Name = "light3Indicator";
            this.light3Indicator.Size = new System.Drawing.Size(16, 16);
            this.light3Indicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.light3Indicator.TabIndex = 6;
            this.light3Indicator.TabStop = false;
            // 
            // light2Indicator
            // 
            this.light2Indicator.Image = ((System.Drawing.Image)(resources.GetObject("light2Indicator.Image")));
            this.light2Indicator.Location = new System.Drawing.Point(449, 188);
            this.light2Indicator.Name = "light2Indicator";
            this.light2Indicator.Size = new System.Drawing.Size(16, 16);
            this.light2Indicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.light2Indicator.TabIndex = 5;
            this.light2Indicator.TabStop = false;
            // 
            // light1Indicator
            // 
            this.light1Indicator.Image = ((System.Drawing.Image)(resources.GetObject("light1Indicator.Image")));
            this.light1Indicator.Location = new System.Drawing.Point(228, 188);
            this.light1Indicator.Name = "light1Indicator";
            this.light1Indicator.Size = new System.Drawing.Size(16, 16);
            this.light1Indicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.light1Indicator.TabIndex = 4;
            this.light1Indicator.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eBookstore.Properties.Resources.shop_v2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1022, 532);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // climaGroupBox
            // 
            this.climaGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.climaGroupBox.Controls.Add(this.climaDecreaseButton);
            this.climaGroupBox.Controls.Add(this.climaIncreaseButton);
            this.climaGroupBox.Controls.Add(this.climaButton);
            this.climaGroupBox.Controls.Add(this.label1);
            this.climaGroupBox.Controls.Add(this.tempratureLabel);
            this.climaGroupBox.Location = new System.Drawing.Point(1041, 210);
            this.climaGroupBox.Name = "climaGroupBox";
            this.climaGroupBox.Size = new System.Drawing.Size(200, 138);
            this.climaGroupBox.TabIndex = 9;
            this.climaGroupBox.TabStop = false;
            this.climaGroupBox.Text = "Clima";
            // 
            // tempratureLabel
            // 
            this.tempratureLabel.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempratureLabel.Location = new System.Drawing.Point(49, 32);
            this.tempratureLabel.Margin = new System.Windows.Forms.Padding(0);
            this.tempratureLabel.Name = "tempratureLabel";
            this.tempratureLabel.Size = new System.Drawing.Size(110, 38);
            this.tempratureLabel.TabIndex = 1;
            this.tempratureLabel.Text = "18";
            this.tempratureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(62, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temprature";
            // 
            // climaButton
            // 
            this.climaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.climaButton.Location = new System.Drawing.Point(6, 73);
            this.climaButton.Name = "climaButton";
            this.climaButton.Size = new System.Drawing.Size(187, 23);
            this.climaButton.TabIndex = 14;
            this.climaButton.Text = "Off";
            this.climaButton.UseVisualStyleBackColor = true;
            this.climaButton.Click += new System.EventHandler(this.climaButton_Click);
            // 
            // climaDecreaseButton
            // 
            this.climaDecreaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.climaDecreaseButton.Location = new System.Drawing.Point(102, 102);
            this.climaDecreaseButton.Name = "climaDecreaseButton";
            this.climaDecreaseButton.Size = new System.Drawing.Size(91, 23);
            this.climaDecreaseButton.TabIndex = 17;
            this.climaDecreaseButton.Text = "-";
            this.climaDecreaseButton.UseVisualStyleBackColor = true;
            this.climaDecreaseButton.Click += new System.EventHandler(this.climaDecreaseButton_Click);
            // 
            // climaIncreaseButton
            // 
            this.climaIncreaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.climaIncreaseButton.Location = new System.Drawing.Point(6, 102);
            this.climaIncreaseButton.Name = "climaIncreaseButton";
            this.climaIncreaseButton.Size = new System.Drawing.Size(91, 23);
            this.climaIncreaseButton.TabIndex = 16;
            this.climaIncreaseButton.Text = "+";
            this.climaIncreaseButton.UseVisualStyleBackColor = true;
            this.climaIncreaseButton.Click += new System.EventHandler(this.climaIncreaseButton_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 610);
            this.Controls.Add(this.climaGroupBox);
            this.Controls.Add(this.light5Indicator);
            this.Controls.Add(this.light4Indicator);
            this.Controls.Add(this.light3Indicator);
            this.Controls.Add(this.light2Indicator);
            this.Controls.Add(this.light1Indicator);
            this.Controls.Add(this.lightGroupBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ManagerForm";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.lightGroupBox.ResumeLayout(false);
            this.lightGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.light5Indicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light4Indicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light3Indicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light2Indicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light1Indicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.climaGroupBox.ResumeLayout(false);
            this.climaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.GroupBox lightGroupBox;
        private System.Windows.Forms.Button light5Button;
        private System.Windows.Forms.Label light5Label;
        private System.Windows.Forms.Button light4Button;
        private System.Windows.Forms.Label light4Label;
        private System.Windows.Forms.Button light3Button;
        private System.Windows.Forms.Label light3Label;
        private System.Windows.Forms.Button light2Button;
        private System.Windows.Forms.Label light2Label;
        private System.Windows.Forms.Button light1Button;
        private System.Windows.Forms.Label light1Label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox light1Indicator;
        private System.Windows.Forms.PictureBox light2Indicator;
        private System.Windows.Forms.PictureBox light3Indicator;
        private System.Windows.Forms.PictureBox light4Indicator;
        private System.Windows.Forms.PictureBox light5Indicator;
        private System.Windows.Forms.GroupBox climaGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tempratureLabel;
        private System.Windows.Forms.Button climaDecreaseButton;
        private System.Windows.Forms.Button climaIncreaseButton;
        private System.Windows.Forms.Button climaButton;
    }
}