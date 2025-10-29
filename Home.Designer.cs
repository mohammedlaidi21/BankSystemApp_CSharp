namespace BankSystem_Currencies
{
    partial class Home
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
            this.scHome = new System.Windows.Forms.SplitContainer();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnLOGOUT = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnCurrencyExchange = new System.Windows.Forms.Button();
            this.btnClientsTransactions = new System.Windows.Forms.Button();
            this.btnManageClients = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tDateNow = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.scHome)).BeginInit();
            this.scHome.Panel1.SuspendLayout();
            this.scHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // scHome
            // 
            this.scHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scHome.IsSplitterFixed = true;
            this.scHome.Location = new System.Drawing.Point(0, 0);
            this.scHome.Name = "scHome";
            // 
            // scHome.Panel1
            // 
            this.scHome.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(24)))), ((int)(((byte)(36)))));
            this.scHome.Panel1.CausesValidation = false;
            this.scHome.Panel1.Controls.Add(this.lblDate);
            this.scHome.Panel1.Controls.Add(this.btnLOGOUT);
            this.scHome.Panel1.Controls.Add(this.btnManageUsers);
            this.scHome.Panel1.Controls.Add(this.btnCurrencyExchange);
            this.scHome.Panel1.Controls.Add(this.btnClientsTransactions);
            this.scHome.Panel1.Controls.Add(this.btnManageClients);
            this.scHome.Panel1.Controls.Add(this.lblLogin);
            this.scHome.Panel1.Controls.Add(this.label1);
            this.scHome.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.scHome.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // scHome.Panel2
            // 
            this.scHome.Panel2.BackgroundImage = global::BankSystem_Currencies.Properties.Resources.BgHome;
            this.scHome.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scHome.Panel2.CausesValidation = false;
            this.scHome.Panel2.ForeColor = System.Drawing.Color.White;
            this.scHome.Panel2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.scHome.Size = new System.Drawing.Size(1082, 658);
            this.scHome.SplitterDistance = 327;
            this.scHome.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(100)))));
            this.lblDate.Location = new System.Drawing.Point(16, 548);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(129, 32);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "DateTime";
            // 
            // btnLOGOUT
            // 
            this.btnLOGOUT.BackColor = System.Drawing.Color.Transparent;
            this.btnLOGOUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLOGOUT.Font = new System.Drawing.Font("Segoe UI Black", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLOGOUT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(100)))));
            this.btnLOGOUT.Image = global::BankSystem_Currencies.Properties.Resources.Logout1;
            this.btnLOGOUT.Location = new System.Drawing.Point(235, 570);
            this.btnLOGOUT.Name = "btnLOGOUT";
            this.btnLOGOUT.Size = new System.Drawing.Size(77, 76);
            this.btnLOGOUT.TabIndex = 6;
            this.btnLOGOUT.Text = "<-|";
            this.btnLOGOUT.UseVisualStyleBackColor = false;
            this.btnLOGOUT.Click += new System.EventHandler(this.btnLOGOUT_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Location = new System.Drawing.Point(24, 339);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(277, 67);
            this.btnManageUsers.TabIndex = 5;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnCurrencyExchange
            // 
            this.btnCurrencyExchange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.btnCurrencyExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrencyExchange.Location = new System.Drawing.Point(25, 428);
            this.btnCurrencyExchange.Name = "btnCurrencyExchange";
            this.btnCurrencyExchange.Size = new System.Drawing.Size(277, 67);
            this.btnCurrencyExchange.TabIndex = 4;
            this.btnCurrencyExchange.Text = "Currency Exchange";
            this.btnCurrencyExchange.UseVisualStyleBackColor = false;
            this.btnCurrencyExchange.Click += new System.EventHandler(this.btnCurrencyExchange_Click);
            // 
            // btnClientsTransactions
            // 
            this.btnClientsTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.btnClientsTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientsTransactions.Location = new System.Drawing.Point(25, 254);
            this.btnClientsTransactions.Name = "btnClientsTransactions";
            this.btnClientsTransactions.Size = new System.Drawing.Size(277, 67);
            this.btnClientsTransactions.TabIndex = 3;
            this.btnClientsTransactions.Text = "Clients Transactions";
            this.btnClientsTransactions.UseVisualStyleBackColor = false;
            this.btnClientsTransactions.Click += new System.EventHandler(this.btnClientsTransactions_Click);
            // 
            // btnManageClients
            // 
            this.btnManageClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            this.btnManageClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageClients.Location = new System.Drawing.Point(24, 170);
            this.btnManageClients.Name = "btnManageClients";
            this.btnManageClients.Size = new System.Drawing.Size(277, 67);
            this.btnManageClients.TabIndex = 2;
            this.btnManageClients.Text = "Manage Clients";
            this.btnManageClients.UseVisualStyleBackColor = false;
            this.btnManageClients.Click += new System.EventHandler(this.btnManageClients_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(100)))));
            this.lblLogin.Location = new System.Drawing.Point(147, 73);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(101, 48);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "AAA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(84)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(15, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // tDateNow
            // 
            this.tDateNow.Enabled = true;
            this.tDateNow.Interval = 1000;
            this.tDateNow.Tick += new System.EventHandler(this.tDateNow_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankSystem_Currencies.Properties.Resources.BgHome;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 658);
            this.Controls.Add(this.scHome);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.scHome.Panel1.ResumeLayout(false);
            this.scHome.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scHome)).EndInit();
            this.scHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnManageClients;
        private System.Windows.Forms.Button btnClientsTransactions;
        private System.Windows.Forms.Button btnCurrencyExchange;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnLOGOUT;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer tDateNow;
    }
}