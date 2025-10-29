using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSystem_BL_;

namespace BankSystem_Currencies
{
    public partial class frmClientsTransactions : Form
    {
        clsAccount Account;

        //Here
        clsAccount AccFrom;
        clsAccount AccTo;

        public frmClientsTransactions()
        {
            InitializeComponent();
        }

        private void _LoadComboBoxes()
        {
            DataTable ClientsDT = clsClient.GetAllClients();

            foreach (DataRow Client in ClientsDT.Rows)
            {
                cbAccountNumbersDeposit.Items.Add(Client["AccountNumber"].ToString());
                cbAccountNumbersWithdraw.Items.Add(Client["AccountNumber"].ToString());
                cbAccNumberFrom.Items.Add(Client["AccountNumber"].ToString());
                cbAccNumberTo.Items.Add(Client["AccountNumber"].ToString());
            }
        }
      
        private void _LoadTotalBalancesClients()
        {
            DataTable ClientsDT = clsClient.GetAllClients();
            DataView ClientBalances = new DataView(ClientsDT);

            DataTable ClientsBalancesDT = ClientBalances.ToTable(false, "ClientID", "AccountNumber", "Balance");
            dgvTotalBalances.DataSource = ClientsBalancesDT;
            dgvTotalBalances.ForeColor = Color.Black;
            var TotalBalances = ClientsBalancesDT.Compute("SUM(Balance)", string.Empty);
            lblTotalBalanes.Text = "$" + TotalBalances.ToString();
            lblNumberToText.Text = "( " + clsAccount.GetTextNumber((decimal)TotalBalances) + ")\n Dollar(s)";
            lblClientsCount.Text = ClientsBalancesDT.Rows.Count.ToString();
            
        }

        private void _LoadTransferLog()
        {
            dgvTransfers.DataSource = clsTransaction.GetAllTransfers();
            dgvTransfers.ForeColor = Color.Black;
            lblTransferCount.Text = dgvTransfers.RowCount.ToString();
        }

