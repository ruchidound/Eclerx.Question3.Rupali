using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Eclerx.ADO.Rupali
{
    public partial class Form1 : Form
    {
        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private SqlDataAdapter adapter = null;
        private DataSet ds = null;
        private int Amount;

        public Form1()
        {
            InitializeComponent();
        }

        //Insert Account Details
        private void BtnCredit_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["Account"].ConnectionString))
            {
                using (cmd = new SqlCommand("usp_InsertAccountDetails", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AccountNo", TxtAccountNumber.Text);
                    cmd.Parameters.AddWithValue("@Amount", TxtAmount.Text);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("New Account Record Has Been Created!!");
        }

        //Save Account Details
        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["Account"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select AccountNo,TransactionType,Amount from AccountDetailsDemo where Amount=@Amount", con))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    ds = new DataSet();
                    adapter.Fill(ds, "Account");

                    DataRow dr = ds.Tables["Account"].Rows.Find(TxtAmount.Text);
                    DataView dv = ds.Tables["Account"].DefaultView;
                    if (comboTransactionType.SelectedIndex == 0)
                    {
                        dv.RowFilter = "@Amount + Amount";
                    }
                    else if (comboTransactionType.SelectedIndex == 1)
                    {
                        dv.RowFilter = "@Amount - Amount";
                    }
                    else if(Amount <= 10000)
                    {
                        MessageBox.Show("Balance Amount should be greater than 1000");
                    }
                    LblResult.Text = TxtAccountNumber.Text + TxtAmount.Text;
                    MessageBox.Show(LblResult.Text = $"{LblResult.Text}");
                }
            }
        }
    }
}
