namespace BankSystem_Currencies
{
    partial class frmManageUsers
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpShowUsers = new System.Windows.Forms.TabPage();
            this.lblCountUsers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.cmsUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpAddNewUser = new System.Windows.Forms.TabPage();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.gpPermissions = new System.Windows.Forms.GroupBox();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pPermissions = new System.Windows.Forms.Panel();
            this.cbCurrencyExchange = new System.Windows.Forms.CheckBox();
            this.cbClientTransactions = new System.Windows.Forms.CheckBox();
            this.cbManageUsers = new System.Windows.Forms.CheckBox();
            this.cbManageClients = new System.Windows.Forms.CheckBox();
            this.txtPasswordUser = new System.Windows.Forms.TextBox();
            this.txtEmailUser = new System.Windows.Forms.TextBox();
            this.txtPhoneUser = new System.Windows.Forms.TextBox();
            this.txtLastnameUser = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtFirstnameUser = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tpUpdateUser = new System.Windows.Forms.TabPage();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.gbNewPermission = new System.Windows.Forms.GroupBox();
            this.rbNoNew = new System.Windows.Forms.RadioButton();
            this.rbYesNew = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pNewPermission = new System.Windows.Forms.Panel();
            this.cbNewCurrencyExchange = new System.Windows.Forms.CheckBox();
            this.cbNewClientTransactions = new System.Windows.Forms.CheckBox();
            this.cbNewManageUsers = new System.Windows.Forms.CheckBox();
            this.cbNewManageClients = new System.Windows.Forms.CheckBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewUserEmail = new System.Windows.Forms.TextBox();
            this.txtNewPhoneUser = new System.Windows.Forms.TextBox();
            this.txtNewLName = new System.Windows.Forms.TextBox();
            this.txtNewUserName = new System.Windows.Forms.TextBox();
            this.txtNewFName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tpLoginRegister = new System.Windows.Forms.TabPage();
            this.lblCountLogins = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSearchLogins = new System.Windows.Forms.TextBox();
            this.dgvLoginsRegisters = new System.Windows.Forms.DataGridView();
            this.epUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tpShowUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.cmsUsers.SuspendLayout();
            this.tpAddNewUser.SuspendLayout();
            this.gpPermissions.SuspendLayout();
            this.pPermissions.SuspendLayout();
            this.tpUpdateUser.SuspendLayout();
            this.gbNewPermission.SuspendLayout();
            this.pNewPermission.SuspendLayout();
            this.tpLoginRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoginsRegisters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpShowUsers);
            this.tabControl1.Controls.Add(this.tpAddNewUser);
            this.tabControl1.Controls.Add(this.tpUpdateUser);
            this.tabControl1.Controls.Add(this.tpLoginRegister);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1053, 673);
            this.tabControl1.TabIndex = 0;
            // 
            // tpShowUsers
            // 
            this.tpShowUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.tpShowUsers.Controls.Add(this.lblCountUsers);
            this.tpShowUsers.Controls.Add(this.label2);
            this.tpShowUsers.Controls.Add(this.label1);
            this.tpShowUsers.Controls.Add(this.txtSearchUser);
            this.tpShowUsers.Controls.Add(this.dgvUsers);
            this.tpShowUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.tpShowUsers.Location = new System.Drawing.Point(4, 37);
            this.tpShowUsers.Name = "tpShowUsers";
            this.tpShowUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tpShowUsers.Size = new System.Drawing.Size(1045, 632);
            this.tpShowUsers.TabIndex = 0;
            this.tpShowUsers.Text = "Show Users";
            // 
            // lblCountUsers
            // 
            this.lblCountUsers.AutoSize = true;
            this.lblCountUsers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountUsers.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblCountUsers.Location = new System.Drawing.Point(33, 138);
            this.lblCountUsers.Name = "lblCountUsers";
            this.lblCountUsers.Size = new System.Drawing.Size(26, 30);
            this.lblCountUsers.TabIndex = 14;
            this.lblCountUsers.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(53, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "User(s) Found";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search By User Name";
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUser.Location = new System.Drawing.Point(21, 66);
            this.txtSearchUser.Multiline = true;
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(366, 39);
            this.txtSearchUser.TabIndex = 11;
            this.txtSearchUser.TextChanged += new System.EventHandler(this.txtSearchUser_TextChanged);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToOrderColumns = true;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.ContextMenuStrip = this.cmsUsers;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUsers.GridColor = System.Drawing.SystemColors.Desktop;
            this.dgvUsers.Location = new System.Drawing.Point(3, 360);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 62;
            this.dgvUsers.RowTemplate.Height = 28;
            this.dgvUsers.Size = new System.Drawing.Size(1039, 269);
            this.dgvUsers.TabIndex = 10;
            this.dgvUsers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentDoubleClick);
            this.dgvUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellDoubleClick);
            // 
            // cmsUsers
            // 
            this.cmsUsers.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.cmsUsers.Name = "cmsUsers";
            this.cmsUsers.Size = new System.Drawing.Size(135, 36);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(134, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // tpAddNewUser
            // 
            this.tpAddNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.tpAddNewUser.Controls.Add(this.btnAddNewUser);
            this.tpAddNewUser.Controls.Add(this.gpPermissions);
            this.tpAddNewUser.Controls.Add(this.txtPasswordUser);
            this.tpAddNewUser.Controls.Add(this.txtEmailUser);
            this.tpAddNewUser.Controls.Add(this.txtPhoneUser);
            this.tpAddNewUser.Controls.Add(this.txtLastnameUser);
            this.tpAddNewUser.Controls.Add(this.txtUsername);
            this.tpAddNewUser.Controls.Add(this.txtFirstnameUser);
            this.tpAddNewUser.Controls.Add(this.label11);
            this.tpAddNewUser.Controls.Add(this.label12);
            this.tpAddNewUser.Controls.Add(this.label13);
            this.tpAddNewUser.Controls.Add(this.label14);
            this.tpAddNewUser.Controls.Add(this.label15);
            this.tpAddNewUser.Controls.Add(this.label16);
            this.tpAddNewUser.Location = new System.Drawing.Point(4, 37);
            this.tpAddNewUser.Name = "tpAddNewUser";
            this.tpAddNewUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddNewUser.Size = new System.Drawing.Size(1045, 632);
            this.tpAddNewUser.TabIndex = 1;
            this.tpAddNewUser.Text = "Add New User";
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUser.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddNewUser.Location = new System.Drawing.Point(215, 507);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(252, 76);
            this.btnAddNewUser.TabIndex = 42;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // gpPermissions
            // 
            this.gpPermissions.Controls.Add(this.rbNo);
            this.gpPermissions.Controls.Add(this.rbYes);
            this.gpPermissions.Controls.Add(this.label3);
            this.gpPermissions.Controls.Add(this.pPermissions);
            this.gpPermissions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.gpPermissions.Location = new System.Drawing.Point(30, 292);
            this.gpPermissions.Name = "gpPermissions";
            this.gpPermissions.Size = new System.Drawing.Size(655, 209);
            this.gpPermissions.TabIndex = 41;
            this.gpPermissions.TabStop = false;
            this.gpPermissions.Text = "Permissions";
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbNo.Location = new System.Drawing.Point(314, 38);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(64, 32);
            this.rbNo.TabIndex = 43;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            this.rbNo.CheckedChanged += new System.EventHandler(this.rbAnswer_CheckedChanged);
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Checked = true;
            this.rbYes.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbYes.Location = new System.Drawing.Point(228, 38);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(67, 32);
            this.rbYes.TabIndex = 42;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            this.rbYes.CheckedChanged += new System.EventHandler(this.rbAnswer_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(30, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 24);
            this.label3.TabIndex = 41;
            this.label3.Text = "Give Full Access?";
            // 
            // pPermissions
            // 
            this.pPermissions.Controls.Add(this.cbCurrencyExchange);
            this.pPermissions.Controls.Add(this.cbClientTransactions);
            this.pPermissions.Controls.Add(this.cbManageUsers);
            this.pPermissions.Controls.Add(this.cbManageClients);
            this.pPermissions.Location = new System.Drawing.Point(21, 86);
            this.pPermissions.Name = "pPermissions";
            this.pPermissions.Size = new System.Drawing.Size(619, 117);
            this.pPermissions.TabIndex = 40;
            this.pPermissions.Visible = false;
            // 
            // cbCurrencyExchange
            // 
            this.cbCurrencyExchange.AutoSize = true;
            this.cbCurrencyExchange.Location = new System.Drawing.Point(352, 72);
            this.cbCurrencyExchange.Name = "cbCurrencyExchange";
            this.cbCurrencyExchange.Size = new System.Drawing.Size(210, 32);
            this.cbCurrencyExchange.TabIndex = 3;
            this.cbCurrencyExchange.Text = "Currency Exchange";
            this.cbCurrencyExchange.UseVisualStyleBackColor = true;
            this.cbCurrencyExchange.CheckedChanged += new System.EventHandler(this.cbPermissions_CheckedChanged);
            // 
            // cbClientTransactions
            // 
            this.cbClientTransactions.AutoSize = true;
            this.cbClientTransactions.Location = new System.Drawing.Point(352, 20);
            this.cbClientTransactions.Name = "cbClientTransactions";
            this.cbClientTransactions.Size = new System.Drawing.Size(207, 32);
            this.cbClientTransactions.TabIndex = 2;
            this.cbClientTransactions.Text = "Client Transactions";
            this.cbClientTransactions.UseVisualStyleBackColor = true;
            this.cbClientTransactions.CheckedChanged += new System.EventHandler(this.cbPermissions_CheckedChanged);
            // 
            // cbManageUsers
            // 
            this.cbManageUsers.AutoSize = true;
            this.cbManageUsers.Location = new System.Drawing.Point(21, 72);
            this.cbManageUsers.Name = "cbManageUsers";
            this.cbManageUsers.Size = new System.Drawing.Size(167, 32);
            this.cbManageUsers.TabIndex = 1;
            this.cbManageUsers.Text = "Manage Users";
            this.cbManageUsers.UseVisualStyleBackColor = true;
            this.cbManageUsers.CheckedChanged += new System.EventHandler(this.cbPermissions_CheckedChanged);
            // 
            // cbManageClients
            // 
            this.cbManageClients.AutoSize = true;
            this.cbManageClients.Location = new System.Drawing.Point(21, 20);
            this.cbManageClients.Name = "cbManageClients";
            this.cbManageClients.Size = new System.Drawing.Size(178, 32);
            this.cbManageClients.TabIndex = 0;
            this.cbManageClients.Text = "Manage Clients";
            this.cbManageClients.UseVisualStyleBackColor = true;
            this.cbManageClients.CheckedChanged += new System.EventHandler(this.cbPermissions_CheckedChanged);
            // 
            // txtPasswordUser
            // 
            this.txtPasswordUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordUser.Location = new System.Drawing.Point(387, 248);
            this.txtPasswordUser.Multiline = true;
            this.txtPasswordUser.Name = "txtPasswordUser";
            this.txtPasswordUser.Size = new System.Drawing.Size(283, 38);
            this.txtPasswordUser.TabIndex = 39;
            this.txtPasswordUser.Validating += new System.ComponentModel.CancelEventHandler(this.txtInput_Validating);
            // 
            // txtEmailUser
            // 
            this.txtEmailUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailUser.Location = new System.Drawing.Point(387, 57);
            this.txtEmailUser.Multiline = true;
            this.txtEmailUser.Name = "txtEmailUser";
            this.txtEmailUser.Size = new System.Drawing.Size(283, 38);
            this.txtEmailUser.TabIndex = 38;
            this.txtEmailUser.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmails_Validating);
            // 
            // txtPhoneUser
            // 
            this.txtPhoneUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneUser.Location = new System.Drawing.Point(387, 153);
            this.txtPhoneUser.MaxLength = 10;
            this.txtPhoneUser.Multiline = true;
            this.txtPhoneUser.Name = "txtPhoneUser";
            this.txtPhoneUser.Size = new System.Drawing.Size(283, 38);
            this.txtPhoneUser.TabIndex = 37;
            this.txtPhoneUser.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhones_Validating);
            // 
            // txtLastnameUser
            // 
            this.txtLastnameUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastnameUser.Location = new System.Drawing.Point(30, 248);
            this.txtLastnameUser.Multiline = true;
            this.txtLastnameUser.Name = "txtLastnameUser";
            this.txtLastnameUser.Size = new System.Drawing.Size(283, 38);
            this.txtLastnameUser.TabIndex = 36;
            this.txtLastnameUser.Validating += new System.ComponentModel.CancelEventHandler(this.txtInput_Validating);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(30, 57);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(283, 38);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtInput_Validating);
            // 
            // txtFirstnameUser
            // 
            this.txtFirstnameUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstnameUser.Location = new System.Drawing.Point(30, 153);
            this.txtFirstnameUser.Multiline = true;
            this.txtFirstnameUser.Name = "txtFirstnameUser";
            this.txtFirstnameUser.Size = new System.Drawing.Size(283, 38);
            this.txtFirstnameUser.TabIndex = 34;
            this.txtFirstnameUser.Validating += new System.ComponentModel.CancelEventHandler(this.txtInput_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.label11.Location = new System.Drawing.Point(381, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 32);
            this.label11.TabIndex = 33;
            this.label11.Text = "Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.label12.Location = new System.Drawing.Point(381, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 32);
            this.label12.TabIndex = 32;
            this.label12.Text = "Email";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.label13.Location = new System.Drawing.Point(24, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 32);
            this.label13.TabIndex = 31;
            this.label13.Text = "Last Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.label14.Location = new System.Drawing.Point(24, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 32);
            this.label14.TabIndex = 30;
            this.label14.Text = "First Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.label15.Location = new System.Drawing.Point(381, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 32);
            this.label15.TabIndex = 29;
            this.label15.Text = "Phone";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.label16.Location = new System.Drawing.Point(24, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(139, 32);
            this.label16.TabIndex = 28;
            this.label16.Text = "User Name";
            // 
            // tpUpdateUser
            // 
            this.tpUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.tpUpdateUser.Controls.Add(this.btnUpdateUser);
            this.tpUpdateUser.Controls.Add(this.gbNewPermission);
            this.tpUpdateUser.Controls.Add(this.txtNewPassword);
            this.tpUpdateUser.Controls.Add(this.txtNewUserEmail);
            this.tpUpdateUser.Controls.Add(this.txtNewPhoneUser);
            this.tpUpdateUser.Controls.Add(this.txtNewLName);
            this.tpUpdateUser.Controls.Add(this.txtNewUserName);
            this.tpUpdateUser.Controls.Add(this.txtNewFName);
            this.tpUpdateUser.Controls.Add(this.label5);
            this.tpUpdateUser.Controls.Add(this.label6);
            this.tpUpdateUser.Controls.Add(this.label7);
            this.tpUpdateUser.Controls.Add(this.label8);
            this.tpUpdateUser.Controls.Add(this.label9);
            this.tpUpdateUser.Controls.Add(this.label10);
            this.tpUpdateUser.Location = new System.Drawing.Point(4, 37);
            this.tpUpdateUser.Name = "tpUpdateUser";
            this.tpUpdateUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdateUser.Size = new System.Drawing.Size(1045, 632);
            this.tpUpdateUser.TabIndex = 2;
            this.tpUpdateUser.Text = "Update User";
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateUser.Location = new System.Drawing.Point(223, 508);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(252, 76);
            this.btnUpdateUser.TabIndex = 56;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // gbNewPermission
            // 
            this.gbNewPermission.Controls.Add(this.rbNoNew);
            this.gbNewPermission.Controls.Add(this.rbYesNew);
            this.gbNewPermission.Controls.Add(this.label4);
            this.gbNewPermission.Controls.Add(this.pNewPermission);
            this.gbNewPermission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.gbNewPermission.Location = new System.Drawing.Point(38, 293);
            this.gbNewPermission.Name = "gbNewPermission";
            this.gbNewPermission.Size = new System.Drawing.Size(655, 209);
            this.gbNewPermission.TabIndex = 55;
            this.gbNewPermission.TabStop = false;
            this.gbNewPermission.Text = "Permissions";
            // 
            // rbNoNew
            // 
            this.rbNoNew.AutoSize = true;
            this.rbNoNew.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbNoNew.Location = new System.Drawing.Point(314, 38);
            this.rbNoNew.Name = "rbNoNew";
            this.rbNoNew.Size = new System.Drawing.Size(64, 32);
            this.rbNoNew.TabIndex = 43;
            this.rbNoNew.Text = "No";
            this.rbNoNew.UseVisualStyleBackColor = true;
            this.rbNoNew.CheckedChanged += new System.EventHandler(this.rbAnswer_CheckedChanged);
            // 
            // rbYesNew
            // 
            this.rbYesNew.AutoSize = true;
            this.rbYesNew.Checked = true;
            this.rbYesNew.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbYesNew.Location = new System.Drawing.Point(228, 38);
            this.rbYesNew.Name = "rbYesNew";
            this.rbYesNew.Size = new System.Drawing.Size(67, 32);
            this.rbYesNew.TabIndex = 42;
            this.rbYesNew.TabStop = true;
            this.rbYesNew.Text = "Yes";
            this.rbYesNew.UseVisualStyleBackColor = true;
            this.rbYesNew.CheckedChanged += new System.EventHandler(this.rbAnswer_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(30, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "Give Full Access?";
            // 
            // pNewPermission
            // 
            this.pNewPermission.Controls.Add(this.cbNewCurrencyExchange);
            this.pNewPermission.Controls.Add(this.cbNewClientTransactions);
            this.pNewPermission.Controls.Add(this.cbNewManageUsers);
            this.pNewPermission.Controls.Add(this.cbNewManageClients);
            this.pNewPermission.Location = new System.Drawing.Point(21, 86);
            this.pNewPermission.Name = "pNewPermission";
            this.pNewPermission.Size = new System.Drawing.Size(619, 117);
            this.pNewPermission.TabIndex = 40;
            // 
            // cbNewCurrencyExchange
            // 
            this.cbNewCurrencyExchange.AutoSize = true;
            this.cbNewCurrencyExchange.Location = new System.Drawing.Point(352, 72);
            this.cbNewCurrencyExchange.Name = "cbNewCurrencyExchange";
            this.cbNewCurrencyExchange.Size = new System.Drawing.Size(210, 32);
            this.cbNewCurrencyExchange.TabIndex = 3;
            this.cbNewCurrencyExchange.Text = "Currency Exchange";
            this.cbNewCurrencyExchange.UseVisualStyleBackColor = true;
            this.cbNewCurrencyExchange.CheckedChanged += new System.EventHandler(this.cbPermissions_CheckedChanged);
            // 
            // cbNewClientTransactions
            // 
            this.cbNewClientTransactions.AutoSize = true;
            this.cbNewClientTransactions.Location = new System.Drawing.Point(352, 20);
            this.cbNewClientTransactions.Name = "cbNewClientTransactions";
            this.cbNewClientTransactions.Size = new System.Drawing.Size(207, 32);
            this.cbNewClientTransactions.TabIndex = 2;
            this.cbNewClientTransactions.Text = "Client Transactions";
            this.cbNewClientTransactions.UseVisualStyleBackColor = true;
            this.cbNewClientTransactions.CheckedChanged += new System.EventHandler(this.cbPermissions_CheckedChanged);
            // 
            // cbNewManageUsers
            // 
            this.cbNewManageUsers.AutoSize = true;
            this.cbNewManageUsers.Location = new System.Drawing.Point(21, 72);
            this.cbNewManageUsers.Name = "cbNewManageUsers";
            this.cbNewManageUsers.Size = new System.Drawing.Size(167, 32);
            this.cbNewManageUsers.TabIndex = 1;
            this.cbNewManageUsers.Text = "Manage Users";
            this.cbNewManageUsers.UseVisualStyleBackColor = true;
            this.cbNewManageUsers.CheckedChanged += new System.EventHandler(this.cbPermissions_CheckedChanged);
            // 
            // cbNewManageClients
            // 
            this.cbNewManageClients.AutoSize = true;
            this.cbNewManageClients.Location = new System.Drawing.Point(21, 20);
            this.cbNewManageClients.Name = "cbNewManageClients";
            this.cbNewManageClients.Size = new System.Drawing.Size(178, 32);
            this.cbNewManageClients.TabIndex = 0;
            this.cbNewManageClients.Text = "Manage Clients";
            this.cbNewManageClients.UseVisualStyleBackColor = true;
            this.cbNewManageClients.CheckedChanged += new System.EventHandler(this.cbPermissions_CheckedChanged);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(395, 249);
            this.txtNewPassword.Multiline = true;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(283, 38);
            this.txtNewPassword.TabIndex = 54;
            this.txtNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtInput_Validating);
            // 
            // txtNewUserEmail
            // 
            this.txtNewUserEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewUserEmail.Location = new System.Drawing.Point(395, 58);
            this.txtNewUserEmail.Multiline = true;
            this.txtNewUserEmail.Name = "txtNewUserEmail";
            this.txtNewUserEmail.Size = new System.Drawing.Size(283, 38);
            this.txtNewUserEmail.TabIndex = 53;
            this.txtNewUserEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmails_Validating);
            // 
            // txtNewPhoneUser
            // 
            this.txtNewPhoneUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPhoneUser.Location = new System.Drawing.Point(395, 154);
            this.txtNewPhoneUser.MaxLength = 10;
            this.txtNewPhoneUser.Multiline = true;
            this.txtNewPhoneUser.Name = "txtNewPhoneUser";
            this.txtNewPhoneUser.Size = new System.Drawing.Size(283, 38);
            this.txtNewPhoneUser.TabIndex = 52;
            this.txtNewPhoneUser.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhones_Validating);
            // 
            // txtNewLName
            // 
            this.txtNewLName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewLName.Location = new System.Drawing.Point(38, 249);
            this.txtNewLName.Multiline = true;
            this.txtNewLName.Name = "txtNewLName";
            this.txtNewLName.Size = new System.Drawing.Size(283, 38);
            this.txtNewLName.TabIndex = 51;
            this.txtNewLName.Validating += new System.ComponentModel.CancelEventHandler(this.txtInput_Validating);
            // 
            // txtNewUserName
            // 
            this.txtNewUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewUserName.Location = new System.Drawing.Point(38, 58);
            this.txtNewUserName.Multiline = true;
            this.txtNewUserName.Name = "txtNewUserName";
            this.txtNewUserName.Size = new System.Drawing.Size(283, 38);
            this.txtNewUserName.TabIndex = 50;
            this.txtNewUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtInput_Validating);
            // 
            // txtNewFName
            // 
            this.txtNewFName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewFName.Location = new System.Drawing.Point(38, 154);
            this.txtNewFName.Multiline = true;
            this.txtNewFName.Name = "txtNewFName";
            this.txtNewFName.Size = new System.Drawing.Size(283, 38);
            this.txtNewFName.TabIndex = 49;
            this.txtNewFName.Validating += new System.ComponentModel.CancelEventHandler(this.txtInput_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.label5.Location = new System.Drawing.Point(389, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 32);
            this.label5.TabIndex = 48;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.label6.Location = new System.Drawing.Point(389, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 32);
            this.label6.TabIndex = 47;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.label7.Location = new System.Drawing.Point(32, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 32);
            this.label7.TabIndex = 46;
            this.label7.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.label8.Location = new System.Drawing.Point(32, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 32);
            this.label8.TabIndex = 45;
            this.label8.Text = "First Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.label9.Location = new System.Drawing.Point(389, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 32);
            this.label9.TabIndex = 44;
            this.label9.Text = "Phone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(193)))), ((int)(((byte)(182)))));
            this.label10.Location = new System.Drawing.Point(32, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 32);
            this.label10.TabIndex = 43;
            this.label10.Text = "User Name";
            // 
            // tpLoginRegister
            // 
            this.tpLoginRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.tpLoginRegister.Controls.Add(this.lblCountLogins);
            this.tpLoginRegister.Controls.Add(this.label18);
            this.tpLoginRegister.Controls.Add(this.label19);
            this.tpLoginRegister.Controls.Add(this.txtSearchLogins);
            this.tpLoginRegister.Controls.Add(this.dgvLoginsRegisters);
            this.tpLoginRegister.Location = new System.Drawing.Point(4, 37);
            this.tpLoginRegister.Name = "tpLoginRegister";
            this.tpLoginRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tpLoginRegister.Size = new System.Drawing.Size(1045, 632);
            this.tpLoginRegister.TabIndex = 3;
            this.tpLoginRegister.Text = "Login Register";
            // 
            // lblCountLogins
            // 
            this.lblCountLogins.AutoSize = true;
            this.lblCountLogins.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountLogins.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblCountLogins.Location = new System.Drawing.Point(33, 127);
            this.lblCountLogins.Name = "lblCountLogins";
            this.lblCountLogins.Size = new System.Drawing.Size(26, 30);
            this.lblCountLogins.TabIndex = 19;
            this.lblCountLogins.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label18.Location = new System.Drawing.Point(55, 127);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(150, 28);
            this.label18.TabIndex = 18;
            this.label18.Text = "Login(s) Found";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label19.Location = new System.Drawing.Point(20, 14);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(188, 25);
            this.label19.TabIndex = 17;
            this.label19.Text = "Search By User Name";
            // 
            // txtSearchLogins
            // 
            this.txtSearchLogins.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchLogins.Location = new System.Drawing.Point(21, 55);
            this.txtSearchLogins.Multiline = true;
            this.txtSearchLogins.Name = "txtSearchLogins";
            this.txtSearchLogins.Size = new System.Drawing.Size(366, 39);
            this.txtSearchLogins.TabIndex = 16;
            this.txtSearchLogins.TextChanged += new System.EventHandler(this.txtSearchLogins_TextChanged);
            // 
            // dgvLoginsRegisters
            // 
            this.dgvLoginsRegisters.AllowUserToAddRows = false;
            this.dgvLoginsRegisters.AllowUserToDeleteRows = false;
            this.dgvLoginsRegisters.AllowUserToOrderColumns = true;
            this.dgvLoginsRegisters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoginsRegisters.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvLoginsRegisters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoginsRegisters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLoginsRegisters.GridColor = System.Drawing.SystemColors.Desktop;
            this.dgvLoginsRegisters.Location = new System.Drawing.Point(3, 360);
            this.dgvLoginsRegisters.Name = "dgvLoginsRegisters";
            this.dgvLoginsRegisters.ReadOnly = true;
            this.dgvLoginsRegisters.RowHeadersWidth = 62;
            this.dgvLoginsRegisters.RowTemplate.Height = 28;
            this.dgvLoginsRegisters.Size = new System.Drawing.Size(1039, 269);
            this.dgvLoginsRegisters.TabIndex = 15;
            // 
            // epUser
            // 
            this.epUser.ContainerControl = this;
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 673);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmManageUsers";
            this.Text = "frmManageUsers";
            this.Load += new System.EventHandler(this.frmManageUsers_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tpShowUsers.ResumeLayout(false);
            this.tpShowUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.cmsUsers.ResumeLayout(false);
            this.tpAddNewUser.ResumeLayout(false);
            this.tpAddNewUser.PerformLayout();
            this.gpPermissions.ResumeLayout(false);
            this.gpPermissions.PerformLayout();
            this.pPermissions.ResumeLayout(false);
            this.pPermissions.PerformLayout();
            this.tpUpdateUser.ResumeLayout(false);
            this.tpUpdateUser.PerformLayout();
            this.gbNewPermission.ResumeLayout(false);
            this.gbNewPermission.PerformLayout();
            this.pNewPermission.ResumeLayout(false);
            this.pNewPermission.PerformLayout();
            this.tpLoginRegister.ResumeLayout(false);
            this.tpLoginRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoginsRegisters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpShowUsers;
        private System.Windows.Forms.TabPage tpAddNewUser;
        private System.Windows.Forms.TabPage tpUpdateUser;
        private System.Windows.Forms.TabPage tpLoginRegister;
        private System.Windows.Forms.Label lblCountUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel pPermissions;
        private System.Windows.Forms.TextBox txtPasswordUser;
        private System.Windows.Forms.TextBox txtEmailUser;
        private System.Windows.Forms.TextBox txtPhoneUser;
        private System.Windows.Forms.TextBox txtLastnameUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtFirstnameUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox gpPermissions;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.CheckBox cbCurrencyExchange;
        private System.Windows.Forms.CheckBox cbClientTransactions;
        private System.Windows.Forms.CheckBox cbManageUsers;
        private System.Windows.Forms.CheckBox cbManageClients;
        private System.Windows.Forms.ErrorProvider epUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.GroupBox gbNewPermission;
        private System.Windows.Forms.RadioButton rbNoNew;
        private System.Windows.Forms.RadioButton rbYesNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pNewPermission;
        private System.Windows.Forms.CheckBox cbNewCurrencyExchange;
        private System.Windows.Forms.CheckBox cbNewClientTransactions;
        private System.Windows.Forms.CheckBox cbNewManageUsers;
        private System.Windows.Forms.CheckBox cbNewManageClients;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtNewUserEmail;
        private System.Windows.Forms.TextBox txtNewPhoneUser;
        private System.Windows.Forms.TextBox txtNewLName;
        private System.Windows.Forms.TextBox txtNewUserName;
        private System.Windows.Forms.TextBox txtNewFName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCountLogins;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtSearchLogins;
        private System.Windows.Forms.DataGridView dgvLoginsRegisters;
        private System.Windows.Forms.ContextMenuStrip cmsUsers;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}