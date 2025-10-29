namespace BankSystem_Currencies
{
    partial class frmClientsTransactions
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
            this.tcTransfer = new System.Windows.Forms.TabControl();
            this.tpDeposit = new System.Windows.Forms.TabPage();
            this.btnClearDepositData = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.nudAmountDeposit = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBalanceDeposit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAccountNumbersDeposit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpWithdraw = new System.Windows.Forms.TabPage();
            this.btnClearWithdrawData = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.nudAmountWithdraw = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBalanceWithdraw = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAccountNumbersWithdraw = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTotalBalances = new System.Windows.Forms.TabPage();
            this.lblNumberToText = new System.Windows.Forms.Label();
            this.dgvTotalBalances = new System.Windows.Forms.DataGridView();
            this.lblClientsCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchAccNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalBalanes = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTransferBalances = new System.Windows.Forms.TabPage();
            this.lblBalanceAccTo = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblBalanceAccFrom = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.nudTransferAmount = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.cbAccNumberTo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbAccNumberFrom = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTransferLog = new System.Windows.Forms.TabPage();
            this.lblTransferCount = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSearchTransfer = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvTransfers = new System.Windows.Forms.DataGridView();
            this.epTransactions = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcTransfer.SuspendLayout();
            this.tpDeposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountDeposit)).BeginInit();
            this.tpWithdraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountWithdraw)).BeginInit();
            this.tbTotalBalances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalBalances)).BeginInit();
            this.tbTransferBalances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTransferAmount)).BeginInit();
            this.tbTransferLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransfers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // tcTransfer
            // 
            this.tcTransfer.Controls.Add(this.tpDeposit);
            this.tcTransfer.Controls.Add(this.tpWithdraw);
            this.tcTransfer.Controls.Add(this.tbTotalBalances);
            this.tcTransfer.Controls.Add(this.tbTransferBalances);
            this.tcTransfer.Controls.Add(this.tbTransferLog);
            this.tcTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTransfer.Location = new System.Drawing.Point(0, 0);
            this.tcTransfer.Name = "tcTransfer";
            this.tcTransfer.SelectedIndex = 0;
            this.tcTransfer.Size = new System.Drawing.Size(1032, 622);
            this.tcTransfer.TabIndex = 0;
            // 
            // tpDeposit
            // 
            this.tpDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.tpDeposit.Controls.Add(this.btnClearDepositData);
            this.tpDeposit.Controls.Add(this.btnDeposit);
            this.tpDeposit.Controls.Add(this.nudAmountDeposit);
            this.tpDeposit.Controls.Add(this.label4);
            this.tpDeposit.Controls.Add(this.lblBalanceDeposit);
            this.tpDeposit.Controls.Add(this.label2);
            this.tpDeposit.Controls.Add(this.cbAccountNumbersDeposit);
            this.tpDeposit.Controls.Add(this.label1);
            this.tpDeposit.Location = new System.Drawing.Point(4, 41);
            this.tpDeposit.Name = "tpDeposit";
            this.tpDeposit.Padding = new System.Windows.Forms.Padding(3);
            this.tpDeposit.Size = new System.Drawing.Size(1024, 577);
            this.tpDeposit.TabIndex = 0;
            this.tpDeposit.Text = "Deposit";
            // 
            // btnClearDepositData
            // 
            this.btnClearDepositData.BackColor = System.Drawing.Color.Transparent;
            this.btnClearDepositData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearDepositData.Font = new System.Drawing.Font("Verdana", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDepositData.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClearDepositData.Location = new System.Drawing.Point(319, 429);
            this.btnClearDepositData.Name = "btnClearDepositData";
            this.btnClearDepositData.Size = new System.Drawing.Size(171, 58);
            this.btnClearDepositData.TabIndex = 11;
            this.btnClearDepositData.Text = "Clear";
            this.btnClearDepositData.UseVisualStyleBackColor = false;
            this.btnClearDepositData.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.Transparent;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeposit.Font = new System.Drawing.Font("Verdana", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeposit.Location = new System.Drawing.Point(100, 429);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(171, 58);
            this.btnDeposit.TabIndex = 10;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // nudAmountDeposit
            // 
            this.nudAmountDeposit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAmountDeposit.Location = new System.Drawing.Point(89, 320);
            this.nudAmountDeposit.Maximum = new decimal(new int[] {
            -469762048,
            -590869294,
            5421010,
            0});
            this.nudAmountDeposit.Name = "nudAmountDeposit";
            this.nudAmountDeposit.Size = new System.Drawing.Size(252, 39);
            this.nudAmountDeposit.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.label4.Location = new System.Drawing.Point(83, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Deposit Amount";
            // 
            // lblBalanceDeposit
            // 
            this.lblBalanceDeposit.AutoSize = true;
            this.lblBalanceDeposit.Font = new System.Drawing.Font("Segoe UI Black", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.lblBalanceDeposit.Location = new System.Drawing.Point(288, 180);
            this.lblBalanceDeposit.Name = "lblBalanceDeposit";
            this.lblBalanceDeposit.Size = new System.Drawing.Size(51, 38);
            this.lblBalanceDeposit.TabIndex = 7;
            this.lblBalanceDeposit.Text = "$0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(83, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Current Balance is: ";
            // 
            // cbAccountNumbersDeposit
            // 
            this.cbAccountNumbersDeposit.FormattingEnabled = true;
            this.cbAccountNumbersDeposit.Location = new System.Drawing.Point(89, 101);
            this.cbAccountNumbersDeposit.Name = "cbAccountNumbersDeposit";
            this.cbAccountNumbersDeposit.Size = new System.Drawing.Size(265, 40);
            this.cbAccountNumbersDeposit.TabIndex = 5;
            this.cbAccountNumbersDeposit.SelectedIndexChanged += new System.EventHandler(this.cbAccountNumbers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(83, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Account Number";
            // 
            // tpWithdraw
            // 
            this.tpWithdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.tpWithdraw.Controls.Add(this.btnClearWithdrawData);
            this.tpWithdraw.Controls.Add(this.btnWithdraw);
            this.tpWithdraw.Controls.Add(this.nudAmountWithdraw);
            this.tpWithdraw.Controls.Add(this.label3);
            this.tpWithdraw.Controls.Add(this.lblBalanceWithdraw);
            this.tpWithdraw.Controls.Add(this.label6);
            this.tpWithdraw.Controls.Add(this.cbAccountNumbersWithdraw);
            this.tpWithdraw.Controls.Add(this.label7);
            this.tpWithdraw.Location = new System.Drawing.Point(4, 41);
            this.tpWithdraw.Name = "tpWithdraw";
            this.tpWithdraw.Padding = new System.Windows.Forms.Padding(3);
            this.tpWithdraw.Size = new System.Drawing.Size(1024, 577);
            this.tpWithdraw.TabIndex = 1;
            this.tpWithdraw.Text = "Withdraw";
            // 
            // btnClearWithdrawData
            // 
            this.btnClearWithdrawData.BackColor = System.Drawing.Color.Transparent;
            this.btnClearWithdrawData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearWithdrawData.Font = new System.Drawing.Font("Verdana", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearWithdrawData.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClearWithdrawData.Location = new System.Drawing.Point(308, 413);
            this.btnClearWithdrawData.Name = "btnClearWithdrawData";
            this.btnClearWithdrawData.Size = new System.Drawing.Size(171, 58);
            this.btnClearWithdrawData.TabIndex = 19;
            this.btnClearWithdrawData.Text = "Clear";
            this.btnClearWithdrawData.UseVisualStyleBackColor = false;
            this.btnClearWithdrawData.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.Transparent;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWithdraw.Font = new System.Drawing.Font("Verdana", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnWithdraw.Location = new System.Drawing.Point(89, 413);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(183, 58);
            this.btnWithdraw.TabIndex = 18;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // nudAmountWithdraw
            // 
            this.nudAmountWithdraw.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAmountWithdraw.Location = new System.Drawing.Point(78, 304);
            this.nudAmountWithdraw.Maximum = new decimal(new int[] {
            -469762048,
            -590869294,
            5421010,
            0});
            this.nudAmountWithdraw.Name = "nudAmountWithdraw";
            this.nudAmountWithdraw.Size = new System.Drawing.Size(252, 39);
            this.nudAmountWithdraw.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.label3.Location = new System.Drawing.Point(72, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Withdraw Amount";
            // 
            // lblBalanceWithdraw
            // 
            this.lblBalanceWithdraw.AutoSize = true;
            this.lblBalanceWithdraw.Font = new System.Drawing.Font("Segoe UI Black", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceWithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.lblBalanceWithdraw.Location = new System.Drawing.Point(277, 164);
            this.lblBalanceWithdraw.Name = "lblBalanceWithdraw";
            this.lblBalanceWithdraw.Size = new System.Drawing.Size(51, 38);
            this.lblBalanceWithdraw.TabIndex = 15;
            this.lblBalanceWithdraw.Text = "$0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(72, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Current Balance is: ";
            // 
            // cbAccountNumbersWithdraw
            // 
            this.cbAccountNumbersWithdraw.FormattingEnabled = true;
            this.cbAccountNumbersWithdraw.Location = new System.Drawing.Point(78, 85);
            this.cbAccountNumbersWithdraw.Name = "cbAccountNumbersWithdraw";
            this.cbAccountNumbersWithdraw.Size = new System.Drawing.Size(265, 40);
            this.cbAccountNumbersWithdraw.TabIndex = 13;
            this.cbAccountNumbersWithdraw.SelectedIndexChanged += new System.EventHandler(this.cbAccountNumbers_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.label7.Location = new System.Drawing.Point(72, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Account Number";
            // 
            // tbTotalBalances
            // 
            this.tbTotalBalances.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.tbTotalBalances.Controls.Add(this.lblNumberToText);
            this.tbTotalBalances.Controls.Add(this.dgvTotalBalances);
            this.tbTotalBalances.Controls.Add(this.lblClientsCount);
            this.tbTotalBalances.Controls.Add(this.label9);
            this.tbTotalBalances.Controls.Add(this.txtSearchAccNumber);
            this.tbTotalBalances.Controls.Add(this.label8);
            this.tbTotalBalances.Controls.Add(this.lblTotalBalanes);
            this.tbTotalBalances.Controls.Add(this.label5);
            this.tbTotalBalances.Location = new System.Drawing.Point(4, 41);
            this.tbTotalBalances.Name = "tbTotalBalances";
            this.tbTotalBalances.Padding = new System.Windows.Forms.Padding(3);
            this.tbTotalBalances.Size = new System.Drawing.Size(1024, 577);
            this.tbTotalBalances.TabIndex = 2;
            this.tbTotalBalances.Text = "Total Balances";
            // 
            // lblNumberToText
            // 
            this.lblNumberToText.AutoSize = true;
            this.lblNumberToText.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberToText.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNumberToText.Location = new System.Drawing.Point(25, 99);
            this.lblNumberToText.Name = "lblNumberToText";
            this.lblNumberToText.Size = new System.Drawing.Size(0, 29);
            this.lblNumberToText.TabIndex = 7;
            // 
            // dgvTotalBalances
            // 
            this.dgvTotalBalances.AllowUserToAddRows = false;
            this.dgvTotalBalances.AllowUserToDeleteRows = false;
            this.dgvTotalBalances.AllowUserToOrderColumns = true;
            this.dgvTotalBalances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTotalBalances.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTotalBalances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalBalances.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTotalBalances.Location = new System.Drawing.Point(3, 385);
            this.dgvTotalBalances.Name = "dgvTotalBalances";
            this.dgvTotalBalances.ReadOnly = true;
            this.dgvTotalBalances.RowHeadersWidth = 62;
            this.dgvTotalBalances.RowTemplate.Height = 28;
            this.dgvTotalBalances.Size = new System.Drawing.Size(1018, 189);
            this.dgvTotalBalances.TabIndex = 6;
            // 
            // lblClientsCount
            // 
            this.lblClientsCount.AutoSize = true;
            this.lblClientsCount.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientsCount.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblClientsCount.Location = new System.Drawing.Point(43, 312);
            this.lblClientsCount.Name = "lblClientsCount";
            this.lblClientsCount.Size = new System.Drawing.Size(32, 33);
            this.lblClientsCount.TabIndex = 5;
            this.lblClientsCount.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(68, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 32);
            this.label9.TabIndex = 4;
            this.label9.Text = "Client(s) Found";
            // 
            // txtSearchAccNumber
            // 
            this.txtSearchAccNumber.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAccNumber.Location = new System.Drawing.Point(32, 239);
            this.txtSearchAccNumber.Name = "txtSearchAccNumber";
            this.txtSearchAccNumber.Size = new System.Drawing.Size(354, 42);
            this.txtSearchAccNumber.TabIndex = 3;
            this.txtSearchAccNumber.TextChanged += new System.EventHandler(this.txtSearchAccNumber_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(26, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(314, 32);
            this.label8.TabIndex = 2;
            this.label8.Text = "Search By Account Number ";
            // 
            // lblTotalBalanes
            // 
            this.lblTotalBalanes.AutoSize = true;
            this.lblTotalBalanes.Font = new System.Drawing.Font("Stencil", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalanes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.lblTotalBalanes.Location = new System.Drawing.Point(244, 40);
            this.lblTotalBalanes.Name = "lblTotalBalanes";
            this.lblTotalBalanes.Size = new System.Drawing.Size(55, 38);
            this.lblTotalBalanes.TabIndex = 1;
            this.lblTotalBalanes.Text = "$0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(25, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Balances is: ";
            // 
            // tbTransferBalances
            // 
            this.tbTransferBalances.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.tbTransferBalances.Controls.Add(this.lblBalanceAccTo);
            this.tbTransferBalances.Controls.Add(this.label16);
            this.tbTransferBalances.Controls.Add(this.lblBalanceAccFrom);
            this.tbTransferBalances.Controls.Add(this.label14);
            this.tbTransferBalances.Controls.Add(this.btnTransfer);
            this.tbTransferBalances.Controls.Add(this.nudTransferAmount);
            this.tbTransferBalances.Controls.Add(this.label12);
            this.tbTransferBalances.Controls.Add(this.cbAccNumberTo);
            this.tbTransferBalances.Controls.Add(this.label11);
            this.tbTransferBalances.Controls.Add(this.cbAccNumberFrom);
            this.tbTransferBalances.Controls.Add(this.label10);
            this.tbTransferBalances.Location = new System.Drawing.Point(4, 41);
            this.tbTransferBalances.Name = "tbTransferBalances";
            this.tbTransferBalances.Padding = new System.Windows.Forms.Padding(3);
            this.tbTransferBalances.Size = new System.Drawing.Size(1024, 577);
            this.tbTransferBalances.TabIndex = 3;
            this.tbTransferBalances.Text = "Transfer Balances";
            // 
            // lblBalanceAccTo
            // 
            this.lblBalanceAccTo.AutoSize = true;
            this.lblBalanceAccTo.Font = new System.Drawing.Font("Segoe UI Black", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceAccTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.lblBalanceAccTo.Location = new System.Drawing.Point(595, 149);
            this.lblBalanceAccTo.Name = "lblBalanceAccTo";
            this.lblBalanceAccTo.Size = new System.Drawing.Size(51, 38);
            this.lblBalanceAccTo.TabIndex = 24;
            this.lblBalanceAccTo.Text = "$0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label16.Location = new System.Drawing.Point(390, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(218, 32);
            this.label16.TabIndex = 23;
            this.label16.Text = "Current Balance is: ";
            // 
            // lblBalanceAccFrom
            // 
            this.lblBalanceAccFrom.AutoSize = true;
            this.lblBalanceAccFrom.Font = new System.Drawing.Font("Segoe UI Black", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceAccFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.lblBalanceAccFrom.Location = new System.Drawing.Point(236, 145);
            this.lblBalanceAccFrom.Name = "lblBalanceAccFrom";
            this.lblBalanceAccFrom.Size = new System.Drawing.Size(51, 38);
            this.lblBalanceAccFrom.TabIndex = 22;
            this.lblBalanceAccFrom.Text = "$0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label14.Location = new System.Drawing.Point(31, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(218, 32);
            this.label14.TabIndex = 21;
            this.label14.Text = "Current Balance is: ";
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.Transparent;
            this.btnTransfer.Enabled = false;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTransfer.Font = new System.Drawing.Font("Verdana", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTransfer.Location = new System.Drawing.Point(252, 391);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(238, 68);
            this.btnTransfer.TabIndex = 20;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // nudTransferAmount
            // 
            this.nudTransferAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTransferAmount.Location = new System.Drawing.Point(238, 267);
            this.nudTransferAmount.Maximum = new decimal(new int[] {
            -469762048,
            -590869294,
            5421010,
            0});
            this.nudTransferAmount.Name = "nudTransferAmount";
            this.nudTransferAmount.Size = new System.Drawing.Size(252, 39);
            this.nudTransferAmount.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.label12.Location = new System.Drawing.Point(232, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(215, 32);
            this.label12.TabIndex = 18;
            this.label12.Text = "Transfer Amount";
            // 
            // cbAccNumberTo
            // 
            this.cbAccNumberTo.FormattingEnabled = true;
            this.cbAccNumberTo.Location = new System.Drawing.Point(396, 87);
            this.cbAccNumberTo.Name = "cbAccNumberTo";
            this.cbAccNumberTo.Size = new System.Drawing.Size(265, 40);
            this.cbAccNumberTo.TabIndex = 17;
            this.cbAccNumberTo.SelectedIndexChanged += new System.EventHandler(this.cbAccNumberTo_SelectedIndexChanged);
            this.cbAccNumberTo.Validating += new System.ComponentModel.CancelEventHandler(this.cbAccountNumbersTransfer_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.label11.Location = new System.Drawing.Point(390, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(203, 32);
            this.label11.TabIndex = 16;
            this.label11.Text = "To Acc. Number";
            // 
            // cbAccNumberFrom
            // 
            this.cbAccNumberFrom.FormattingEnabled = true;
            this.cbAccNumberFrom.Location = new System.Drawing.Point(37, 86);
            this.cbAccNumberFrom.Name = "cbAccNumberFrom";
            this.cbAccNumberFrom.Size = new System.Drawing.Size(265, 40);
            this.cbAccNumberFrom.TabIndex = 15;
            this.cbAccNumberFrom.SelectedIndexChanged += new System.EventHandler(this.cbAccNumberFrom_SelectedIndexChanged);
            this.cbAccNumberFrom.Validating += new System.ComponentModel.CancelEventHandler(this.cbAccountNumbersTransfer_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.label10.Location = new System.Drawing.Point(31, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(234, 32);
            this.label10.TabIndex = 14;
            this.label10.Text = "From Acc. Number";
            // 
            // tbTransferLog
            // 
            this.tbTransferLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.tbTransferLog.Controls.Add(this.lblTransferCount);
            this.tbTransferLog.Controls.Add(this.label15);
            this.tbTransferLog.Controls.Add(this.txtSearchTransfer);
            this.tbTransferLog.Controls.Add(this.label17);
            this.tbTransferLog.Controls.Add(this.dgvTransfers);
            this.tbTransferLog.Location = new System.Drawing.Point(4, 41);
            this.tbTransferLog.Name = "tbTransferLog";
            this.tbTransferLog.Padding = new System.Windows.Forms.Padding(3);
            this.tbTransferLog.Size = new System.Drawing.Size(1024, 577);
            this.tbTransferLog.TabIndex = 4;
            this.tbTransferLog.Text = "Transfer Log";
            // 
            // lblTransferCount
            // 
            this.lblTransferCount.AutoSize = true;
            this.lblTransferCount.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferCount.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTransferCount.Location = new System.Drawing.Point(43, 195);
            this.lblTransferCount.Name = "lblTransferCount";
            this.lblTransferCount.Size = new System.Drawing.Size(32, 33);
            this.lblTransferCount.TabIndex = 9;
            this.lblTransferCount.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label15.Location = new System.Drawing.Point(68, 194);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(175, 32);
            this.label15.TabIndex = 8;
            this.label15.Text = "Client(s) Found";
            // 
            // txtSearchTransfer
            // 
            this.txtSearchTransfer.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTransfer.Location = new System.Drawing.Point(32, 122);
            this.txtSearchTransfer.Name = "txtSearchTransfer";
            this.txtSearchTransfer.Size = new System.Drawing.Size(354, 42);
            this.txtSearchTransfer.TabIndex = 7;
            this.txtSearchTransfer.TextChanged += new System.EventHandler(this.txtSearchTransfer_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label17.Location = new System.Drawing.Point(26, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(314, 32);
            this.label17.TabIndex = 6;
            this.label17.Text = "Search By Account Number ";
            // 
            // dgvTransfers
            // 
            this.dgvTransfers.AllowUserToAddRows = false;
            this.dgvTransfers.AllowUserToDeleteRows = false;
            this.dgvTransfers.AllowUserToOrderColumns = true;
            this.dgvTransfers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransfers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransfers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTransfers.Location = new System.Drawing.Point(3, 320);
            this.dgvTransfers.Name = "dgvTransfers";
            this.dgvTransfers.ReadOnly = true;
            this.dgvTransfers.RowHeadersWidth = 62;
            this.dgvTransfers.RowTemplate.Height = 28;
            this.dgvTransfers.Size = new System.Drawing.Size(1018, 254);
            this.dgvTransfers.TabIndex = 0;
            // 
            // epTransactions
            // 
            this.epTransactions.ContainerControl = this;
            // 
            // frmClientsTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1032, 622);
            this.Controls.Add(this.tcTransfer);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmClientsTransactions";
            this.Text = "frmClientsTransactions";
            this.Load += new System.EventHandler(this.frmClientsTransactions_Load);
            this.tcTransfer.ResumeLayout(false);
            this.tpDeposit.ResumeLayout(false);
            this.tpDeposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountDeposit)).EndInit();
            this.tpWithdraw.ResumeLayout(false);
            this.tpWithdraw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountWithdraw)).EndInit();
            this.tbTotalBalances.ResumeLayout(false);
            this.tbTotalBalances.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalBalances)).EndInit();
            this.tbTransferBalances.ResumeLayout(false);
            this.tbTransferBalances.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTransferAmount)).EndInit();
            this.tbTransferLog.ResumeLayout(false);
            this.tbTransferLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransfers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcTransfer;
        private System.Windows.Forms.TabPage tpDeposit;
        private System.Windows.Forms.Label lblBalanceDeposit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAccountNumbersDeposit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpWithdraw;
        private System.Windows.Forms.NumericUpDown nudAmountDeposit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnClearDepositData;
        private System.Windows.Forms.Button btnClearWithdrawData;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.NumericUpDown nudAmountWithdraw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBalanceWithdraw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbAccountNumbersWithdraw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tbTotalBalances;
        private System.Windows.Forms.Label lblTotalBalanes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblClientsCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchAccNumber;
        private System.Windows.Forms.DataGridView dgvTotalBalances;
        private System.Windows.Forms.Label lblNumberToText;
        private System.Windows.Forms.TabPage tbTransferBalances;
        private System.Windows.Forms.ComboBox cbAccNumberTo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbAccNumberFrom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.NumericUpDown nudTransferAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblBalanceAccTo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblBalanceAccFrom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tbTransferLog;
        private System.Windows.Forms.Label lblTransferCount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSearchTransfer;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgvTransfers;
        private System.Windows.Forms.ErrorProvider epTransactions;
    }
}