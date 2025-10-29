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
    public partial class Login : Form
    {
        int Attempts = 3;
        public Login()
        {
            InitializeComponent();
        }

        private void _AddLoginRegister(int UserID)
        {
            clsLoginRegister LoginRegister = new clsLoginRegister();
            LoginRegister.DateTimeLogin = DateTime.Now;
            LoginRegister.UserID = UserID;

            LoginRegister.Save();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!clsUsers.Login(txtUserName.Text, txtPassword.Text))
            {
                if (Attempts == 1)
                {
                    btnLogin.Enabled = false;
                    lblLockedUp.Text = "You are Locked After 3 Faild Trails" +
                        "\nContact Admin To Unlock Your Account";
                    lblLockedUp.ForeColor = Color.LightSlateGray;
                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Enabled = false;
                    txtPassword.Enabled = false;
                    return;
                }
                Attempts--;
                lblLockedUp.Text = "Invalid Username Or Password" +
                "\nYou Have " + Attempts + " attempts Before Lock Your Account";

            }
            else
            {
                _AddLoginRegister(clsCurrentUser.CurrentUser.UserID);
                Home frmHome = new Home();
                frmHome.ShowDialog();
                Attempts = 3;
                lblLockedUp.Text = "";
            }

            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void tDateTimeLog_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM yyyy \nHH:mm:ss tt");
        }
    }
}
