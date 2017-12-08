using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExpenseManager
{
    public partial class Account_page : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-LNQRCD40;Initial Catalog=ExpenseManager;Integrated Security=true;");
        SqlCommand cmd;

        public Account_page()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            DisplayData();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            home_page fm = new home_page();
            fm.Show();
        }

        private void ClearData()
        {
            account.Text = "";
            amt.Text = "";
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (account.Text != "" &&
                amt.Text != "")
            {
                cmd = new SqlCommand("insert into dbo.Account " +
                "values(@account,@amt,@name)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@account", account.Text); 
                cmd.Parameters.AddWithValue("@amt", float.Parse(amt.Text));
                cmd.Parameters.AddWithValue("@name", GlobalClass.GlobalVar);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (account.Text != "")
            {
                cmd = new SqlCommand("update dbo.Account set AccountType=@a_type, Balance=@balance, Username=@u_name WHERE Username=@u_name AND AccountType = @a_type;", con);
                con.Open();
                //MessageBox.Show(account.Text);
                cmd.Parameters.AddWithValue("@a_type", account.Text);
                cmd.Parameters.AddWithValue("@balance", float.Parse(amt.Text));
                cmd.Parameters.AddWithValue("@u_name", GlobalClass.GlobalVar);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
                ClearData();
            }

            else {
                MessageBox.Show("Please Provide Details!");
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (account.Text != "")
            {
                cmd = new SqlCommand("delete dbo.Account where Username=@u_name AND AccountType=@a_type", con);
                con.Open();
                cmd.Parameters.AddWithValue("@a_type", account.Text);
                cmd.Parameters.AddWithValue("@u_name", GlobalClass.GlobalVar);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
                ClearData();
            }

            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void DisplayData()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-LNQRCD40;Initial Catalog=ExpenseManager;Integrated Security=true;");
            SqlDataAdapter adapt;
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM dbo.Account WHERE Username = @usr_n;", con);
            adapt.SelectCommand.Parameters.AddWithValue("@usr_n", GlobalClass.GlobalVar);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
                        
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            account.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            amt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
