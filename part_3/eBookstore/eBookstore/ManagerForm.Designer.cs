namespace eBookstore
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.mouseHoverToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lightGroupBox = new System.Windows.Forms.GroupBox();
            this.light5Button = new System.Windows.Forms.Button();
            this.light5Label = new System.Windows.Forms.Label();
            this.light4Button = new System.Windows.Forms.Button();
            this.light4Label = new System.Windows.Forms.Label();
            this.light3Button = new System.Windows.Forms.Button();
            this.light3Label = new System.Windows.Forms.Label();
            this.light2Button = new System.Windows.Forms.Button();
            this.light2Label = new System.Windows.Forms.Label();
            this.light1Button = new System.Windows.Forms.Button();
            this.light1Label = new System.Windows.Forms.Label();
            this.climaGroupBox = new System.Windows.Forms.GroupBox();
            this.climaDecreaseButton = new System.Windows.Forms.Button();
            this.climaIncreaseButton = new System.Windows.Forms.Button();
            this.climaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tempratureLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abaoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.playStopButton = new System.Windows.Forms.Button();
            this.songTitlteLabel = new System.Windows.Forms.Label();
            this.light5Indicator = new System.Windows.Forms.PictureBox();
            this.light4Indicator = new System.Windows.Forms.PictureBox();
            this.light3Indicator = new System.Windows.Forms.PictureBox();
            this.light2Indicator = new System.Windows.Forms.PictureBox();
            this.light1Indicator = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip.SuspendLayout();
            this.lightGroupBox.SuspendLayout();
            this.climaGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.light5Indicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light4Indicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light3Indicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light2Indicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light1Indicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mouseHoverToolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 588);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1251, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // mouseHoverToolStripStatusLabel
            // 
            this.mouseHoverToolStripStatusLabel.Name = "mouseHoverToolStripStatusLabel";
            this.mouseHoverToolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.mouseHoverToolStripStatusLabel.Text = "toolStripStatusLabel1";
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
            this.lightGroupBox.Size = new System.Drawing.Size(200, 181);
            this.lightGroupBox.TabIndex = 3;
            this.lightGroupBox.TabStop = false;
            this.lightGroupBox.Text = "Lights";
            // 
            // light5Button
            // 
            this.light5Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.light5Button.Location = new System.Drawing.Point(6, 142);
            this.light5Button.Name = "light5Button";
            this.light5Button.Size = new System.Drawing.Size(91, 31);
            this.light5Button.TabIndex = 13;
            this.light5Button.Text = "Off";
            this.toolTip.SetToolTip(this.light5Button, "Turn on/off  light5");
            this.light5Button.UseVisualStyleBackColor = true;
            this.light5Button.Click += new System.EventHandler(this.light5Button_Click);
            this.light5Button.MouseEnter += new System.EventHandler(this.light5Button_MouseEnter);
            this.light5Button.MouseLeave += new System.EventHandler(this.light1Button_MouseLeave);
            // 
            // light5Label
            // 
            this.light5Label.AutoSize = true;
            this.light5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.light5Label.Location = new System.Drawing.Point(7, 123);
            this.light5Label.Name = "light5Label";
            this.light5Label.Size = new System.Drawing.Size(46, 16);
            this.light5Label.TabIndex = 12;
            this.light5Label.Text = "Light 5";
            // 
            // light4Button
            // 
            this.light4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.light4Button.Location = new System.Drawing.Point(102, 90);
            this.light4Button.Name = "light4Button";
            this.light4Button.Size = new System.Drawing.Size(91, 31);
            this.light4Button.TabIndex = 10;
            this.light4Button.Text = "Off";
            this.toolTip.SetToolTip(this.light4Button, "Turn on/off  light4");
            this.light4Button.UseVisualStyleBackColor = true;
            this.light4Button.Click += new System.EventHandler(this.light4Button_Click);
            this.light4Button.MouseEnter += new System.EventHandler(this.light4Button_MouseEnter);
            this.light4Button.MouseLeave += new System.EventHandler(this.light1Button_MouseLeave);
            // 
            // light4Label
            // 
            this.light4Label.AutoSize = true;
            this.light4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.light4Label.Location = new System.Drawing.Point(103, 71);
            this.light4Label.Name = "light4Label";
            this.light4Label.Size = new System.Drawing.Size(46, 16);
            this.light4Label.TabIndex = 9;
            this.light4Label.Text = "Light 4";
            // 
            // light3Button
            // 
            this.light3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.light3Button.Location = new System.Drawing.Point(6, 90);
            this.light3Button.Name = "light3Button";
            this.light3Button.Size = new System.Drawing.Size(91, 31);
            this.light3Button.TabIndex = 7;
            this.light3Button.Text = "Off";
            this.toolTip.SetToolTip(this.light3Button, "Turn on/off  light3");
            this.light3Button.UseVisualStyleBackColor = true;
            this.light3Button.Click += new System.EventHandler(this.light3Button_Click);
            this.light3Button.MouseEnter += new System.EventHandler(this.light3Button_MouseEnter);
            this.light3Button.MouseLeave += new System.EventHandler(this.light1Button_MouseLeave);
            // 
            // light3Label
            // 
            this.light3Label.AutoSize = true;
            this.light3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.light3Label.Location = new System.Drawing.Point(7, 71);
            this.light3Label.Name = "light3Label";
            this.light3Label.Size = new System.Drawing.Size(46, 16);
            this.light3Label.TabIndex = 6;
            this.light3Label.Text = "Light 3";
            // 
            // light2Button
            // 
            this.light2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.light2Button.Location = new System.Drawing.Point(102, 39);
            this.light2Button.Name = "light2Button";
            this.light2Button.Size = new System.Drawing.Size(91, 31);
            this.light2Button.TabIndex = 4;
            this.light2Button.Text = "Off";
            this.toolTip.SetToolTip(this.light2Button, "Turn on/off  light2");
            this.light2Button.UseVisualStyleBackColor = true;
            this.light2Button.Click += new System.EventHandler(this.light2Button_Click);
            this.light2Button.MouseEnter += new System.EventHandler(this.light2Button_MouseEnter);
            this.light2Button.MouseLeave += new System.EventHandler(this.light1Button_MouseLeave);
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
            // light1Button
            // 
            this.light1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.light1Button.Location = new System.Drawing.Point(6, 39);
            this.light1Button.Name = "light1Button";
            this.light1Button.Size = new System.Drawing.Size(91, 31);
            this.light1Button.TabIndex = 1;
            this.light1Button.Text = "Off";
            this.toolTip.SetToolTip(this.light1Button, "Turn on/off  light1");
            this.light1Button.UseVisualStyleBackColor = true;
            this.light1Button.Click += new System.EventHandler(this.light1OnButton_Click);
            this.light1Button.MouseEnter += new System.EventHandler(this.light1Button_MouseEnter);
            this.light1Button.MouseLeave += new System.EventHandler(this.light1Button_MouseLeave);
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
            // climaGroupBox
            // 
            this.climaGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.climaGroupBox.Controls.Add(this.climaDecreaseButton);
            this.climaGroupBox.Controls.Add(this.climaIncreaseButton);
            this.climaGroupBox.Controls.Add(this.climaButton);
            this.climaGroupBox.Controls.Add(this.label1);
            this.climaGroupBox.Controls.Add(this.tempratureLabel);
            this.climaGroupBox.Location = new System.Drawing.Point(1041, 227);
            this.climaGroupBox.Name = "climaGroupBox";
            this.climaGroupBox.Size = new System.Drawing.Size(200, 151);
            this.climaGroupBox.TabIndex = 9;
            this.climaGroupBox.TabStop = false;
            this.climaGroupBox.Text = "Clima";
            // 
            // climaDecreaseButton
            // 
            this.climaDecreaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.climaDecreaseButton.Location = new System.Drawing.Point(102, 110);
            this.climaDecreaseButton.Name = "climaDecreaseButton";
            this.climaDecreaseButton.Size = new System.Drawing.Size(91, 31);
            this.climaDecreaseButton.TabIndex = 17;
            this.climaDecreaseButton.Text = "-";
            this.toolTip.SetToolTip(this.climaDecreaseButton, "Decrease temprature");
            this.climaDecreaseButton.UseVisualStyleBackColor = true;
            this.climaDecreaseButton.Click += new System.EventHandler(this.climaDecreaseButton_Click);
            this.climaDecreaseButton.MouseEnter += new System.EventHandler(this.climaDecreaseButton_MouseEnter);
            this.climaDecreaseButton.MouseLeave += new System.EventHandler(this.light1Button_MouseLeave);
            // 
            // climaIncreaseButton
            // 
            this.climaIncreaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.climaIncreaseButton.Location = new System.Drawing.Point(6, 110);
            this.climaIncreaseButton.Name = "climaIncreaseButton";
            this.climaIncreaseButton.Size = new System.Drawing.Size(91, 31);
            this.climaIncreaseButton.TabIndex = 16;
            this.climaIncreaseButton.Text = "+";
            this.toolTip.SetToolTip(this.climaIncreaseButton, "Increase temprature");
            this.climaIncreaseButton.UseVisualStyleBackColor = true;
            this.climaIncreaseButton.Click += new System.EventHandler(this.climaIncreaseButton_Click);
            this.climaIncreaseButton.MouseEnter += new System.EventHandler(this.climaIncreaseButton_MouseEnter);
            this.climaIncreaseButton.MouseLeave += new System.EventHandler(this.light1Button_MouseLeave);
            // 
            // climaButton
            // 
            this.climaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.climaButton.Location = new System.Drawing.Point(6, 73);
            this.climaButton.Name = "climaButton";
            this.climaButton.Size = new System.Drawing.Size(187, 31);
            this.climaButton.TabIndex = 14;
            this.climaButton.Text = "Off";
            this.toolTip.SetToolTip(this.climaButton, "Turn on/off  clima");
            this.climaButton.UseVisualStyleBackColor = true;
            this.climaButton.Click += new System.EventHandler(this.climaButton_Click);
            this.climaButton.MouseEnter += new System.EventHandler(this.climaButton_MouseEnter);
            this.climaButton.MouseLeave += new System.EventHandler(this.light1Button_MouseLeave);
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
            // tempratureLabel
            // 
            this.tempratureLabel.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempratureLabel.Location = new System.Drawing.Point(49, 32);
            this.tempratureLabel.Margin = new System.Windows.Forms.Padding(0);
            this.tempratureLabel.Name = "tempratureLabel";
            this.tempratureLabel.Size = new System.Drawing.Size(110, 38);
            this.tempratureLabel.TabIndex = 1;
            this.tempratureLabel.Text = "00";
            this.tempratureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.abaoutToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1251, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // abaoutToolStripMenuItem
            // 
            this.abaoutToolStripMenuItem.Name = "abaoutToolStripMenuItem";
            this.abaoutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.abaoutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.abaoutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 1000;
            this.toolTip.AutoPopDelay = 10000;
            this.toolTip.InitialDelay = 1000;
            this.toolTip.ReshowDelay = 500;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.nextButton);
            this.groupBox1.Controls.Add(this.previousButton);
            this.groupBox1.Controls.Add(this.playStopButton);
            this.groupBox1.Location = new System.Drawing.Point(1041, 384);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 127);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Music Player";
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nextButton.Location = new System.Drawing.Point(102, 87);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(91, 31);
            this.nextButton.TabIndex = 17;
            this.nextButton.Text = "Next";
            this.toolTip.SetToolTip(this.nextButton, "Next song");
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.previousButton.Location = new System.Drawing.Point(6, 87);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(91, 31);
            this.previousButton.TabIndex = 16;
            this.previousButton.Text = "Previous";
            this.toolTip.SetToolTip(this.previousButton, "Previous song");
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // playStopButton
            // 
            this.playStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.playStopButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.playStopButton.Location = new System.Drawing.Point(7, 54);
            this.playStopButton.Name = "playStopButton";
            this.playStopButton.Size = new System.Drawing.Size(187, 31);
            this.playStopButton.TabIndex = 14;
            this.playStopButton.Text = "Play";
            this.toolTip.SetToolTip(this.playStopButton, "Play / Stop");
            this.playStopButton.UseVisualStyleBackColor = true;
            this.playStopButton.Click += new System.EventHandler(this.playStopButton_Click);
            // 
            // songTitlteLabel
            // 
            this.songTitlteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songTitlteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.songTitlteLabel.Location = new System.Drawing.Point(3, 0);
            this.songTitlteLabel.Name = "songTitlteLabel";
            this.songTitlteLabel.Size = new System.Drawing.Size(181, 26);
            this.songTitlteLabel.TabIndex = 2;
            this.songTitlteLabel.Text = "---";
            this.songTitlteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.songTitlteLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(187, 26);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 610);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.climaGroupBox);
            this.Controls.Add(this.light5Indicator);
            this.Controls.Add(this.light4Indicator);
            this.Controls.Add(this.light3Indicator);
            this.Controls.Add(this.light2Indicator);
            this.Controls.Add(this.light1Indicator);
            this.Controls.Add(this.lightGroupBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ManagerForm";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ManagerForm_KeyDown);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.lightGroupBox.ResumeLayout(false);
            this.lightGroupBox.PerformLayout();
            this.climaGroupBox.ResumeLayout(false);
            this.climaGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.light5Indicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light4Indicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light3Indicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light2Indicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light1Indicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abaoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel mouseHoverToolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button playStopButton;
        private System.Windows.Forms.Label songTitlteLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}