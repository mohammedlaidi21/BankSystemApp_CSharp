namespace BankSystem_Currencies
{
    partial class frmCurrencyExchange
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
            this.tcCurrencies = new System.Windows.Forms.TabControl();
            this.tpShowCurrencies = new System.Windows.Forms.TabPage();
            this.lblCountCurrency = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchCurrency = new System.Windows.Forms.TextBox();
            this.dgvCurrencies = new System.Windows.Forms.DataGridView();
            this.tpUpdateRate = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdateRate = new System.Windows.Forms.Button();
            this.nudNewRate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCurrencyCode = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblRateTo = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblNameTo = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblCodeTo = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblCountryTo = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRateFrom = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblNameFrom = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblCodeFrom = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblCountryFrom = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbConvertTo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbConvertFrom = new System.Windows.Forms.ComboBox();
            this.nupAmountToExchange = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.tcCurrencies.SuspendLayout();
            this.tpShowCurrencies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrencies)).BeginInit();
            this.tpUpdateRate.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewRate)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAmountToExchange)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCurrencies
            // 
            this.tcCurrencies.Controls.Add(this.tpShowCurrencies);
            this.tcCurrencies.Controls.Add(this.tpUpdateRate);
            this.tcCurrencies.Controls.Add(this.tabPage1);
            this.tcCurrencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCurrencies.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.tcCurrencies.Location = new System.Drawing.Point(0, 0);
            this.tcCurrencies.Name = "tcCurrencies";
            this.tcCurrencies.SelectedIndex = 0;
            this.tcCurrencies.Size = new System.Drawing.Size(1065, 681);
            this.tcCurrencies.TabIndex = 9;
            // 
            // tpShowCurrencies
            // 
            this.tpShowCurrencies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.tpShowCurrencies.Controls.Add(this.lblCountCurrency);
            this.tpShowCurrencies.Controls.Add(this.label2);
            this.tpShowCurrencies.Controls.Add(this.label1);
            this.tpShowCurrencies.Controls.Add(this.txtSearchCurrency);
            this.tpShowCurrencies.Controls.Add(this.dgvCurrencies);
            this.tpShowCurrencies.Location = new System.Drawing.Point(4, 37);
            this.tpShowCurrencies.Name = "tpShowCurrencies";
            this.tpShowCurrencies.Padding = new System.Windows.Forms.Padding(3);
            this.tpShowCurrencies.Size = new System.Drawing.Size(1057, 640);
            this.tpShowCurrencies.TabIndex = 0;
            this.tpShowCurrencies.Text = "Show Currencies";
            // 
            // lblCountCurrency
            // 
            this.lblCountCurrency.AutoSize = true;
            this.lblCountCurrency.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountCurrency.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblCountCurrency.Location = new System.Drawing.Point(44, 155);
            this.lblCountCurrency.Name = "lblCountCurrency";
            this.lblCountCurrency.Size = new System.Drawing.Size(26, 30);
            this.lblCountCurrency.TabIndex = 13;
            this.lblCountCurrency.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(80, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Currency (ies) Found";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(31, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search Currency By Country/Code";
            // 
            // txtSearchCurrency
            // 
            this.txtSearchCurrency.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCurrency.Location = new System.Drawing.Point(32, 91);
            this.txtSearchCurrency.Multiline = true;
            this.txtSearchCurrency.Name = "txtSearchCurrency";
            this.txtSearchCurrency.Size = new System.Drawing.Size(366, 39);
            this.txtSearchCurrency.TabIndex = 10;
            this.txtSearchCurrency.TextChanged += new System.EventHandler(this.txtSearchCurrency_TextChanged);
            // 
            // dgvCurrencies
            // 
            this.dgvCurrencies.AllowUserToAddRows = false;
            this.dgvCurrencies.AllowUserToDeleteRows = false;
            this.dgvCurrencies.AllowUserToOrderColumns = true;
            this.dgvCurrencies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCurrencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrencies.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCurrencies.Location = new System.Drawing.Point(3, 274);
            this.dgvCurrencies.Name = "dgvCurrencies";
            this.dgvCurrencies.ReadOnly = true;
            this.dgvCurrencies.RowHeadersWidth = 62;
            this.dgvCurrencies.RowTemplate.Height = 28;
            this.dgvCurrencies.Size = new System.Drawing.Size(1051, 363);
            this.dgvCurrencies.TabIndex = 9;
            // 
            // tpUpdateRate
            // 
            this.tpUpdateRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.tpUpdateRate.Controls.Add(this.panel1);
            this.tpUpdateRate.Controls.Add(this.btnUpdateRate);
            this.tpUpdateRate.Controls.Add(this.nudNewRate);
            this.tpUpdateRate.Controls.Add(this.label4);
            this.tpUpdateRate.Controls.Add(this.label3);
            this.tpUpdateRate.Controls.Add(this.cbCurrencyCode);
            this.tpUpdateRate.Location = new System.Drawing.Point(4, 37);
            this.tpUpdateRate.Name = "tpUpdateRate";
            this.tpUpdateRate.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdateRate.Size = new System.Drawing.Size(1057, 640);
            this.tpUpdateRate.TabIndex = 1;
            this.tpUpdateRate.Text = "Update Rate";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRate);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblCode);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblCountry);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(425, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 290);
            this.panel1.TabIndex = 16;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRate.Location = new System.Drawing.Point(80, 229);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(69, 36);
            this.lblRate.TabIndex = 7;
            this.lblRate.Text = "($0)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.LightGray;
            this.label11.Location = new System.Drawing.Point(21, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 32);
            this.label11.TabIndex = 6;
            this.label11.Text = "Rate";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblName.Location = new System.Drawing.Point(99, 168);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 36);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "???";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(21, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 32);
            this.label9.TabIndex = 4;
            this.label9.Text = "Name: ";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCode.Location = new System.Drawing.Point(91, 106);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(48, 36);
            this.lblCode.TabIndex = 3;
            this.lblCode.Text = "???";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(21, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "Code: ";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.lblCountry.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCountry.Location = new System.Drawing.Point(111, 44);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(40, 30);
            this.lblCountry.TabIndex = 1;
            this.lblCountry.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(21, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Country: ";
            // 
            // btnUpdateRate
            // 
            this.btnUpdateRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.btnUpdateRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateRate.Location = new System.Drawing.Point(70, 418);
            this.btnUpdateRate.Name = "btnUpdateRate";
            this.btnUpdateRate.Size = new System.Drawing.Size(222, 65);
            this.btnUpdateRate.TabIndex = 15;
            this.btnUpdateRate.Text = "Update Rate";
            this.btnUpdateRate.UseVisualStyleBackColor = false;
            this.btnUpdateRate.Click += new System.EventHandler(this.btnUpdateRate_Click_1);
            // 
            // nudNewRate
            // 
            this.nudNewRate.DecimalPlaces = 6;
            this.nudNewRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNewRate.Location = new System.Drawing.Point(88, 277);
            this.nudNewRate.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.nudNewRate.Name = "nudNewRate";
            this.nudNewRate.Size = new System.Drawing.Size(204, 39);
            this.nudNewRate.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(82, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "New Rate ($)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(47, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Currency Code";
            // 
            // cbCurrencyCode
            // 
            this.cbCurrencyCode.FormattingEnabled = true;
            this.cbCurrencyCode.IntegralHeight = false;
            this.cbCurrencyCode.Location = new System.Drawing.Point(53, 85);
            this.cbCurrencyCode.MaxDropDownItems = 5;
            this.cbCurrencyCode.Name = "cbCurrencyCode";
            this.cbCurrencyCode.Size = new System.Drawing.Size(266, 36);
            this.cbCurrencyCode.TabIndex = 0;
            this.cbCurrencyCode.SelectedIndexChanged += new System.EventHandler(this.cbCurrencyCode_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.tabPage1.Controls.Add(this.lblResult);
            this.tabPage1.Controls.Add(this.btnConvert);
            this.tabPage1.Controls.Add(this.nupAmountToExchange);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.cbConvertTo);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cbConvertFrom);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1057, 640);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Currency Calculator";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblRateTo);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.lblNameTo);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.lblCodeTo);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.lblCountryTo);
            this.panel3.Controls.Add(this.label26);
            this.panel3.Location = new System.Drawing.Point(402, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 241);
            this.panel3.TabIndex = 18;
            // 
            // lblRateTo
            // 
            this.lblRateTo.AutoSize = true;
            this.lblRateTo.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRateTo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRateTo.Location = new System.Drawing.Point(73, 176);
            this.lblRateTo.Name = "lblRateTo";
            this.lblRateTo.Size = new System.Drawing.Size(69, 36);
            this.lblRateTo.TabIndex = 7;
            this.lblRateTo.Text = "($0)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.LightGray;
            this.label20.Location = new System.Drawing.Point(14, 177);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 32);
            this.label20.TabIndex = 6;
            this.label20.Text = "Rate";
            // 
            // lblNameTo
            // 
            this.lblNameTo.AutoSize = true;
            this.lblNameTo.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameTo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNameTo.Location = new System.Drawing.Point(92, 125);
            this.lblNameTo.Name = "lblNameTo";
            this.lblNameTo.Size = new System.Drawing.Size(48, 36);
            this.lblNameTo.TabIndex = 5;
            this.lblNameTo.Text = "???";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label22.ForeColor = System.Drawing.Color.LightGray;
            this.label22.Location = new System.Drawing.Point(14, 125);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(92, 32);
            this.label22.TabIndex = 4;
            this.label22.Text = "Name: ";
            // 
            // lblCodeTo
            // 
            this.lblCodeTo.AutoSize = true;
            this.lblCodeTo.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeTo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCodeTo.Location = new System.Drawing.Point(91, 70);
            this.lblCodeTo.Name = "lblCodeTo";
            this.lblCodeTo.Size = new System.Drawing.Size(48, 36);
            this.lblCodeTo.TabIndex = 3;
            this.lblCodeTo.Text = "???";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label24.ForeColor = System.Drawing.Color.LightGray;
            this.label24.Location = new System.Drawing.Point(14, 70);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 32);
            this.label24.TabIndex = 2;
            this.label24.Text = "Code: ";
            // 
            // lblCountryTo
            // 
            this.lblCountryTo.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.lblCountryTo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCountryTo.Location = new System.Drawing.Point(105, 20);
            this.lblCountryTo.Name = "lblCountryTo";
            this.lblCountryTo.Size = new System.Drawing.Size(183, 50);
            this.lblCountryTo.TabIndex = 1;
            this.lblCountryTo.Text = "???";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label26.ForeColor = System.Drawing.Color.LightGray;
            this.label26.Location = new System.Drawing.Point(15, 18);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(105, 30);
            this.label26.TabIndex = 0;
            this.label26.Text = "Country: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblRateFrom);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lblNameFrom);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.lblCodeFrom);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.lblCountryFrom);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Location = new System.Drawing.Point(29, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 241);
            this.panel2.TabIndex = 17;
            // 
            // lblRateFrom
            // 
            this.lblRateFrom.AutoSize = true;
            this.lblRateFrom.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRateFrom.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRateFrom.Location = new System.Drawing.Point(73, 176);
            this.lblRateFrom.Name = "lblRateFrom";
            this.lblRateFrom.Size = new System.Drawing.Size(69, 36);
            this.lblRateFrom.TabIndex = 7;
            this.lblRateFrom.Text = "($0)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.LightGray;
            this.label12.Location = new System.Drawing.Point(14, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 32);
            this.label12.TabIndex = 6;
            this.label12.Text = "Rate";
            // 
            // lblNameFrom
            // 
            this.lblNameFrom.AutoSize = true;
            this.lblNameFrom.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFrom.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNameFrom.Location = new System.Drawing.Point(92, 125);
            this.lblNameFrom.Name = "lblNameFrom";
            this.lblNameFrom.Size = new System.Drawing.Size(48, 36);
            this.lblNameFrom.TabIndex = 5;
            this.lblNameFrom.Text = "???";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.LightGray;
            this.label14.Location = new System.Drawing.Point(14, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 32);
            this.label14.TabIndex = 4;
            this.label14.Text = "Name: ";
            // 
            // lblCodeFrom
            // 
            this.lblCodeFrom.AutoSize = true;
            this.lblCodeFrom.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeFrom.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCodeFrom.Location = new System.Drawing.Point(91, 70);
            this.lblCodeFrom.Name = "lblCodeFrom";
            this.lblCodeFrom.Size = new System.Drawing.Size(48, 36);
            this.lblCodeFrom.TabIndex = 3;
            this.lblCodeFrom.Text = "???";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.LightGray;
            this.label16.Location = new System.Drawing.Point(14, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 32);
            this.label16.TabIndex = 2;
            this.label16.Text = "Code: ";
            // 
            // lblCountryFrom
            // 
            this.lblCountryFrom.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold);
            this.lblCountryFrom.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCountryFrom.Location = new System.Drawing.Point(105, 20);
            this.lblCountryFrom.Name = "lblCountryFrom";
            this.lblCountryFrom.Size = new System.Drawing.Size(181, 50);
            this.lblCountryFrom.TabIndex = 1;
            this.lblCountryFrom.Text = "???";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.LightGray;
            this.label18.Location = new System.Drawing.Point(15, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 30);
            this.label18.TabIndex = 0;
            this.label18.Text = "Country: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(396, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "Convert To";
            // 
            // cbConvertTo
            // 
            this.cbConvertTo.FormattingEnabled = true;
            this.cbConvertTo.IntegralHeight = false;
            this.cbConvertTo.Location = new System.Drawing.Point(402, 47);
            this.cbConvertTo.MaxDropDownItems = 5;
            this.cbConvertTo.Name = "cbConvertTo";
            this.cbConvertTo.Size = new System.Drawing.Size(266, 36);
            this.cbConvertTo.TabIndex = 15;
            this.cbConvertTo.SelectedIndexChanged += new System.EventHandler(this.cbConverts_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(43, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Convert From";
            // 
            // cbConvertFrom
            // 
            this.cbConvertFrom.FormattingEnabled = true;
            this.cbConvertFrom.IntegralHeight = false;
            this.cbConvertFrom.Location = new System.Drawing.Point(49, 47);
            this.cbConvertFrom.MaxDropDownItems = 5;
            this.cbConvertFrom.Name = "cbConvertFrom";
            this.cbConvertFrom.Size = new System.Drawing.Size(266, 36);
            this.cbConvertFrom.TabIndex = 13;
            this.cbConvertFrom.SelectedIndexChanged += new System.EventHandler(this.cbConverts_SelectedIndexChanged);
            // 
            // nupAmountToExchange
            // 
            this.nupAmountToExchange.DecimalPlaces = 6;
            this.nupAmountToExchange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupAmountToExchange.Location = new System.Drawing.Point(235, 374);
            this.nupAmountToExchange.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.nupAmountToExchange.Name = "nupAmountToExchange";
            this.nupAmountToExchange.Size = new System.Drawing.Size(274, 39);
            this.nupAmountToExchange.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(229, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(251, 32);
            this.label10.TabIndex = 19;
            this.label10.Text = "Amount To Exchange";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConvert.Location = new System.Drawing.Point(258, 435);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(222, 65);
            this.btnConvert.TabIndex = 21;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblResult.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResult.Location = new System.Drawing.Point(267, 524);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(213, 38);
            this.lblResult.TabIndex = 22;
            this.lblResult.Text = "1 USD = 1 USD";
            // 
            // frmCurrencyExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1065, 681);
            this.Controls.Add(this.tcCurrencies);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCurrencyExchange";
            this.Text = "frmCurrencyExchange";
            this.Load += new System.EventHandler(this.frmCurrencyExchange_Load);
            this.tcCurrencies.ResumeLayout(false);
            this.tpShowCurrencies.ResumeLayout(false);
            this.tpShowCurrencies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrencies)).EndInit();
            this.tpUpdateRate.ResumeLayout(false);
            this.tpUpdateRate.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewRate)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAmountToExchange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcCurrencies;
        private System.Windows.Forms.TabPage tpShowCurrencies;
        private System.Windows.Forms.Label lblCountCurrency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchCurrency;
        private System.Windows.Forms.DataGridView dgvCurrencies;
        private System.Windows.Forms.TabPage tpUpdateRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCurrencyCode;
        private System.Windows.Forms.Button btnUpdateRate;
        private System.Windows.Forms.NumericUpDown nudNewRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbConvertTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbConvertFrom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblRateTo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblNameTo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblCodeTo;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblCountryTo;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRateFrom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblNameFrom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblCodeFrom;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblCountryFrom;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.NumericUpDown nupAmountToExchange;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblResult;
    }
}