        private void _TransactionAmount()
        {
            
            decimal Amount = Convert.ToDecimal(nudTransferAmount.Value);

                if (AccFrom.TransfertTo(AccTo, Amount))
                {
                    clsTransaction Transaction = new clsTransaction();
                    Transaction.AccountIDFrom = AccFrom.AccountID;
                    Transaction.AccountIDTO = AccTo.AccountID;
                    Transaction.Amount = Amount;
                    Transaction.dateTime = DateTime.Now;
                    Transaction.UserID = clsCurrentUser.CurrentUser.UserID;

                    Transaction.save();

                    MessageBox.Show("Transaction Done Successfully.", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Faild Transaction Operation!!", "Faild", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
        }

        private void frmClientsTransactions_Load(object sender, EventArgs e)
        {
            _LoadComboBoxes();
            _LoadTotalBalancesClients();
            _LoadTransferLog();
        }

        private void cbAccountNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbAccounts = null;
            cbAccounts = (ComboBox)sender;
            string SelectedValue = cbAccounts.SelectedItem.ToString();
            Account = clsAccount.FindByAccountNumber(SelectedValue);

            if (Account != null)
            {
                if (cbAccounts == cbAccountNumbersDeposit)
                   lblBalanceDeposit.Text = "$" + Account.Balance.ToString("F2");

                if (cbAccounts == cbAccountNumbersWithdraw)
                    lblBalanceWithdraw.Text = "$" + Account.Balance.ToString("F2");
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            decimal Amount = (decimal)nudAmountDeposit.Value;
            if (Account.DepositAmount(Amount))
            {
                MessageBox.Show("Balance Updated Successfully.", "Deposit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblBalanceDeposit.Text = "$" + Account.Balance.ToString("F2");
                _LoadTotalBalancesClients();
            }
            else
            {
                MessageBox.Show("Faild Update Balance", "Faild",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Button btnClear = (Button)sender;

            if (btnClear == btnClearDepositData)
            {
                cbAccountNumbersDeposit.Text = "";
                nudAmountDeposit.Value = 0;
                lblBalanceDeposit.Text = "$0";
                return;
            }

            if (btnClear == btnClearWithdrawData)
            {
                cbAccountNumbersWithdraw.Text = "";
                nudAmountWithdraw.Value = 0;
                lblBalanceWithdraw.Text = "$0";
                return;
            }


        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            decimal Amount = (decimal)nudAmountWithdraw.Value;
            if (Amount <= Account.Balance)
            {
                if (Account.WithdrawAmount(Amount))
                {
                    MessageBox.Show("Balance Updated Successfully.", "Deposit",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblBalanceWithdraw.Text = "$" + Account.Balance.ToString("F2");
                    _LoadTotalBalancesClients();
                }
                else
                {
                    MessageBox.Show("Faild Update Balance", "Faild",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Impossible To Withdraw This Amount Greater Than Your Balance!!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtSearchAccNumber_TextChanged(object sender, EventArgs e)
        {
            DataView dv = clsClient.FindByAccountNumber(txtSearchAccNumber.Text);
            dgvTotalBalances.DataSource = dv.ToTable(false, "ClientID", "AccountNumber", "Balance");
            lblClientsCount.Text = dgvTotalBalances.RowCount.ToString();
        }

        //Here
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (cbAccNumberFrom.Text == "" || cbAccNumberTo.Text == "")
            {
                MessageBox.Show("No Way Should Be Fill From And To!!", "Faild",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _TransactionAmount();
            lblBalanceAccFrom.Text = "$" + AccFrom.Balance.ToString();
            lblBalanceAccTo.Text = "$" + AccTo.Balance.ToString();
            _LoadTotalBalancesClients();
            cbAccNumberFrom.Text = "";
            cbAccNumberTo.Text = "";
            nudTransferAmount.Value = 0;
            _LoadTransferLog();
            
            if (cbAccNumberFrom.Text == "")
            {
                lblBalanceAccFrom.Text = "$0";
            }

            if (cbAccNumberTo.Text == "")
            {
                lblBalanceAccTo.Text = "$0";
            }
        }

        //Here
        private void cbAccNumberFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTransfer.Enabled = true;

            AccFrom = clsAccount.FindByAccountNumber(cbAccNumberFrom.Text.ToString());
            lblBalanceAccFrom.Text = "$" + AccFrom.Balance.ToString();
            if (AccFrom.Balance == 0)
            {
                MessageBox.Show("Empty Balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnTransfer.Enabled = false;
            }
        }

        //Here
        private void cbAccNumberTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccTo = clsAccount.FindByAccountNumber(cbAccNumberTo.Text.ToString());
            lblBalanceAccTo.Text = "$" + AccTo.Balance.ToString();
            if (AccFrom.AccountNumber == AccTo.AccountNumber)
            {
                MessageBox.Show("Impossible Transfer To Same Accounts", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnTransfer.Enabled = false;
                lblBalanceAccTo.Text = "$0";
                cbAccNumberTo.Text = "";
                return;
            }
           
        }

       
        private void txtSearchTransfer_TextChanged(object sender, EventArgs e)
        {
            dgvTransfers.DataSource = clsTransaction.FindTransferByAccID(txtSearchTransfer.Text);
            lblTransferCount.Text = dgvTransfers.RowCount.ToString();
        }

        private void cbAccountNumbersTransfer_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cbAccountNumbersTransfer = (ComboBox)sender;
            if (string.IsNullOrWhiteSpace(cbAccountNumbersTransfer.Text))
            {
                e.Cancel = true;
                cbAccountNumbersTransfer.Focus();
                epTransactions.SetError(cbAccountNumbersTransfer, "Should be Fill!");
            }
            else
            {
                e.Cancel = false;
                epTransactions.SetError(cbAccountNumbersTransfer, "");
            }
        }
    }
}
