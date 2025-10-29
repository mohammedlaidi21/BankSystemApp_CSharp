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
    public partial class frmManageUsers : Form
    {
        private enum enPermission { eManageClients = 1, eClientTransactions = 2,
            eManageUsers = 4, eCurrencyExchange = 8 };
        private static int PermissionsUser = 0;

        clsUsers UserToUpdate;
        public frmManageUsers()
        {
            InitializeComponent();
        }

       
        private void _LoadLoginsRegisterInDataGrid()
        {
            dgvLoginsRegisters.DataSource = clsLoginRegister.GetAllLogins();
            dgvLoginsRegisters.ForeColor = Color.Black;
            lblCountLogins.Text = dgvLoginsRegisters.RowCount.ToString();
        }
        private void _LoadUsersInDataGrid()
        {
            dgvUsers.DataSource = clsUsers.GetAllUsers();
            for (int i = 0; i < dgvUsers.RowCount; i++)
            {
                dgvUsers.Rows[i].Cells[4].Value = clsUsers.DecryptPassword(dgvUsers.Rows[i].Cells[4].Value.ToString());
            } 
            dgvUsers.ForeColor = Color.Black;
            lblCountUsers.Text = dgvUsers.RowCount.ToString();
        }

        private void frmManageUsers_Load_1(object sender, EventArgs e)
        {
            _LoadUsersInDataGrid();
            _LoadLoginsRegisterInDataGrid();
            //this.ActiveControl = txtUsername;
            if (rbYesNew.Checked)
            {
                pNewPermission.Enabled = false;
            }
            else
            {
                pNewPermission.Enabled = true;
            }

        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            dgvUsers.DataSource = clsUsers.FindByUserName(txtSearchUser.Text);
            for (int i = 0; i < dgvUsers.RowCount; i++)
            {
                dgvUsers.Rows[i].Cells[4].Value = clsUsers.DecryptPassword(dgvUsers.Rows[i].Cells[4].Value.ToString());
            }
            lblCountUsers.Text = dgvUsers.RowCount.ToString();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            clsUsers NewUser = new clsUsers();

            NewUser.UserName = txtUsername.Text;
            NewUser.FirstName = txtFirstnameUser.Text;
            NewUser.LastName = txtLastnameUser.Text;
            NewUser.Email = txtEmailUser.Text;
            NewUser.Phone = txtPhoneUser.Text;
            NewUser.Password = clsUsers.EncryptPassword(txtPasswordUser.Text);
            NewUser.Permission = PermissionsUser;

            if (NewUser.save())
            {
                MessageBox.Show("User Added Successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                _LoadUsersInDataGrid();
                txtUsername.Clear();
                txtFirstnameUser.Clear();
                txtLastnameUser.Clear();
                txtEmailUser.Clear();
                txtPhoneUser.Clear();
                txtPasswordUser.Clear();
                pPermissions.Visible = false;
                rbYes.Checked = true;
                rbNo.Checked = false;
                cbManageClients.Checked = false;
                cbClientTransactions.Checked = false;
                cbManageUsers.Checked = false;
                cbCurrencyExchange.Checked = false;
                tabControl1.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Faild To Add User!.", "Faild",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void rbAnswer_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbAnswer = (RadioButton)sender;

            if (rbAnswer == rbYes || rbAnswer == rbYesNew)
            {
                if (rbAnswer.Checked)
                {
                  
                     if (rbAnswer == rbYes)
                     {
                        if (cbManageClients.Checked)
                            cbManageClients.Checked = false;
                        if (cbClientTransactions.Checked)
                            cbClientTransactions.Checked = false;
                        if (cbManageUsers.Checked)
                            cbManageUsers.Checked = false;
                        if (cbCurrencyExchange.Checked)
                            cbCurrencyExchange.Checked = false;
                     }

                     if (rbAnswer == rbYesNew)
                     {
                        if (cbNewManageClients.Checked)
                            cbNewManageClients.Checked = false;
                        if (cbNewClientTransactions.Checked)
                            cbNewClientTransactions.Checked = false;
                        if (cbNewManageUsers.Checked)
                            cbNewManageUsers.Checked = false;
                        if (cbNewCurrencyExchange.Checked)
                            cbNewCurrencyExchange.Checked = false;

                     }
                    PermissionsUser = -1;
                    pNewPermission.Enabled = false;
                }
                else
                {
                    PermissionsUser = 0;
                    pNewPermission.Enabled = true;
                }

                return;
            }

            if (rbAnswer == rbNo || rbAnswer == rbNoNew)
            {
                if (rbAnswer.Checked)
                {
                    pPermissions.Visible = true;
                }
                else
                {
                    pPermissions.Visible = false;
                }
                return;
            }
        }

        private void cbPermissions_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cbPermission = (CheckBox)sender;

            if (cbPermission == cbManageClients || cbPermission == cbNewManageClients)
            {

                if (cbPermission.Checked)
                    PermissionsUser += (int)enPermission.eManageClients;
                else
                    PermissionsUser -= (int)enPermission.eManageClients;    
            }

            if (cbPermission == cbClientTransactions || cbPermission == cbNewClientTransactions)
            {
                if (cbPermission.Checked)
                    PermissionsUser += (int)enPermission.eClientTransactions;
                else
                    PermissionsUser -= (int)enPermission.eClientTransactions;        
            }

            if (cbPermission == cbManageUsers || cbPermission == cbNewManageUsers)
            {
                if (cbPermission.Checked)
                    PermissionsUser += (int)enPermission.eManageUsers;

                else
                    PermissionsUser -= (int)enPermission.eManageUsers;
            }

            if (cbPermission == cbCurrencyExchange || cbPermission == cbNewCurrencyExchange)
            {
                if (cbPermission.Checked)
                    PermissionsUser += (int)enPermission.eCurrencyExchange;
                else
                    PermissionsUser -= (int)enPermission.eCurrencyExchange;            
            }
        }

        private void txtInput_Validating(object sender, CancelEventArgs e)
        {
            TextBox txtInput = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                e.Cancel = true;
                epUser.SetError(txtInput, "Invalid Champ Should Be a Value!");
            }
            else
            {
                e.Cancel = false;
                epUser.SetError(txtInput, "");

            }
        }



        private void txtEmails_Validating(object sender, CancelEventArgs e)
        {
            TextBox txtEmails = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(txtEmails.Text) || !txtEmails.Text.Contains("@") || !txtEmails.Text.Contains(".com"))
            {
                e.Cancel = true;
                epUser.SetError(txtEmails, "example@example.com");
            }
            else
            {
                e.Cancel = false;
                epUser.SetError(txtEmails, "");
            }
        }


        private void txtPhones_Validating(object sender, CancelEventArgs e)
        {
            TextBox txtPhones = (TextBox)sender;

            int Number = 0;

            if (!int.TryParse(txtPhones.Text, out Number) || (!txtPhones.Text.Contains("0")))
            {
                e.Cancel = true;
                epUser.SetError(txtPhones, "0555555555");
            }
            else
            {
                e.Cancel = false;
                epUser.SetError(txtPhones, "");
            }
        }

        private void dgvUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            UserToUpdate.UserName = txtNewUserName.Text;
            UserToUpdate.FirstName = txtNewFName.Text;
            UserToUpdate.LastName = txtNewLName.Text;
            UserToUpdate.Email = txtNewUserEmail.Text;
            UserToUpdate.Phone = txtNewPhoneUser.Text;
            UserToUpdate.Password = clsUsers.EncryptPassword(txtNewPassword.Text);
            UserToUpdate.Permission = PermissionsUser;

            if (UserToUpdate.save())
            {
                MessageBox.Show("User Updated Successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                _LoadUsersInDataGrid();
                tabControl1.SelectedIndex = 0;
                txtNewUserName.Clear();
                txtNewFName.Clear();
                txtNewLName.Clear();
                txtNewUserEmail.Clear();
                txtNewPhoneUser.Clear();
                txtNewPassword.Clear();
                rbYesNew.Checked = true;
                cbNewManageClients.Checked = false;
                cbNewClientTransactions.Checked = false;
                cbNewManageUsers.Checked = false;
                cbNewCurrencyExchange.Checked = false;
            }
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            UserToUpdate = clsUsers.FindByID((int)dgvUsers.CurrentRow.Cells[0].Value);

            if (UserToUpdate != null)
            {
                txtNewUserName.Text = UserToUpdate.UserName;
                txtNewUserName.Enabled = false;
                txtNewFName.Text = UserToUpdate.FirstName;
                txtNewLName.Text = UserToUpdate.LastName;
                txtNewUserEmail.Text = UserToUpdate.Email;
                txtNewPhoneUser.Text = UserToUpdate.Phone;
                txtNewPassword.Text = clsUsers.DecryptPassword(UserToUpdate.Password);
                int PermissionOldUser = UserToUpdate.Permission;
                PermissionsUser = 0;

                if (PermissionOldUser == -1)
                {
                    rbYesNew.Checked = true;
                    return;
                }



                rbNoNew.Checked = true;
                //pNewPermission.Enabled = true;

                if ((PermissionOldUser & (int)enPermission.eManageClients) == (int)enPermission.eManageClients)
                {
                    cbNewManageClients.Checked = true;
                }

                if ((PermissionOldUser & (int)enPermission.eClientTransactions) == (int)enPermission.eClientTransactions)
                {
                    cbNewClientTransactions.Checked = true;
                }

                if ((PermissionOldUser & (int)enPermission.eManageUsers) == (int)enPermission.eManageUsers)
                {
                    cbNewManageUsers.Checked = true;
                }

                if ((PermissionOldUser & (int)enPermission.eCurrencyExchange) == (int)enPermission.eCurrencyExchange)
                {
                    cbNewCurrencyExchange.Checked = true;
                }
            }
        }

        private void txtSearchLogins_TextChanged(object sender, EventArgs e)
        {
            dgvLoginsRegisters.DataSource = clsLoginRegister.FindByUserName(txtSearchLogins.Text);
            lblCountLogins.Text = dgvLoginsRegisters.RowCount.ToString();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete User?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsUsers.DeleteUser((int)dgvUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User Deleted Successfully.", "Succes",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadUsersInDataGrid();
                }
                else
                {
                    MessageBox.Show("Faild To Delete User.", "Faild",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
}
