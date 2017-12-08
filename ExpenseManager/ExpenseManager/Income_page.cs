using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExpenseManager
{
    public partial class Income_page : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-LNQRCD40;Initial Catalog=ExpenseManager;Integrated Security=true;");
        SqlCommand cmd, cmd2;
        String usr;
        int ID = 0;

        public Income_page()
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            InitializeComponent();
            usr = GlobalClass.GlobalVar;
            con.Open();
            cmd2 = new SqlCommand("SELECT DISTINCT AccountType FROM dbo.Account WHERE Username = @user_n;", con);
            cmd2.Parameters.AddWithValue("@user_n", usr);
            SqlDataReader DR2 = cmd2.ExecuteReader();
            while (DR2.Read())
            {
                txt_iname.Items.Add(DR2[0]);
            }
            DR2.Close();
            con.Close();
            DisplayData();
        }

        private void ClearData()
        {   
            amt.Text = "";
            income.Text = "";
            txt_iname.Text = "";
            bal.Text = "";
        }

        private void add_Click(object sender, EventArgs e)
        {
            float v = 0;
            if (income.Text != "" &&
                amt.Text != "" && (string)txt_iname.SelectedItem != "")
            {
                con.Open();
                cmd = new SqlCommand("SELECT Balance FROM dbo.Account WHERE AccountType = @acct AND Username = @user_n", con);
                cmd.Parameters.AddWithValue("@user_n", usr);
                cmd.Parameters.AddWithValue("@acct", txt_iname.Text);
                SqlDataReader DR2 = cmd.ExecuteReader();
                while (DR2.Read())
                {
                    v = float.Parse(DR2[0].ToString());
                    v = v + float.Parse(amt.Text);
                }

                cmd = new SqlCommand("UPDATE dbo.Account SET Balance = @b WHERE AccountType = @acct AND Username = @user_n", con);
                cmd.Parameters.AddWithValue("@b", v.ToString());
                cmd.Parameters.AddWithValue("@user_n", usr);
                cmd.Parameters.AddWithValue("@acct", txt_iname.Text);
                DR2.Close();
                cmd.ExecuteNonQuery();
                con.Close();

                cmd = new SqlCommand("Insert INTO[ExpenseManager].[dbo].[Income] (AccountType, Amount, Type_Income, CreatedAt, Username) values(@account, @amt, @type, @created, @name);", con);
                con.Open();
                cmd.Parameters.AddWithValue("@account", (string)txt_iname.SelectedItem);
                cmd.Parameters.AddWithValue("@amt", float.Parse(amt.Text));
                cmd.Parameters.AddWithValue("@type", income.Text);
                cmd.Parameters.AddWithValue("@name", usr);
                cmd.Parameters.AddWithValue("@created", dateTimePicker.Value.ToString("yyyy-MM-dd"));
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
            float v = 0, t = 0;
            if (income.Text != "" &&
                amt.Text != "" && (string)txt_iname.SelectedItem != "")
            {
                con.Open();
                cmd = new SqlCommand("SELECT Amount FROM dbo.Income WHERE IncomeId = @id;", con);
                cmd.Parameters.AddWithValue("@id", ID);
                SqlDataReader DR2 = cmd.ExecuteReader();

                while (DR2.Read())
                {
                    t = float.Parse(DR2[0].ToString());
                }
                DR2.Close();

                cmd = new SqlCommand("SELECT Balance FROM dbo.Account WHERE AccountType = @acct AND Username = @user_n", con);
                cmd.Parameters.AddWithValue("@user_n", usr);
                cmd.Parameters.AddWithValue("@acct", txt_iname.Text);
                DR2 = cmd.ExecuteReader();
                while (DR2.Read())
                {
                    v = float.Parse(DR2[0].ToString());
                    v = v - t + float.Parse(amt.Text);
                }
                con.Close();
                              
                con.Open();
                cmd = new SqlCommand("UPDATE dbo.Account SET Balance = @b WHERE AccountType = @acct AND Username = @user_n", con);
                cmd.Parameters.AddWithValue("@b", v.ToString());
                cmd.Parameters.AddWithValue("@user_n", usr);
                cmd.Parameters.AddWithValue("@acct", txt_iname.Text);
                DR2.Close();
                cmd.ExecuteNonQuery();
                con.Close();
                
                cmd = new SqlCommand("update dbo.Income set AccountType = @account, Amount = @amt, Type_Income = @type, CreatedAt = @created WHERE Incomeid = @id;", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@account", (string)txt_iname.SelectedItem);
                cmd.Parameters.AddWithValue("@amt", float.Parse(amt.Text));
                cmd.Parameters.AddWithValue("@type", income.Text);
                cmd.Parameters.AddWithValue("@name", usr);
                cmd.Parameters.AddWithValue("@created", dateTimePicker.Value.ToString("yyyy-MM-dd"));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated!");
                DisplayData();
                ClearData();
            }

            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            float v = 0, t = 0;
            if (income.Text != "" &&
                amt.Text != "" && (string)txt_iname.SelectedItem != "")
            {
                con.Open();
                cmd = new SqlCommand("SELECT Amount FROM dbo.Income WHERE Incomeid = @id;", con);
                cmd.Parameters.AddWithValue("@id", ID);
                SqlDataReader DR2 = cmd.ExecuteReader();

                while (DR2.Read())
                {
                    t = float.Parse(DR2[0].ToString());
                }
                DR2.Close();

                cmd = new SqlCommand("SELECT Balance FROM dbo.Account WHERE AccountType = @acct AND Username = @user_n", con);
                cmd.Parameters.AddWithValue("@user_n", usr);
                cmd.Parameters.AddWithValue("@acct", txt_iname.Text);
                DR2 = cmd.ExecuteReader();
                while (DR2.Read())
                {
                    v = float.Parse(DR2[0].ToString());
                    v = v - t;
                }
                DR2.Close();

                cmd = new SqlCommand("UPDATE dbo.Account SET Balance = @b WHERE AccountType = @acct AND Username = @user_n", con);
                cmd.Parameters.AddWithValue("@b", v.ToString());
                cmd.Parameters.AddWithValue("@user_n", usr);
                cmd.Parameters.AddWithValue("@acct", txt_iname.Text);
                DR2.Close();
                cmd.ExecuteNonQuery();
                con.Close();

                cmd = new SqlCommand("DELETE FROM dbo.Income WHERE IncomeId = @id;", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            home_page fm = new home_page();
            fm.Show();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_iname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            amt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            income.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePicker.Value = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
        }

        private void txt_iname_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            cmd2 = new SqlCommand("SELECT Balance FROM dbo.Account WHERE Username = @usr AND AccountType = @account;", con);
            cmd2.Parameters.AddWithValue("@account", txt_iname.Text);
            cmd2.Parameters.AddWithValue("@usr", GlobalClass.GlobalVar);
            SqlDataReader DR2 = cmd2.ExecuteReader();
            while (DR2.Read())
            {
                bal.Text =  DR2[0].ToString();
            }
            DR2.Close();
            con.Close();
        }

        private void DisplayData()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-LNQRCD40;Initial Catalog=ExpenseManager;Integrated Security=true;");
            SqlDataAdapter adapt;
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.Income WHERE Username = @usr_n;", con);
            adapt.SelectCommand.Parameters.AddWithValue("@usr_n", GlobalClass.GlobalVar);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
