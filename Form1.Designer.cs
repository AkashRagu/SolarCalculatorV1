namespace Solar4U
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
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.userIDLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.itemCountGroupBox = new System.Windows.Forms.GroupBox();
            this.inverterInputTextBox = new System.Windows.Forms.TextBox();
            this.batteryInputTextBox = new System.Windows.Forms.TextBox();
            this.panelInputTextBox = new System.Windows.Forms.TextBox();
            this.batteryCountLabel = new System.Windows.Forms.Label();
            this.inverterCountLabel = new System.Windows.Forms.Label();
            this.panelCountLabel = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.quoteButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.summaryButton = new System.Windows.Forms.Button();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.installationPercentageLabel = new System.Windows.Forms.Label();
            this.inverterPercentageLabel = new System.Windows.Forms.Label();
            this.batteryPercentageLabel = new System.Windows.Forms.Label();
            this.panelPercentageLabel = new System.Windows.Forms.Label();
            this.totalCostOutputLabel = new System.Windows.Forms.Label();
            this.installationCostOutputLabel = new System.Windows.Forms.Label();
            this.inverterCostOutputLabel = new System.Windows.Forms.Label();
            this.batteryCostOutputLabel = new System.Windows.Forms.Label();
            this.panelCostOutputLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.designLabel = new System.Windows.Forms.Label();
            this.panelCostLabel = new System.Windows.Forms.Label();
            this.batteryCostLabel = new System.Windows.Forms.Label();
            this.installatonCostLabel = new System.Windows.Forms.Label();
            this.invertorCostLabel = new System.Windows.Forms.Label();
            this.footerImage = new System.Windows.Forms.PictureBox();
            this.totalQuoteGroupBox = new System.Windows.Forms.GroupBox();
            this.quoteAverageValueLabel = new System.Windows.Forms.Label();
            this.quoteTotalValueLabel = new System.Windows.Forms.Label();
            this.totalInstallationCostlabel = new System.Windows.Forms.Label();
            this.totalInverterCostLabel = new System.Windows.Forms.Label();
            this.totalBatteryCostLabel = new System.Windows.Forms.Label();
            this.totalPanelCostLabel = new System.Windows.Forms.Label();
            this.quoteCountLabel = new System.Windows.Forms.Label();
            this.averageQuotelabel = new System.Windows.Forms.Label();
            this.installationTotalLabel = new System.Windows.Forms.Label();
            this.totalValueLabel = new System.Windows.Forms.Label();
            this.totalDividerLabel = new System.Windows.Forms.Label();
            this.quoteTotalLabel = new System.Windows.Forms.Label();
            this.panelTotalLabel = new System.Windows.Forms.Label();
            this.inverterTotalLabel = new System.Windows.Forms.Label();
            this.batteryTotalLabel = new System.Windows.Forms.Label();
            this.InformationToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.itemCountGroupBox.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.summaryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.footerImage)).BeginInit();
            this.totalQuoteGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.idBox);
            this.loginPanel.Controls.Add(this.nameBox);
            this.loginPanel.Controls.Add(this.userIDLabel);
            this.loginPanel.Controls.Add(this.userNameLabel);
            this.loginPanel.Location = new System.Drawing.Point(41, 11);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(693, 96);
            this.loginPanel.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.loginButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginButton.Location = new System.Drawing.Point(571, 28);
            this.loginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(99, 44);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "ENTER";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // idBox
            // 
            this.idBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.Location = new System.Drawing.Point(373, 37);
            this.idBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idBox.Multiline = true;
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(117, 31);
            this.idBox.TabIndex = 3;
            this.idBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(107, 37);
            this.nameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(117, 31);
            this.nameBox.TabIndex = 2;
            this.nameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userIDLabel
            // 
            this.userIDLabel.AutoSize = true;
            this.userIDLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.userIDLabel.Location = new System.Drawing.Point(272, 39);
            this.userIDLabel.Name = "userIDLabel";
            this.userIDLabel.Size = new System.Drawing.Size(87, 20);
            this.userIDLabel.TabIndex = 1;
            this.userIDLabel.Text = "Quote ID:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.userNameLabel.Location = new System.Drawing.Point(3, 39);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(89, 20);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Sales Rep:";
            // 
            // logoBox
            // 
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(245, 297);
            this.logoBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(195, 174);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 1;
            this.logoBox.TabStop = false;
            // 
            // itemCountGroupBox
            // 
            this.itemCountGroupBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.itemCountGroupBox.Controls.Add(this.inverterInputTextBox);
            this.itemCountGroupBox.Controls.Add(this.batteryInputTextBox);
            this.itemCountGroupBox.Controls.Add(this.panelInputTextBox);
            this.itemCountGroupBox.Controls.Add(this.batteryCountLabel);
            this.itemCountGroupBox.Controls.Add(this.inverterCountLabel);
            this.itemCountGroupBox.Controls.Add(this.panelCountLabel);
            this.itemCountGroupBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCountGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.itemCountGroupBox.Location = new System.Drawing.Point(101, 38);
            this.itemCountGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemCountGroupBox.Name = "itemCountGroupBox";
            this.itemCountGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemCountGroupBox.Size = new System.Drawing.Size(531, 224);
            this.itemCountGroupBox.TabIndex = 2;
            this.itemCountGroupBox.TabStop = false;
            this.itemCountGroupBox.Text = "PV System Quote";
            this.itemCountGroupBox.Visible = false;
            // 
            // inverterInputTextBox
            // 
            this.inverterInputTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inverterInputTextBox.Location = new System.Drawing.Point(341, 169);
            this.inverterInputTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inverterInputTextBox.Multiline = true;
            this.inverterInputTextBox.Name = "inverterInputTextBox";
            this.inverterInputTextBox.Size = new System.Drawing.Size(65, 38);
            this.inverterInputTextBox.TabIndex = 6;
            this.inverterInputTextBox.Text = "0";
            this.inverterInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // batteryInputTextBox
            // 
            this.batteryInputTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryInputTextBox.Location = new System.Drawing.Point(341, 102);
            this.batteryInputTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.batteryInputTextBox.Multiline = true;
            this.batteryInputTextBox.Name = "batteryInputTextBox";
            this.batteryInputTextBox.Size = new System.Drawing.Size(65, 38);
            this.batteryInputTextBox.TabIndex = 5;
            this.batteryInputTextBox.Text = "0";
            this.batteryInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelInputTextBox
            // 
            this.panelInputTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInputTextBox.Location = new System.Drawing.Point(341, 41);
            this.panelInputTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelInputTextBox.Multiline = true;
            this.panelInputTextBox.Name = "panelInputTextBox";
            this.panelInputTextBox.Size = new System.Drawing.Size(65, 36);
            this.panelInputTextBox.TabIndex = 4;
            this.panelInputTextBox.Text = "0";
            this.panelInputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // batteryCountLabel
            // 
            this.batteryCountLabel.AutoSize = true;
            this.batteryCountLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryCountLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.batteryCountLabel.Location = new System.Drawing.Point(67, 103);
            this.batteryCountLabel.Name = "batteryCountLabel";
            this.batteryCountLabel.Size = new System.Drawing.Size(155, 20);
            this.batteryCountLabel.TabIndex = 3;
            this.batteryCountLabel.Text = "No. 5KW Batteries";
            // 
            // inverterCountLabel
            // 
            this.inverterCountLabel.AutoSize = true;
            this.inverterCountLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inverterCountLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.inverterCountLabel.Location = new System.Drawing.Point(67, 171);
            this.inverterCountLabel.Name = "inverterCountLabel";
            this.inverterCountLabel.Size = new System.Drawing.Size(111, 20);
            this.inverterCountLabel.TabIndex = 2;
            this.inverterCountLabel.Text = "No. Inverters";
            // 
            // panelCountLabel
            // 
            this.panelCountLabel.AutoSize = true;
            this.panelCountLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCountLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panelCountLabel.Location = new System.Drawing.Point(67, 43);
            this.panelCountLabel.Name = "panelCountLabel";
            this.panelCountLabel.Size = new System.Drawing.Size(159, 20);
            this.panelCountLabel.TabIndex = 1;
            this.panelCountLabel.Text = "No. of Solar Panels";
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.controlPanel.Controls.Add(this.quoteButton);
            this.controlPanel.Controls.Add(this.exitButton);
            this.controlPanel.Controls.Add(this.clearButton);
            this.controlPanel.Controls.Add(this.summaryButton);
            this.controlPanel.Location = new System.Drawing.Point(101, 266);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(529, 78);
            this.controlPanel.TabIndex = 3;
            this.controlPanel.Visible = false;
            // 
            // quoteButton
            // 
            this.quoteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quoteButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quoteButton.Location = new System.Drawing.Point(20, 15);
            this.quoteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quoteButton.Name = "quoteButton";
            this.quoteButton.Size = new System.Drawing.Size(99, 44);
            this.quoteButton.TabIndex = 6;
            this.quoteButton.Text = "Quote";
            this.quoteButton.UseVisualStyleBackColor = false;
            this.quoteButton.Click += new System.EventHandler(this.quoteButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButton.Location = new System.Drawing.Point(399, 15);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 44);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearButton.Location = new System.Drawing.Point(144, 15);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(99, 44);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // summaryButton
            // 
            this.summaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.summaryButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.summaryButton.Location = new System.Drawing.Point(269, 15);
            this.summaryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(99, 44);
            this.summaryButton.TabIndex = 8;
            this.summaryButton.Text = "Summary";
            this.summaryButton.UseVisualStyleBackColor = false;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.summaryGroupBox.Controls.Add(this.installationPercentageLabel);
            this.summaryGroupBox.Controls.Add(this.inverterPercentageLabel);
            this.summaryGroupBox.Controls.Add(this.batteryPercentageLabel);
            this.summaryGroupBox.Controls.Add(this.panelPercentageLabel);
            this.summaryGroupBox.Controls.Add(this.totalCostOutputLabel);
            this.summaryGroupBox.Controls.Add(this.installationCostOutputLabel);
            this.summaryGroupBox.Controls.Add(this.inverterCostOutputLabel);
            this.summaryGroupBox.Controls.Add(this.batteryCostOutputLabel);
            this.summaryGroupBox.Controls.Add(this.panelCostOutputLabel);
            this.summaryGroupBox.Controls.Add(this.totalCostLabel);
            this.summaryGroupBox.Controls.Add(this.designLabel);
            this.summaryGroupBox.Controls.Add(this.panelCostLabel);
            this.summaryGroupBox.Controls.Add(this.batteryCostLabel);
            this.summaryGroupBox.Controls.Add(this.installatonCostLabel);
            this.summaryGroupBox.Controls.Add(this.invertorCostLabel);
            this.summaryGroupBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.summaryGroupBox.Location = new System.Drawing.Point(99, 356);
            this.summaryGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.summaryGroupBox.Size = new System.Drawing.Size(531, 348);
            this.summaryGroupBox.TabIndex = 4;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "Quote Summary";
            this.summaryGroupBox.Visible = false;
            // 
            // installationPercentageLabel
            // 
            this.installationPercentageLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.installationPercentageLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installationPercentageLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.installationPercentageLabel.Location = new System.Drawing.Point(365, 202);
            this.installationPercentageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.installationPercentageLabel.Name = "installationPercentageLabel";
            this.installationPercentageLabel.Size = new System.Drawing.Size(125, 34);
            this.installationPercentageLabel.TabIndex = 25;
            this.installationPercentageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inverterPercentageLabel
            // 
            this.inverterPercentageLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.inverterPercentageLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inverterPercentageLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inverterPercentageLabel.Location = new System.Drawing.Point(365, 148);
            this.inverterPercentageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inverterPercentageLabel.Name = "inverterPercentageLabel";
            this.inverterPercentageLabel.Size = new System.Drawing.Size(125, 34);
            this.inverterPercentageLabel.TabIndex = 24;
            this.inverterPercentageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // batteryPercentageLabel
            // 
            this.batteryPercentageLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.batteryPercentageLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryPercentageLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.batteryPercentageLabel.Location = new System.Drawing.Point(365, 94);
            this.batteryPercentageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.batteryPercentageLabel.Name = "batteryPercentageLabel";
            this.batteryPercentageLabel.Size = new System.Drawing.Size(125, 34);
            this.batteryPercentageLabel.TabIndex = 23;
            this.batteryPercentageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPercentageLabel
            // 
            this.panelPercentageLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.panelPercentageLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPercentageLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelPercentageLabel.Location = new System.Drawing.Point(365, 39);
            this.panelPercentageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panelPercentageLabel.Name = "panelPercentageLabel";
            this.panelPercentageLabel.Size = new System.Drawing.Size(125, 34);
            this.panelPercentageLabel.TabIndex = 22;
            this.panelPercentageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCostOutputLabel
            // 
            this.totalCostOutputLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.totalCostOutputLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostOutputLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalCostOutputLabel.Location = new System.Drawing.Point(216, 284);
            this.totalCostOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalCostOutputLabel.Name = "totalCostOutputLabel";
            this.totalCostOutputLabel.Size = new System.Drawing.Size(125, 34);
            this.totalCostOutputLabel.TabIndex = 21;
            this.totalCostOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // installationCostOutputLabel
            // 
            this.installationCostOutputLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.installationCostOutputLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installationCostOutputLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.installationCostOutputLabel.Location = new System.Drawing.Point(216, 202);
            this.installationCostOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.installationCostOutputLabel.Name = "installationCostOutputLabel";
            this.installationCostOutputLabel.Size = new System.Drawing.Size(125, 34);
            this.installationCostOutputLabel.TabIndex = 20;
            this.installationCostOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inverterCostOutputLabel
            // 
            this.inverterCostOutputLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.inverterCostOutputLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inverterCostOutputLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inverterCostOutputLabel.Location = new System.Drawing.Point(216, 148);
            this.inverterCostOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inverterCostOutputLabel.Name = "inverterCostOutputLabel";
            this.inverterCostOutputLabel.Size = new System.Drawing.Size(125, 34);
            this.inverterCostOutputLabel.TabIndex = 19;
            this.inverterCostOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // batteryCostOutputLabel
            // 
            this.batteryCostOutputLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.batteryCostOutputLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryCostOutputLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.batteryCostOutputLabel.Location = new System.Drawing.Point(216, 94);
            this.batteryCostOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.batteryCostOutputLabel.Name = "batteryCostOutputLabel";
            this.batteryCostOutputLabel.Size = new System.Drawing.Size(125, 34);
            this.batteryCostOutputLabel.TabIndex = 18;
            this.batteryCostOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCostOutputLabel
            // 
            this.panelCostOutputLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.panelCostOutputLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCostOutputLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelCostOutputLabel.Location = new System.Drawing.Point(216, 39);
            this.panelCostOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panelCostOutputLabel.Name = "panelCostOutputLabel";
            this.panelCostOutputLabel.Size = new System.Drawing.Size(125, 34);
            this.panelCostOutputLabel.TabIndex = 17;
            this.panelCostOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.totalCostLabel.Location = new System.Drawing.Point(16, 295);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(142, 20);
            this.totalCostLabel.TabIndex = 15;
            this.totalCostLabel.Text = "Total Cost Quote";
            // 
            // designLabel
            // 
            this.designLabel.AutoSize = true;
            this.designLabel.Location = new System.Drawing.Point(16, 241);
            this.designLabel.Name = "designLabel";
            this.designLabel.Size = new System.Drawing.Size(480, 17);
            this.designLabel.TabIndex = 14;
            this.designLabel.Text = "___________________________________________________________";
            // 
            // panelCostLabel
            // 
            this.panelCostLabel.AutoSize = true;
            this.panelCostLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCostLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panelCostLabel.Location = new System.Drawing.Point(19, 39);
            this.panelCostLabel.Name = "panelCostLabel";
            this.panelCostLabel.Size = new System.Drawing.Size(146, 20);
            this.panelCostLabel.TabIndex = 5;
            this.panelCostLabel.Text = "Cost Solar Panels";
            // 
            // batteryCostLabel
            // 
            this.batteryCostLabel.AutoSize = true;
            this.batteryCostLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryCostLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.batteryCostLabel.Location = new System.Drawing.Point(19, 94);
            this.batteryCostLabel.Name = "batteryCostLabel";
            this.batteryCostLabel.Size = new System.Drawing.Size(118, 20);
            this.batteryCostLabel.TabIndex = 4;
            this.batteryCostLabel.Text = "Cost Batteries";
            // 
            // installatonCostLabel
            // 
            this.installatonCostLabel.AutoSize = true;
            this.installatonCostLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installatonCostLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.installatonCostLabel.Location = new System.Drawing.Point(19, 204);
            this.installatonCostLabel.Name = "installatonCostLabel";
            this.installatonCostLabel.Size = new System.Drawing.Size(139, 20);
            this.installatonCostLabel.TabIndex = 3;
            this.installatonCostLabel.Text = "Cost Installation";
            // 
            // invertorCostLabel
            // 
            this.invertorCostLabel.AutoSize = true;
            this.invertorCostLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invertorCostLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.invertorCostLabel.Location = new System.Drawing.Point(16, 148);
            this.invertorCostLabel.Name = "invertorCostLabel";
            this.invertorCostLabel.Size = new System.Drawing.Size(112, 20);
            this.invertorCostLabel.TabIndex = 2;
            this.invertorCostLabel.Text = "Cost Inverter";
            // 
            // footerImage
            // 
            this.footerImage.Image = ((System.Drawing.Image)(resources.GetObject("footerImage.Image")));
            this.footerImage.Location = new System.Drawing.Point(305, 771);
            this.footerImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.footerImage.Name = "footerImage";
            this.footerImage.Size = new System.Drawing.Size(62, 55);
            this.footerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.footerImage.TabIndex = 5;
            this.footerImage.TabStop = false;
            this.footerImage.Visible = false;
            // 
            // totalQuoteGroupBox
            // 
            this.totalQuoteGroupBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.totalQuoteGroupBox.Controls.Add(this.quoteAverageValueLabel);
            this.totalQuoteGroupBox.Controls.Add(this.quoteTotalValueLabel);
            this.totalQuoteGroupBox.Controls.Add(this.totalInstallationCostlabel);
            this.totalQuoteGroupBox.Controls.Add(this.totalInverterCostLabel);
            this.totalQuoteGroupBox.Controls.Add(this.totalBatteryCostLabel);
            this.totalQuoteGroupBox.Controls.Add(this.totalPanelCostLabel);
            this.totalQuoteGroupBox.Controls.Add(this.quoteCountLabel);
            this.totalQuoteGroupBox.Controls.Add(this.averageQuotelabel);
            this.totalQuoteGroupBox.Controls.Add(this.installationTotalLabel);
            this.totalQuoteGroupBox.Controls.Add(this.totalValueLabel);
            this.totalQuoteGroupBox.Controls.Add(this.totalDividerLabel);
            this.totalQuoteGroupBox.Controls.Add(this.quoteTotalLabel);
            this.totalQuoteGroupBox.Controls.Add(this.panelTotalLabel);
            this.totalQuoteGroupBox.Controls.Add(this.inverterTotalLabel);
            this.totalQuoteGroupBox.Controls.Add(this.batteryTotalLabel);
            this.totalQuoteGroupBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalQuoteGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalQuoteGroupBox.Location = new System.Drawing.Point(135, 348);
            this.totalQuoteGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.totalQuoteGroupBox.Name = "totalQuoteGroupBox";
            this.totalQuoteGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.totalQuoteGroupBox.Size = new System.Drawing.Size(439, 419);
            this.totalQuoteGroupBox.TabIndex = 17;
            this.totalQuoteGroupBox.TabStop = false;
            this.totalQuoteGroupBox.Text = "Total Quote Summary";
            this.totalQuoteGroupBox.Visible = false;
            // 
            // quoteAverageValueLabel
            // 
            this.quoteAverageValueLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.quoteAverageValueLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteAverageValueLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quoteAverageValueLabel.Location = new System.Drawing.Point(231, 376);
            this.quoteAverageValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quoteAverageValueLabel.Name = "quoteAverageValueLabel";
            this.quoteAverageValueLabel.Size = new System.Drawing.Size(111, 34);
            this.quoteAverageValueLabel.TabIndex = 32;
            this.quoteAverageValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quoteTotalValueLabel
            // 
            this.quoteTotalValueLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.quoteTotalValueLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteTotalValueLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quoteTotalValueLabel.Location = new System.Drawing.Point(231, 329);
            this.quoteTotalValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quoteTotalValueLabel.Name = "quoteTotalValueLabel";
            this.quoteTotalValueLabel.Size = new System.Drawing.Size(111, 34);
            this.quoteTotalValueLabel.TabIndex = 31;
            this.quoteTotalValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalInstallationCostlabel
            // 
            this.totalInstallationCostlabel.BackColor = System.Drawing.SystemColors.Menu;
            this.totalInstallationCostlabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalInstallationCostlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalInstallationCostlabel.Location = new System.Drawing.Point(231, 251);
            this.totalInstallationCostlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalInstallationCostlabel.Name = "totalInstallationCostlabel";
            this.totalInstallationCostlabel.Size = new System.Drawing.Size(111, 34);
            this.totalInstallationCostlabel.TabIndex = 30;
            this.totalInstallationCostlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalInverterCostLabel
            // 
            this.totalInverterCostLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.totalInverterCostLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalInverterCostLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalInverterCostLabel.Location = new System.Drawing.Point(231, 198);
            this.totalInverterCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalInverterCostLabel.Name = "totalInverterCostLabel";
            this.totalInverterCostLabel.Size = new System.Drawing.Size(111, 34);
            this.totalInverterCostLabel.TabIndex = 29;
            this.totalInverterCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalBatteryCostLabel
            // 
            this.totalBatteryCostLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.totalBatteryCostLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBatteryCostLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalBatteryCostLabel.Location = new System.Drawing.Point(231, 142);
            this.totalBatteryCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalBatteryCostLabel.Name = "totalBatteryCostLabel";
            this.totalBatteryCostLabel.Size = new System.Drawing.Size(111, 34);
            this.totalBatteryCostLabel.TabIndex = 28;
            this.totalBatteryCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalPanelCostLabel
            // 
            this.totalPanelCostLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.totalPanelCostLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPanelCostLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalPanelCostLabel.Location = new System.Drawing.Point(231, 87);
            this.totalPanelCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalPanelCostLabel.Name = "totalPanelCostLabel";
            this.totalPanelCostLabel.Size = new System.Drawing.Size(111, 34);
            this.totalPanelCostLabel.TabIndex = 27;
            this.totalPanelCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quoteCountLabel
            // 
            this.quoteCountLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.quoteCountLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteCountLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quoteCountLabel.Location = new System.Drawing.Point(231, 33);
            this.quoteCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quoteCountLabel.Name = "quoteCountLabel";
            this.quoteCountLabel.Size = new System.Drawing.Size(111, 34);
            this.quoteCountLabel.TabIndex = 26;
            this.quoteCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageQuotelabel
            // 
            this.averageQuotelabel.AutoSize = true;
            this.averageQuotelabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageQuotelabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.averageQuotelabel.Location = new System.Drawing.Point(23, 383);
            this.averageQuotelabel.Name = "averageQuotelabel";
            this.averageQuotelabel.Size = new System.Drawing.Size(172, 20);
            this.averageQuotelabel.TabIndex = 19;
            this.averageQuotelabel.Text = "Average Quote Value";
            // 
            // installationTotalLabel
            // 
            this.installationTotalLabel.AutoSize = true;
            this.installationTotalLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installationTotalLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.installationTotalLabel.Location = new System.Drawing.Point(23, 257);
            this.installationTotalLabel.Name = "installationTotalLabel";
            this.installationTotalLabel.Size = new System.Drawing.Size(139, 20);
            this.installationTotalLabel.TabIndex = 17;
            this.installationTotalLabel.Text = "Cost Installation";
            // 
            // totalValueLabel
            // 
            this.totalValueLabel.AutoSize = true;
            this.totalValueLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalValueLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.totalValueLabel.Location = new System.Drawing.Point(23, 336);
            this.totalValueLabel.Name = "totalValueLabel";
            this.totalValueLabel.Size = new System.Drawing.Size(149, 20);
            this.totalValueLabel.TabIndex = 15;
            this.totalValueLabel.Text = "Total Quote Value";
            // 
            // totalDividerLabel
            // 
            this.totalDividerLabel.AutoSize = true;
            this.totalDividerLabel.Location = new System.Drawing.Point(17, 298);
            this.totalDividerLabel.Name = "totalDividerLabel";
            this.totalDividerLabel.Size = new System.Drawing.Size(400, 17);
            this.totalDividerLabel.TabIndex = 14;
            this.totalDividerLabel.Text = "_________________________________________________";
            // 
            // quoteTotalLabel
            // 
            this.quoteTotalLabel.AutoSize = true;
            this.quoteTotalLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteTotalLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.quoteTotalLabel.Location = new System.Drawing.Point(23, 39);
            this.quoteTotalLabel.Name = "quoteTotalLabel";
            this.quoteTotalLabel.Size = new System.Drawing.Size(156, 21);
            this.quoteTotalLabel.TabIndex = 5;
            this.quoteTotalLabel.Text = "Total No. of Quotes";
            // 
            // panelTotalLabel
            // 
            this.panelTotalLabel.AutoSize = true;
            this.panelTotalLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTotalLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panelTotalLabel.Location = new System.Drawing.Point(19, 94);
            this.panelTotalLabel.Name = "panelTotalLabel";
            this.panelTotalLabel.Size = new System.Drawing.Size(146, 20);
            this.panelTotalLabel.TabIndex = 4;
            this.panelTotalLabel.Text = "Cost Solar Panels";
            // 
            // inverterTotalLabel
            // 
            this.inverterTotalLabel.AutoSize = true;
            this.inverterTotalLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inverterTotalLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.inverterTotalLabel.Location = new System.Drawing.Point(19, 204);
            this.inverterTotalLabel.Name = "inverterTotalLabel";
            this.inverterTotalLabel.Size = new System.Drawing.Size(119, 20);
            this.inverterTotalLabel.TabIndex = 3;
            this.inverterTotalLabel.Text = "Cost Inverters";
            // 
            // batteryTotalLabel
            // 
            this.batteryTotalLabel.AutoSize = true;
            this.batteryTotalLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryTotalLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.batteryTotalLabel.Location = new System.Drawing.Point(16, 148);
            this.batteryTotalLabel.Name = "batteryTotalLabel";
            this.batteryTotalLabel.Size = new System.Drawing.Size(118, 20);
            this.batteryTotalLabel.TabIndex = 2;
            this.batteryTotalLabel.Text = "Cost Batteries";
            // 
            // InformationToolTip
            // 
            this.InformationToolTip.BackColor = System.Drawing.SystemColors.Highlight;
            this.InformationToolTip.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.InformationToolTip.IsBalloon = true;
            this.InformationToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.InformationToolTip.ToolTipTitle = "Info";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 864);
            this.Controls.Add(this.totalQuoteGroupBox);
            this.Controls.Add(this.footerImage);
            this.Controls.Add(this.summaryGroupBox);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.itemCountGroupBox);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.loginPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainForm";
            this.Text = "Solar4U Sales Quote Calculator";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.itemCountGroupBox.ResumeLayout(false);
            this.itemCountGroupBox.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.footerImage)).EndInit();
            this.totalQuoteGroupBox.ResumeLayout(false);
            this.totalQuoteGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label userIDLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.GroupBox itemCountGroupBox;
        private System.Windows.Forms.Label batteryCountLabel;
        private System.Windows.Forms.Label inverterCountLabel;
        private System.Windows.Forms.Label panelCountLabel;
        private System.Windows.Forms.TextBox inverterInputTextBox;
        private System.Windows.Forms.TextBox batteryInputTextBox;
        private System.Windows.Forms.TextBox panelInputTextBox;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button quoteButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.GroupBox summaryGroupBox;
        private System.Windows.Forms.Label panelCostLabel;
        private System.Windows.Forms.Label batteryCostLabel;
        private System.Windows.Forms.Label installatonCostLabel;
        private System.Windows.Forms.Label invertorCostLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label designLabel;
        private System.Windows.Forms.PictureBox footerImage;
        private System.Windows.Forms.GroupBox totalQuoteGroupBox;
        private System.Windows.Forms.Label totalValueLabel;
        private System.Windows.Forms.Label totalDividerLabel;
        private System.Windows.Forms.Label quoteTotalLabel;
        private System.Windows.Forms.Label panelTotalLabel;
        private System.Windows.Forms.Label inverterTotalLabel;
        private System.Windows.Forms.Label batteryTotalLabel;
        private System.Windows.Forms.Label installationTotalLabel;
        private System.Windows.Forms.Label averageQuotelabel;
        private System.Windows.Forms.Label panelCostOutputLabel;
        private System.Windows.Forms.Label batteryCostOutputLabel;
        private System.Windows.Forms.Label inverterCostOutputLabel;
        private System.Windows.Forms.Label installationCostOutputLabel;
        private System.Windows.Forms.Label totalCostOutputLabel;
        private System.Windows.Forms.Label panelPercentageLabel;
        private System.Windows.Forms.Label batteryPercentageLabel;
        private System.Windows.Forms.Label inverterPercentageLabel;
        private System.Windows.Forms.Label installationPercentageLabel;
        private System.Windows.Forms.Label quoteAverageValueLabel;
        private System.Windows.Forms.Label quoteTotalValueLabel;
        private System.Windows.Forms.Label totalInstallationCostlabel;
        private System.Windows.Forms.Label totalInverterCostLabel;
        private System.Windows.Forms.Label totalBatteryCostLabel;
        private System.Windows.Forms.Label totalPanelCostLabel;
        private System.Windows.Forms.Label quoteCountLabel;
        private System.Windows.Forms.ToolTip InformationToolTip;
    }
}

