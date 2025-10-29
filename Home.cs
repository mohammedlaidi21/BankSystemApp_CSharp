using System;
using System.Windows.Forms;
using BankSystem_BL_;

namespace BankSystem_Currencies
{
    public partial class Home : Form
    {
        private enum enPermissions
        {
            eManageClients = 1, eClientTransactions = 2,
            eManageUsers = 4, eCurrencyExchange = 8
        };
        public Home()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void _GetPermissions()
        {
            if ((clsCurrentUser.CurrentUser.Permission & (int)enPermissions.eManageClients) != (int)enPermissions.eManageClients)
            {
                btnManageClients.Enabled = false;
            }

            if ((clsCurrentUser.CurrentUser.Permission & (int)enPermissions.eClientTransactions) != (int)enPermissions.eClientTransactions)
            {
                btnClientsTransactions.Enabled = false;
            }
           
            if ((clsCurrentUser.CurrentUser.Permission & (int)enPermissions.eManageUsers) != (int)enPermissions.eManageUsers)
            {
                btnManageUsers.Enabled = false;
            }

            if ((clsCurrentUser.CurrentUser.Permission & (int)enPermissions.eCurrencyExchange) != (int)enPermissions.eCurrencyExchange)
            {
                btnCurrencyExchange.Enabled = false;
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblLogin.Text = BankSystem_BL_.clsCurrentUser.CurrentUser.UserName;
            _GetPermissions();
        }

        private void btnManageClients_Click(object sender, EventArgs e)
        {
            frmManageClients ManageClientForm = new frmManageClients();
            scHome.Panel2.Controls.Clear();

            ManageClientForm.TopLevel = false;
            ManageClientForm.Dock = DockStyle.Fill;
            scHome.Panel2.Controls.Add(ManageClientForm);
            ManageClientForm.Show();
        }

        private void btnClientsTransactions_Click(object sender, EventArgs e)
        {
            frmClientsTransactions TransactionsForm = new frmClientsTransactions();
           
            scHome.Panel2.Controls.Clear();
            TransactionsForm.TopLevel = false;
            TransactionsForm.Dock = DockStyle.Fill;

            scHome.Panel2.Controls.Add(TransactionsForm);
            TransactionsForm.Show();
            
        }

        private void btnCurrencyExchange_Click(object sender, EventArgs e)
        {
            frmCurrencyExchange CurrencyForm = new frmCurrencyExchange();
            scHome.Panel2.Controls.Clear();

            CurrencyForm.TopLevel = false;
            CurrencyForm.Dock = DockStyle.Fill;

            scHome.Panel2.Controls.Add(CurrencyForm);
            CurrencyForm.Show();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            frmManageUsers ManageUsersForm = new frmManageUsers();

            scHome.Panel2.Controls.Clear();

            ManageUsersForm.TopLevel = false;
            ManageUsersForm.Dock = DockStyle.Fill;

            scHome.Panel2.Controls.Add(ManageUsersForm);
            ManageUsersForm.Show();
        }

        private void btnLOGOUT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tDateNow_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dddd,MMMM yyyy \nHH:mm:ss tt");
        }
    }
}
