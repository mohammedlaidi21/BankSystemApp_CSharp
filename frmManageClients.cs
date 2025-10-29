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
    public partial class frmManageClients : Form
    {
        public frmManageClients()
        {
            InitializeComponent();
        }

        void _LoadDataClients()
        {
            dgvClients.DataSource = clsClient.GetAllClients();
            dgvClients.ForeColor = Color.Black;
            lblCountClients.Text = dgvClients.RowCount.ToString();
        }

        private void frmManageClients_Load(object sender, EventArgs e)
        {
            _LoadDataClients();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvClients.DataSource = clsClient.FindByAccountNumber(txtSearch.Text);
            lblCountClients.Text = dgvClients.RowCount.ToString();

        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            clsClient Client = new clsClient();

            Client.FirstName = txtFirstName.Text;
            Client.LastName = txtLastName.Text;
            Client.Email = txtEmail.Text;
            Client.Phone = txtPhone.Text;
            Client.Account.AccountNumber = txtAccountNumber.Text;
            Client.Account.PinCode = txtPinCode.Text;
            Client.Account.Balance = Convert.ToDecimal(nudBalance.Value);

            if (Client.Save())
            {
                MessageBox.Show($"Client Added Successfully.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _LoadDataClients();
                tbManageClient.SelectedIndex = 0;
                txtAccountNumber.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
                txtPinCode.Clear();
                nudBalance.Value = 0;
            }
            else
            {
                MessageBox.Show("Client Not Added!", "Faild", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void tsmiUpdate_Click(object sender, EventArgs e)
        {

        }

        private void dgvClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbManageClient.SelectedIndex = 2;
            txtAccNumber.Text = dgvClients.CurrentRow.Cells[1].Value.ToString();
            txtPCode.Text = dgvClients.CurrentRow.Cells[2].Value.ToString();
            nudNewBalance.Value = Convert.ToDecimal(dgvClients.CurrentRow.Cells[3].Value);
            txtFName.Text = dgvClients.CurrentRow.Cells[4].Value.ToString();
            txtLName.Text = dgvClients.CurrentRow.Cells[5].Value.ToString();
            txtNewEmail.Text = dgvClients.CurrentRow.Cells[6].Value.ToString();
            txtNewPhone.Text = dgvClients.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clsClient Client = clsClient.Find((int)dgvClients.CurrentRow.Cells[0].Value);

            if (Client != null)
            {
                Client.FirstName = txtFName.Text;
                Client.LastName = txtLName.Text;
                Client.Email = txtNewEmail.Text;
                Client.Phone = txtNewPhone.Text;
                Client.Account.AccountNumber = txtAccNumber.Text;
                Client.Account.PinCode = txtPCode.Text;
                Client.Account.Balance = Convert.ToDecimal(nudNewBalance.Value);

                if (Client.Save())
                {
                    MessageBox.Show("Client Updated Successfully.", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    tbManageClient.SelectedIndex = 0;
                    _LoadDataClients();
                }
                else
                {
                    MessageBox.Show("Faild Update Client", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete This Client?", 
                "Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsClient.DeleteClient((int)dgvClients.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Client Deleted Successfully", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadDataClients();
                }
                else
                {
                    MessageBox.Show("Faild Delete Client", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtStrings_Validating(object sender, CancelEventArgs e)
        {
            TextBox txtStrings = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(txtStrings.Text))
            {
                e.Cancel = true;
                txtStrings.Focus();
                epClients.SetError(txtStrings, "Input Value In The Box!");
            }
            else
            {
                e.Cancel = false;
                epClients.SetError(txtStrings, "");
            }
        }

        private void txtEmails_Validating(object sender, CancelEventArgs e)
        {
            TextBox txtEmailClients = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(txtEmailClients.Text) || !txtEmailClients.Text.Contains("@") || !txtEmailClients.Text.Contains("."))
            {
                e.Cancel = true;
                txtEmailClients.Focus();
                epClients.SetError(txtEmailClients, "example@example.com");
            }
            else
            {
                e.Cancel = false;
                epClients.SetError(txtEmailClients, "");
            }
        }

        private void txtPhones_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtPhones_Validating(object sender, CancelEventArgs e)
        {
            TextBox txtPhones = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(txtPhones.Text) || !int.TryParse(txtPhones.Text, out int Phone))
            {
                e.Cancel = true;
                txtPhones.Focus();
                epClients.SetError(txtPhones, "0555555555");
            }
            else
            {
                e.Cancel = false;
                epClients.SetError(txtPhones, "");
            }
        }

        private void txtPinCodes_Validating(object sender, CancelEventArgs e)
        {
            TextBox txtPinCodes = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txtPinCodes.Text) || !int.TryParse(txtPinCodes.Text, out int PinCodes))
            {
                e.Cancel = true;
                txtPinCodes.Focus();
                epClients.SetError(txtPinCodes, "Value Should Be Numbers");
            }
            else
            {
                e.Cancel = false;
                epClients.SetError(txtPinCodes, "");
            }
        }
    }
}