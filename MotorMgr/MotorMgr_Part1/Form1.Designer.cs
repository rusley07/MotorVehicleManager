namespace MotorMgr
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.saveButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.customerGroupBox = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.purchaseGroupBox = new System.Windows.Forms.GroupBox();
            this.lessTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.tradeInLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.costingGroupBox = new System.Windows.Forms.GroupBox();
            this.finAmLabel = new System.Windows.Forms.Label();
            this.gstAmLabel = new System.Windows.Forms.Label();
            this.subAmLabel = new System.Windows.Forms.Label();
            this.finalLabel = new System.Windows.Forms.Label();
            this.gstLabel = new System.Windows.Forms.Label();
            this.subLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.summaryButton = new System.Windows.Forms.Button();
            this.warrantyGroupBox = new System.Windows.Forms.GroupBox();
            this.fiveYearsRadioButton = new System.Windows.Forms.RadioButton();
            this.threeYearsRadioButton = new System.Windows.Forms.RadioButton();
            this.noChargeRadioButton = new System.Windows.Forms.RadioButton();
            this.extrasGroupBox = new System.Windows.Forms.GroupBox();
            this.soundCheckBox = new System.Windows.Forms.CheckBox();
            this.naviCheckBox = new System.Windows.Forms.CheckBox();
            this.protectionCheckBox = new System.Windows.Forms.CheckBox();
            this.tintingCheckBox = new System.Windows.Forms.CheckBox();
            this.insuranseGroupBox = new System.Windows.Forms.GroupBox();
            this.moreEqTwoFiveRadioButton = new System.Windows.Forms.RadioButton();
            this.lessTwoFiveRadioButton = new System.Windows.Forms.RadioButton();
            this.policyCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.detailsListBox = new System.Windows.Forms.ListBox();
            this.customerGroupBox.SuspendLayout();
            this.purchaseGroupBox.SuspendLayout();
            this.costingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.warrantyGroupBox.SuspendLayout();
            this.extrasGroupBox.SuspendLayout();
            this.insuranseGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(729, 133);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(216, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "&Save";
            this.toolTip1.SetToolTip(this.saveButton, "Save Customer\'s Details");
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(729, 220);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(216, 23);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "&Reset";
            this.toolTip1.SetToolTip(this.resetButton, "Clear all Boxes Details");
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(729, 162);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(216, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "&Calculate";
            this.toolTip1.SetToolTip(this.calculateButton, "Show Customer\'s Purchase Price");
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(729, 249);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(216, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.toolTip1.SetToolTip(this.exitButton, "Quit all Process");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // customerGroupBox
            // 
            this.customerGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.customerGroupBox.Controls.Add(this.comboBox2);
            this.customerGroupBox.Controls.Add(this.comboBox1);
            this.customerGroupBox.Controls.Add(this.nameLabel);
            this.customerGroupBox.Controls.Add(this.phoneLabel);
            this.customerGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.customerGroupBox.Location = new System.Drawing.Point(12, 49);
            this.customerGroupBox.Name = "customerGroupBox";
            this.customerGroupBox.Size = new System.Drawing.Size(262, 104);
            this.customerGroupBox.TabIndex = 0;
            this.customerGroupBox.TabStop = false;
            this.customerGroupBox.Text = "Customer Details:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(142, 67);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 75);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(85, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Customer Name:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(6, 37);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(81, 13);
            this.phoneLabel.TabIndex = 0;
            this.phoneLabel.Text = "Phone Number:";
            // 
            // purchaseGroupBox
            // 
            this.purchaseGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.purchaseGroupBox.Controls.Add(this.lessTextBox);
            this.purchaseGroupBox.Controls.Add(this.priceTextBox);
            this.purchaseGroupBox.Controls.Add(this.tradeInLabel);
            this.purchaseGroupBox.Controls.Add(this.priceLabel);
            this.purchaseGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.purchaseGroupBox.Location = new System.Drawing.Point(12, 159);
            this.purchaseGroupBox.Name = "purchaseGroupBox";
            this.purchaseGroupBox.Size = new System.Drawing.Size(262, 100);
            this.purchaseGroupBox.TabIndex = 2;
            this.purchaseGroupBox.TabStop = false;
            this.purchaseGroupBox.Text = "Purchase Details:";
            // 
            // lessTextBox
            // 
            this.lessTextBox.Location = new System.Drawing.Point(142, 56);
            this.lessTextBox.Name = "lessTextBox";
            this.lessTextBox.Size = new System.Drawing.Size(100, 20);
            this.lessTextBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.lessTextBox, "Price of Customer\'s Vehicle");
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(142, 19);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.priceTextBox, "Price of choosen Vehicle");
            // 
            // tradeInLabel
            // 
            this.tradeInLabel.AutoSize = true;
            this.tradeInLabel.Location = new System.Drawing.Point(6, 63);
            this.tradeInLabel.Name = "tradeInLabel";
            this.tradeInLabel.Size = new System.Drawing.Size(84, 13);
            this.tradeInLabel.TabIndex = 2;
            this.tradeInLabel.Text = "Fewer Trade-Ins";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(6, 26);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(72, 13);
            this.priceLabel.TabIndex = 0;
            this.priceLabel.Text = "Vehicle Price:";
            // 
            // costingGroupBox
            // 
            this.costingGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.costingGroupBox.Controls.Add(this.finAmLabel);
            this.costingGroupBox.Controls.Add(this.gstAmLabel);
            this.costingGroupBox.Controls.Add(this.subAmLabel);
            this.costingGroupBox.Controls.Add(this.finalLabel);
            this.costingGroupBox.Controls.Add(this.gstLabel);
            this.costingGroupBox.Controls.Add(this.subLabel);
            this.costingGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.costingGroupBox.Location = new System.Drawing.Point(729, 278);
            this.costingGroupBox.Name = "costingGroupBox";
            this.costingGroupBox.Size = new System.Drawing.Size(216, 116);
            this.costingGroupBox.TabIndex = 6;
            this.costingGroupBox.TabStop = false;
            this.costingGroupBox.Text = "Costing Details:";
            // 
            // finAmLabel
            // 
            this.finAmLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finAmLabel.Location = new System.Drawing.Point(96, 78);
            this.finAmLabel.Name = "finAmLabel";
            this.finAmLabel.Size = new System.Drawing.Size(114, 21);
            this.finAmLabel.TabIndex = 13;
            // 
            // gstAmLabel
            // 
            this.gstAmLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gstAmLabel.Location = new System.Drawing.Point(96, 55);
            this.gstAmLabel.Name = "gstAmLabel";
            this.gstAmLabel.Size = new System.Drawing.Size(114, 21);
            this.gstAmLabel.TabIndex = 12;
            // 
            // subAmLabel
            // 
            this.subAmLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subAmLabel.Location = new System.Drawing.Point(96, 33);
            this.subAmLabel.Name = "subAmLabel";
            this.subAmLabel.Size = new System.Drawing.Size(114, 21);
            this.subAmLabel.TabIndex = 11;
            // 
            // finalLabel
            // 
            this.finalLabel.AutoSize = true;
            this.finalLabel.Location = new System.Drawing.Point(6, 86);
            this.finalLabel.Name = "finalLabel";
            this.finalLabel.Size = new System.Drawing.Size(71, 13);
            this.finalLabel.TabIndex = 4;
            this.finalLabel.Text = "Final Amount:";
            // 
            // gstLabel
            // 
            this.gstLabel.AutoSize = true;
            this.gstLabel.Location = new System.Drawing.Point(6, 63);
            this.gstLabel.Name = "gstLabel";
            this.gstLabel.Size = new System.Drawing.Size(71, 13);
            this.gstLabel.TabIndex = 2;
            this.gstLabel.Text = "GST Amount:";
            // 
            // subLabel
            // 
            this.subLabel.AutoSize = true;
            this.subLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.subLabel.Location = new System.Drawing.Point(6, 41);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(68, 13);
            this.subLabel.TabIndex = 0;
            this.subLabel.Text = "Sub Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vladimir Script", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(294, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Motor Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(953, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Developed by\r\nRuslan Batura";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MotorMgr.Properties.Resources.tumblr_m5u6d5555u1r9mw2eo1_r2_500;
            this.pictureBox1.Location = new System.Drawing.Point(-183, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 171);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // summaryButton
            // 
            this.summaryButton.Enabled = false;
            this.summaryButton.Location = new System.Drawing.Point(729, 191);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(216, 23);
            this.summaryButton.TabIndex = 4;
            this.summaryButton.Text = "&Daily Summary";
            this.toolTip1.SetToolTip(this.summaryButton, "Show\'s you Sales Daily Summary");
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // warrantyGroupBox
            // 
            this.warrantyGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.warrantyGroupBox.Controls.Add(this.fiveYearsRadioButton);
            this.warrantyGroupBox.Controls.Add(this.threeYearsRadioButton);
            this.warrantyGroupBox.Controls.Add(this.noChargeRadioButton);
            this.warrantyGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.warrantyGroupBox.Location = new System.Drawing.Point(280, 49);
            this.warrantyGroupBox.Name = "warrantyGroupBox";
            this.warrantyGroupBox.Size = new System.Drawing.Size(236, 104);
            this.warrantyGroupBox.TabIndex = 11;
            this.warrantyGroupBox.TabStop = false;
            this.warrantyGroupBox.Text = "Vehicle Warranty:";
            // 
            // fiveYearsRadioButton
            // 
            this.fiveYearsRadioButton.AutoSize = true;
            this.fiveYearsRadioButton.Location = new System.Drawing.Point(6, 81);
            this.fiveYearsRadioButton.Name = "fiveYearsRadioButton";
            this.fiveYearsRadioButton.Size = new System.Drawing.Size(109, 17);
            this.fiveYearsRadioButton.TabIndex = 2;
            this.fiveYearsRadioButton.Text = "5 Years (plus20%)";
            this.fiveYearsRadioButton.UseVisualStyleBackColor = true;
            // 
            // threeYearsRadioButton
            // 
            this.threeYearsRadioButton.AutoSize = true;
            this.threeYearsRadioButton.Location = new System.Drawing.Point(6, 58);
            this.threeYearsRadioButton.Name = "threeYearsRadioButton";
            this.threeYearsRadioButton.Size = new System.Drawing.Size(112, 17);
            this.threeYearsRadioButton.TabIndex = 1;
            this.threeYearsRadioButton.Text = "3 Years (plus 10%)";
            this.threeYearsRadioButton.UseVisualStyleBackColor = true;
            // 
            // noChargeRadioButton
            // 
            this.noChargeRadioButton.AutoSize = true;
            this.noChargeRadioButton.Checked = true;
            this.noChargeRadioButton.Location = new System.Drawing.Point(6, 35);
            this.noChargeRadioButton.Name = "noChargeRadioButton";
            this.noChargeRadioButton.Size = new System.Drawing.Size(113, 17);
            this.noChargeRadioButton.TabIndex = 0;
            this.noChargeRadioButton.TabStop = true;
            this.noChargeRadioButton.Text = "1 Year (no charge)";
            this.noChargeRadioButton.UseVisualStyleBackColor = true;
            // 
            // extrasGroupBox
            // 
            this.extrasGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.extrasGroupBox.Controls.Add(this.soundCheckBox);
            this.extrasGroupBox.Controls.Add(this.naviCheckBox);
            this.extrasGroupBox.Controls.Add(this.protectionCheckBox);
            this.extrasGroupBox.Controls.Add(this.tintingCheckBox);
            this.extrasGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.extrasGroupBox.Location = new System.Drawing.Point(280, 159);
            this.extrasGroupBox.Name = "extrasGroupBox";
            this.extrasGroupBox.Size = new System.Drawing.Size(236, 113);
            this.extrasGroupBox.TabIndex = 0;
            this.extrasGroupBox.TabStop = false;
            this.extrasGroupBox.Text = "Optional Extras:";
            // 
            // soundCheckBox
            // 
            this.soundCheckBox.AutoSize = true;
            this.soundCheckBox.Location = new System.Drawing.Point(6, 91);
            this.soundCheckBox.Name = "soundCheckBox";
            this.soundCheckBox.Size = new System.Drawing.Size(160, 17);
            this.soundCheckBox.TabIndex = 3;
            this.soundCheckBox.Text = "Deluxe Sound System: $350";
            this.soundCheckBox.UseVisualStyleBackColor = true;
            // 
            // naviCheckBox
            // 
            this.naviCheckBox.AutoSize = true;
            this.naviCheckBox.Location = new System.Drawing.Point(6, 68);
            this.naviCheckBox.Name = "naviCheckBox";
            this.naviCheckBox.Size = new System.Drawing.Size(152, 17);
            this.naviCheckBox.TabIndex = 2;
            this.naviCheckBox.Text = "Navigational System: $320";
            this.naviCheckBox.UseVisualStyleBackColor = true;
            // 
            // protectionCheckBox
            // 
            this.protectionCheckBox.AutoSize = true;
            this.protectionCheckBox.Location = new System.Drawing.Point(6, 45);
            this.protectionCheckBox.Name = "protectionCheckBox";
            this.protectionCheckBox.Size = new System.Drawing.Size(160, 17);
            this.protectionCheckBox.TabIndex = 1;
            this.protectionCheckBox.Text = "Duco Body Protection: $180";
            this.protectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // tintingCheckBox
            // 
            this.tintingCheckBox.AutoSize = true;
            this.tintingCheckBox.Location = new System.Drawing.Point(6, 22);
            this.tintingCheckBox.Name = "tintingCheckBox";
            this.tintingCheckBox.Size = new System.Drawing.Size(157, 17);
            this.tintingCheckBox.TabIndex = 0;
            this.tintingCheckBox.Text = "Total Window Tinting: $150";
            this.tintingCheckBox.UseVisualStyleBackColor = true;
            // 
            // insuranseGroupBox
            // 
            this.insuranseGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.insuranseGroupBox.Controls.Add(this.moreEqTwoFiveRadioButton);
            this.insuranseGroupBox.Controls.Add(this.lessTwoFiveRadioButton);
            this.insuranseGroupBox.Controls.Add(this.policyCheckBox);
            this.insuranseGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.insuranseGroupBox.Location = new System.Drawing.Point(280, 278);
            this.insuranseGroupBox.Name = "insuranseGroupBox";
            this.insuranseGroupBox.Size = new System.Drawing.Size(236, 116);
            this.insuranseGroupBox.TabIndex = 12;
            this.insuranseGroupBox.TabStop = false;
            this.insuranseGroupBox.Text = "Comprehensive Insuranse:";
            // 
            // moreEqTwoFiveRadioButton
            // 
            this.moreEqTwoFiveRadioButton.AutoSize = true;
            this.moreEqTwoFiveRadioButton.Enabled = false;
            this.moreEqTwoFiveRadioButton.Location = new System.Drawing.Point(6, 77);
            this.moreEqTwoFiveRadioButton.Name = "moreEqTwoFiveRadioButton";
            this.moreEqTwoFiveRadioButton.Size = new System.Drawing.Size(125, 17);
            this.moreEqTwoFiveRadioButton.TabIndex = 2;
            this.moreEqTwoFiveRadioButton.Text = "Age >= 25 (plus 10%)";
            this.moreEqTwoFiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // lessTwoFiveRadioButton
            // 
            this.lessTwoFiveRadioButton.AutoSize = true;
            this.lessTwoFiveRadioButton.Checked = true;
            this.lessTwoFiveRadioButton.Enabled = false;
            this.lessTwoFiveRadioButton.Location = new System.Drawing.Point(6, 54);
            this.lessTwoFiveRadioButton.Name = "lessTwoFiveRadioButton";
            this.lessTwoFiveRadioButton.Size = new System.Drawing.Size(119, 17);
            this.lessTwoFiveRadioButton.TabIndex = 1;
            this.lessTwoFiveRadioButton.TabStop = true;
            this.lessTwoFiveRadioButton.Text = "Age < 25 (plus 20%)";
            this.lessTwoFiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // policyCheckBox
            // 
            this.policyCheckBox.AutoSize = true;
            this.policyCheckBox.Location = new System.Drawing.Point(6, 27);
            this.policyCheckBox.Name = "policyCheckBox";
            this.policyCheckBox.Size = new System.Drawing.Size(149, 17);
            this.policyCheckBox.TabIndex = 0;
            this.policyCheckBox.Text = "Insuranse Policy [Yes/No]";
            this.policyCheckBox.UseVisualStyleBackColor = true;
            this.policyCheckBox.CheckedChanged += new System.EventHandler(this.policyCheckBox_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1075, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Brown;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem});
            this.windowToolStripMenuItem.ForeColor = System.Drawing.Color.Brown;
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "&Window";
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Enabled = false;
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.summaryToolStripMenuItem.Text = "Su&mmary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.Brown;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.detailsListBox);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(522, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 345);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sale Details:";
            // 
            // detailsListBox
            // 
            this.detailsListBox.FormattingEnabled = true;
            this.detailsListBox.Location = new System.Drawing.Point(6, 17);
            this.detailsListBox.Name = "detailsListBox";
            this.detailsListBox.Size = new System.Drawing.Size(188, 329);
            this.detailsListBox.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::MotorMgr.Properties.Resources.shift_unleashed_Pagani_Huayra_003;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.resetButton;
            this.ClientSize = new System.Drawing.Size(1075, 436);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.insuranseGroupBox);
            this.Controls.Add(this.summaryButton);
            this.Controls.Add(this.extrasGroupBox);
            this.Controls.Add(this.warrantyGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.purchaseGroupBox);
            this.Controls.Add(this.costingGroupBox);
            this.Controls.Add(this.customerGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "Ruslan Batura 4BC# Assignment";
            this.customerGroupBox.ResumeLayout(false);
            this.customerGroupBox.PerformLayout();
            this.purchaseGroupBox.ResumeLayout(false);
            this.purchaseGroupBox.PerformLayout();
            this.costingGroupBox.ResumeLayout(false);
            this.costingGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.warrantyGroupBox.ResumeLayout(false);
            this.warrantyGroupBox.PerformLayout();
            this.extrasGroupBox.ResumeLayout(false);
            this.extrasGroupBox.PerformLayout();
            this.insuranseGroupBox.ResumeLayout(false);
            this.insuranseGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox customerGroupBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.GroupBox purchaseGroupBox;
        private System.Windows.Forms.TextBox lessTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label tradeInLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.GroupBox costingGroupBox;
        private System.Windows.Forms.Label finalLabel;
        private System.Windows.Forms.Label gstLabel;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label finAmLabel;
        private System.Windows.Forms.Label gstAmLabel;
        private System.Windows.Forms.Label subAmLabel;
        private System.Windows.Forms.GroupBox warrantyGroupBox;
        private System.Windows.Forms.GroupBox extrasGroupBox;
        private System.Windows.Forms.RadioButton fiveYearsRadioButton;
        private System.Windows.Forms.RadioButton threeYearsRadioButton;
        private System.Windows.Forms.RadioButton noChargeRadioButton;
        private System.Windows.Forms.CheckBox soundCheckBox;
        private System.Windows.Forms.CheckBox naviCheckBox;
        private System.Windows.Forms.CheckBox protectionCheckBox;
        private System.Windows.Forms.CheckBox tintingCheckBox;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.GroupBox insuranseGroupBox;
        private System.Windows.Forms.RadioButton moreEqTwoFiveRadioButton;
        private System.Windows.Forms.RadioButton lessTwoFiveRadioButton;
        private System.Windows.Forms.CheckBox policyCheckBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ListBox detailsListBox;
    }
}

