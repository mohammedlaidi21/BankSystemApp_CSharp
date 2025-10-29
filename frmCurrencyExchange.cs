using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSystem_BL_;

namespace BankSystem_Currencies
{
    public partial class frmCurrencyExchange : Form
    {
        clsCurrency CurrentCurrency;

        clsCurrency ConvertFrom, ConvertTo;
        public frmCurrencyExchange()
        {
            InitializeComponent();
        }

        
        private void _LoadCurrenciesData()
        {
            dgvCurrencies.DataSource = clsCurrency.GetAllCurrenciesData();
            dgvCurrencies.ForeColor = Color.Black;
            lblCountCurrency.Text = dgvCurrencies.RowCount.ToString();
        }
        private void _LoadCurrencyCodeComboBox()
        {
            DataTable Currencies = clsCurrency.GetAllCurrenciesData();

            foreach (DataRow Currency in Currencies.Rows)
            {
                cbCurrencyCode.Items.Add(Currency["Code"].ToString());
                cbConvertFrom.Items.Add(Currency["Code"].ToString());
                cbConvertTo.Items.Add(Currency["Code"].ToString());
            }
        }
        private void frmCurrencyExchange_Load(object sender, EventArgs e)
        {
            _LoadCurrenciesData();
            _LoadCurrencyCodeComboBox();
        }

        private void txtSearchCurrency_TextChanged(object sender, EventArgs e)
        {
            dgvCurrencies.DataSource = clsCurrency.FindByCodeOrCountryCurrency
                (txtSearchCurrency.Text, txtSearchCurrency.Text);
            lblCountCurrency.Text = dgvCurrencies.RowCount.ToString();
        }

        private void cbCurrencyCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentCurrency = clsCurrency.FindByCode(cbCurrencyCode.Text);

            if (CurrentCurrency != null)
            {
                lblCountry.Text = CurrentCurrency.Country;
                lblCode.Text = CurrentCurrency.Code;
                lblName.Text = CurrentCurrency.CurrencyName;
                lblRate.Text = "($" + CurrentCurrency.Rate + ")";
                nudNewRate.Value = Convert.ToDecimal(CurrentCurrency.Rate);
            }
        }
 

        private void btnUpdateRate_Click_1(object sender, EventArgs e)
        {

            if(MessageBox.Show("Are You Sure You Want To Update The Rate?", 
                "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                CurrentCurrency.Rate = Convert.ToDecimal(nudNewRate.Value);
                if(CurrentCurrency.Save())
                {
                    MessageBox.Show("Rate Updated Successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadCurrenciesData();
                    lblCountry.Text = "???";
                    lblCode.Text = "???";
                    lblName.Text = "???";
                    lblRate.Text = "($0)";
                    cbCurrencyCode.Text = "";
                    nudNewRate.Value = 0;
                }
                
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            decimal Amount = Convert.ToDecimal(nupAmountToExchange.Value);
            decimal Result = 0;

            if (cbConvertTo.Text == "USD")
            {
                Result = ConvertFrom.ConvertToDollar(Amount);
            }
            else
            {
                Result = ConvertFrom.ConvertToCurrency(ConvertTo, Amount);
            }

            lblResult.Text = nupAmountToExchange.Value.ToString() + " " + ConvertFrom.Code +
                " = " + Result.ToString("F4") + " " + ConvertTo.Code.ToString();
        }

        private void cbConverts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbConverts = (ComboBox)sender;

            if (cbConverts == cbConvertFrom)
            {
                ConvertFrom = clsCurrency.FindByCode(cbConverts.Text.ToString());
                lblCountryFrom.Text = ConvertFrom.Country;
                lblCodeFrom.Text = ConvertFrom.Code;
                lblNameFrom.Text = ConvertFrom.CurrencyName;
                lblRateFrom.Text = ConvertFrom.Rate.ToString();
            }

            if (cbConverts == cbConvertTo)
            {
                ConvertTo = clsCurrency.FindByCode(cbConverts.Text.ToString());
                lblCountryTo.Text = ConvertTo.Country;
                lblCodeTo.Text = ConvertTo.Code;
                lblNameTo.Text = ConvertTo.CurrencyName;
                lblRateTo.Text = ConvertTo.Rate.ToString();
            }
        }
    }
}
