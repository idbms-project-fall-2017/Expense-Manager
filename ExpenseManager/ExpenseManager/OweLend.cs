using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExpenseManager
{
    public partial class OweLend : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-LNQRCD40;Initial Catalog=ExpenseManager;Integrated Security=true;");
        SqlCommand cmd, cmd2;
        String usr;
        int ID = 0;
        public OweLend()
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            InitializeComponent();
            con.Open();
            usr = GlobalClass.GlobalVar;
            cmd2 = new SqlCommand("SELECT DISTINCT AccountType FROM dbo.Account WHERE Username = @user_n;", con);
            cmd2.Parameters.AddWithValue("@user_n", usr);
            SqlDataReader DR2 = cmd2.ExecuteReader();
            while (DR2.Read())
            {
                sender_a_type.Items.Add(DR2[0]);
            }
            DR2.Close();
            cmd2 = new SqlCommand("SELECT DISTINCT Username FROM Account WHERE Username <> @user_n;", con);
            cmd2.Parameters.AddWithValue("@user_n", usr);
            DR2 = cmd2.ExecuteReader();
            while (DR2.Read())
            {
                friend_v.Items.Add(DR2[0]);
            }
            DR2.Close();

            con.Close();
            DisplayData();
        }

        private void DisplayData()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-LNQRCD40;Initial Catalog=ExpenseManager;Integrated Security=true;");
            SqlDataAdapter adapt;
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.OweLend WHERE Username = @usr_n;", con);
            adapt.SelectCommand.Parameters.AddWithValue("@usr_n", GlobalClass.GlobalVar);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OweorLend.Text == "Owe")
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-LNQRCD40;Initial Catalog=ExpenseManager;Integrated Security=true;");
                SqlDataAdapter adapt;
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from dbo.OweLend WHERE Username = @usr_n AND OweLend = 'Owe';", con);
                adapt.SelectCommand.Parameters.AddWithValue("@usr_n", GlobalClass.GlobalVar);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

            else {
                if (OweorLend.Text == "Lend")
                {
                    SqlConnection con = new SqlConnection("Data Source=LAPTOP-LNQRCD40;Initial Catalog=ExpenseManager;Integrated Security=true;");
                    SqlDataAdapter adapt;
                    con.Open();
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("select * from dbo.OweLend WHERE Username = @usr_n AND OweLend = 'Lend';", con);
                    adapt.SelectCommand.Parameters.AddWithValue("@usr_n", GlobalClass.GlobalVar);
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                else {
                    SqlConnection con = new SqlConnection("Data Source=LAPTOP-LNQRCD40;Initial Catalog=ExpenseManager;Integrated Security=true;");
                    SqlDataAdapter adapt;
                    con.Open();
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("select * from dbo.OweLend WHERE Username = @usr_n;", con);
                    adapt.SelectCommand.Parameters.AddWithValue("@usr_n", GlobalClass.GlobalVar);
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
            }
        }

        private void ClearData()
        {
            amt.Text = "";
            desc.Text = "";
            OweorLend.Text = "";
            status.Text = "";
            sender_a_type.Text = "";
            r_a_type.Text = "";
            friend_v.Text = "";
        }

        private void add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-LNQRCD40;Initial Catalog=ExpenseManager;Integrated Security=true;");
            float v = 0;
            DateTime dateTime = DateTime.Today;

            if (amt.Text != "" && desc.Text != "" && OweorLend.Text != "" && status.Text != "" && sender_a_type.Text != "" && r_a_type.Text != "" && friend_v.Text != "") {
                con.Open();
                cmd = new SqlCommand("INSERT INTO dbo.OweLend (Amount, OweLend, Description, Status, SenderAccountType, ReceiverAccountType, Username, FriendUsername) VALUES(@amt, @ol, @desc, @status, @s_account, @r_account, @user_name, @f_user_name);", con);
                cmd.Parameters.AddWithValue("@amt", amt.Text);
                cmd.Parameters.AddWithValue("@desc", desc.Text);
                cmd.Parameters.AddWithValue("@ol", OweorLend.Text);
                cmd.Parameters.AddWithValue("@status", status.Text);
                cmd.Parameters.AddWithValue("@s_account", sender_a_type.Text);
                cmd.Parameters.AddWithValue("@r_account", r_a_type.Text);
                cmd.Parameters.AddWithValue("@f_user_name", friend_v.Text);
                cmd.Parameters.AddWithValue("@user_name", GlobalClass.GlobalVar);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("INSERT INTO dbo.OweLend (Amount, OweLend, Description, Status, SenderAccountType, ReceiverAccountType, Username, FriendUsername) VALUES(@amt, @ol, @desc, @status, @r_account, @s_account, @f_user_name, @user_name);", con);
                if (OweorLend.Text == "Owe")
                    cmd.Parameters.AddWithValue("@ol", "Lend");
                else if (OweorLend.Text == "Lend")
                    cmd.Parameters.AddWithValue("@ol", "Owe");
                cmd.Parameters.AddWithValue("@amt", amt.Text);
                cmd.Parameters.AddWithValue("@desc", desc.Text);
                cmd.Parameters.AddWithValue("@status", status.Text);
                cmd.Parameters.AddWithValue("@s_account", sender_a_type.Text);
                cmd.Parameters.AddWithValue("@r_account", r_a_type.Text);
                cmd.Parameters.AddWithValue("@f_user_name", friend_v.Text);
                cmd.Parameters.AddWithValue("@user_name", GlobalClass.GlobalVar);
                cmd.ExecuteNonQuery();
                if (OweorLend.Text == "Owe" && status.Text == "Complete")
                {
                    cmd = new SqlCommand("SELECT Balance FROM dbo.Account WHERE AccountType = @acct AND Username = @user_n", con);
                    cmd.Parameters.AddWithValue("@user_n", GlobalClass.GlobalVar);
                    cmd.Parameters.AddWithValue("@acct", sender_a_type.Text);
                    SqlDataReader DR2 = cmd.ExecuteReader();
                    while (DR2.Read())
                    {
                        v = float.Parse(DR2[0].ToString());
                        v = v - float.Parse(amt.Text);
                    }
                    if (v > 0)
                    {
                        cmd = new SqlCommand("UPDATE dbo.Account SET Balance = @b WHERE AccountType = @acct AND Username = @user_n", con);
                        cmd.Parameters.AddWithValue("@b", v);
                        cmd.Parameters.AddWithValue("@user_n", usr);
                        cmd.Parameters.AddWithValue("@acct", sender_a_type.Text);
                        DR2.Close();
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand("INSERT INTO dbo.Expense (AccountType, Amount, Type_Expense, CreatedAt, Username) VALUES (@s_account, @amt, @desc, @date, @user_name);", con);
                        cmd.Parameters.AddWithValue("@amt", amt.Text);
                        cmd.Parameters.AddWithValue("@desc", desc.Text + " - " + friend_v.Text);
                        cmd.Parameters.AddWithValue("@date", dateTime.ToString("dd-MM-yyyy").ToString());
                        cmd.Parameters.AddWithValue("@s_account", sender_a_type.Text);
                        cmd.Parameters.AddWithValue("@user_name", GlobalClass.GlobalVar);
                        cmd.ExecuteNonQuery();
                    }
                    cmd = new SqlCommand("SELECT Balance FROM dbo.Account WHERE AccountType = @acct AND Username = @user_n", con);
                    cmd.Parameters.AddWithValue("@user_n", friend_v.Text);
                    cmd.Parameters.AddWithValue("@acct", r_a_type.Text);
                    DR2 = cmd.ExecuteReader();
                    while (DR2.Read())
                    {
                        v = float.Parse(DR2[0].ToString());
                        v = v + float.Parse(amt.Text);
                    }
                    cmd = new SqlCommand("UPDATE dbo.Account SET Balance = @b WHERE AccountType = @acct AND Username = @user_n", con);
                    cmd.Parameters.AddWithValue("@b", v.ToString());
                    cmd.Parameters.AddWithValue("@user_n", friend_v.Text);
                    cmd.Parameters.AddWithValue("@acct", r_a_type.Text);
                    DR2.Close();
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("INSERT INTO dbo.Income (AccountType, Amount, Type_Income, CreatedAt, Username) VALUES (@r_account, @amt, @desc, @date, @f_name);", con);
                    cmd.Parameters.AddWithValue("@amt", amt.Text);
                    cmd.Parameters.AddWithValue("@desc", desc.Text + " - " + GlobalClass.GlobalVar);
                    cmd.Parameters.AddWithValue("@date", dateTime.ToString("dd-MM-yyyy").ToString());
                    cmd.Parameters.AddWithValue("@r_account", r_a_type.Text);
                    cmd.Parameters.AddWithValue("@f_name", friend_v.Text);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    if (status.Text == "Complete" && OweorLend.Text == "Lend")
                    {
                        cmd = new SqlCommand("SELECT Balance FROM dbo.Account WHERE AccountType = @acct AND Username = @user_n", con);
                        cmd.Parameters.AddWithValue("@user_n", friend_v.Text);
                        cmd.Parameters.AddWithValue("@acct", r_a_type.Text);
                        SqlDataReader DR2 = cmd.ExecuteReader();
                        while (DR2.Read())
                        {
                            v = float.Parse(DR2[0].ToString());
                            v = v - float.Parse(amt.Text);
                        }
                        DR2.Close();
                        if (v >= 0)
                        {
                            cmd = new SqlCommand("UPDATE dbo.Account SET Balance = @b WHERE AccountType = @acct AND Username = @user_n", con);
                            cmd.Parameters.AddWithValue("@b", v);
                            cmd.Parameters.AddWithValue("@user_n", friend_v.Text);
                            cmd.Parameters.AddWithValue("@acct", r_a_type.Text);
                            cmd.ExecuteNonQuery();
                            cmd = new SqlCommand("INSERT INTO dbo.Expense (AccountType, Amount, Type_Expense, CreatedAt, Username) VALUES (@r_account, @amt, @desc, @date, @f_name);", con);
                            cmd.Parameters.AddWithValue("@amt", amt.Text);
                            cmd.Parameters.AddWithValue("@desc", desc.Text + " - " + GlobalClass.GlobalVar);
                            cmd.Parameters.AddWithValue("@date", dateTime.ToString("dd/MM/yyyy").ToString());
                            cmd.Parameters.AddWithValue("@r_account", r_a_type.Text);
                            cmd.Parameters.AddWithValue("@f_name", friend_v.Text);
                            cmd.ExecuteNonQuery();
                        }

                        cmd = new SqlCommand("SELECT Balance FROM dbo.Account WHERE AccountType = @acct AND Username = @user_n", con);
                        cmd.Parameters.AddWithValue("@user_n", GlobalClass.GlobalVar);
                        cmd.Parameters.AddWithValue("@acct", sender_a_type.Text);
                        DR2 = cmd.ExecuteReader();
                        while (DR2.Read())
                        {
                            v = float.Parse(DR2[0].ToString());
                            v = v + float.Parse(amt.Text);
                        }

                        cmd = new SqlCommand("UPDATE dbo.Account SET Balance = @b WHERE AccountType = @acct AND Username = @user_n", con);
                        cmd.Parameters.AddWithValue("@b", v.ToString());
                        cmd.Parameters.AddWithValue("@user_n", GlobalClass.GlobalVar);
                        cmd.Parameters.AddWithValue("@acct", sender_a_type.Text);
                        DR2.Close();
                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand("INSERT INTO dbo.Income (AccountType, Amount, Type_Income, CreatedAt, Username) VALUES (@s_account, @amt, @desc, @date, @user_name);", con);
                        cmd.Parameters.AddWithValue("@amt", amt.Text);
                        cmd.Parameters.AddWithValue("@desc", desc.Text + " - " + friend_v.Text);
                        cmd.Parameters.AddWithValue("@date", dateTime.ToString("dd/MM/yyyy").ToString());
                        cmd.Parameters.AddWithValue("@s_account", sender_a_type.Text);
                        cmd.Parameters.AddWithValue("@user_name", GlobalClass.GlobalVar);
                        cmd.ExecuteNonQuery();
                    }
                }
                ClearData();
                DisplayData();
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ClearData();
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            amt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            OweorLend.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            desc.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            status.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            sender_a_type.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            r_a_type.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            friend_v.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            home_page fm = new home_page();
            fm.Show();
        }

        private void friend_v_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            r_a_type.Items.Clear();
            cmd2 = new SqlCommand("SELECT DISTINCT AccountType FROM dbo.Account WHERE Username = @friend;", con);
            cmd2.Parameters.AddWithValue("@friend", friend_v.Text);
            SqlDataReader DR2 = cmd2.ExecuteReader();
            while (DR2.Read())
            {
                r_a_type.Items.Add(DR2[0]);
            }
            DR2.Close();
            con.Close();
            DisplayData();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ClearData();
            DisplayData();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            float v = 0;
            String uname = "";
            String AccountType = "";
            if (amt.Text != "" && desc.Text != "" && OweorLend.Text != "" && status.Text != "" && sender_a_type.Text != "" && r_a_type.Text != "" && friend_v.Text != "")
            {
                con.Open();
                cmd = new SqlCommand("DELETE FROM dbo.OweLend WHERE Amount = @amt AND Description = @desc AND STATUS = @status;", con);
                cmd.Parameters.AddWithValue("@amt", amt.Text);
                cmd.Parameters.AddWithValue("@desc", desc.Text);
                cmd.Parameters.AddWithValue("@status", status.Text);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("SELECT Username, AccountType FROM dbo.Income WHERE Type_Income LIKE @type AND Amount = @amt;", con);
                cmd.Parameters.AddWithValue("@type", desc.Text + " %");
                cmd.Parameters.AddWithValue("@amt", amt.Text);
                SqlDataReader DR2 = cmd.ExecuteReader();
                while (DR2.Read())
                {
                    uname = DR2[0].ToString();
                    AccountType = DR2[1].ToString();
                }
                DR2.Close();

                cmd = new SqlCommand("SELECT Balance FROM dbo.Account WHERE AccountType = @acct AND Username = @user_n", con);
                cmd.Parameters.AddWithValue("@user_n", uname);
                cmd.Parameters.AddWithValue("@acct", AccountType);
                DR2 = cmd.ExecuteReader();
                while (DR2.Read())
                {
                    v = float.Parse(DR2[0].ToString());
                    v = v - float.Parse(amt.Text);
                }

                if (v > 0)
                {
                    con.Close();
                    con.Open();
                    cmd = new SqlCommand("UPDATE dbo.Account SET Balance = @b WHERE AccountType = @acct AND Username = @user_n", con);
                    cmd.Parameters.AddWithValue("@b", v);
                    cmd.Parameters.AddWithValue("@user_n", uname);
                    cmd.Parameters.AddWithValue("@acct", AccountType);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                con.Close();
                DR2.Close();
                con.Open();
                cmd = new SqlCommand("DELETE FROM dbo.Income WHERE Type_Income LIKE @type AND Amount = @amt;", con);
                cmd.Parameters.AddWithValue("@amt", amt.Text);
                cmd.Parameters.AddWithValue("@type", desc.Text + " %");
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("SELECT Username, AccountType FROM dbo.Expense WHERE Type_Expense LIKE @type AND Amount = @amt;", con);
                cmd.Parameters.AddWithValue("@type", desc.Text + " %");
                cmd.Parameters.AddWithValue("@amt", amt.Text);
                DR2 = cmd.ExecuteReader();
                while (DR2.Read())
                {
                    uname = DR2[0].ToString();
                    AccountType = DR2[1].ToString();
                }
                DR2.Close();
                cmd = new SqlCommand("SELECT Balance FROM dbo.Account WHERE AccountType = @acct AND Username = @user_n", con);
                cmd.Parameters.AddWithValue("@user_n", uname);
                cmd.Parameters.AddWithValue("@acct", AccountType);
                DR2 = cmd.ExecuteReader();
                while (DR2.Read())
                {
                    v = float.Parse(DR2[0].ToString());
                    v = v + float.Parse(amt.Text);
                }
                DR2.Close();
                cmd = new SqlCommand("UPDATE dbo.Account SET Balance = @b WHERE AccountType = @acct AND Username = @user_n", con);
                cmd.Parameters.AddWithValue("@b", v);
                cmd.Parameters.AddWithValue("@user_n", uname);
                cmd.Parameters.AddWithValue("@acct", AccountType);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("DELETE FROM dbo.Expense WHERE Type_Expense LIKE @type AND Amount = @amt;", con);
                cmd.Parameters.AddWithValue("@amt", amt.Text);
                cmd.Parameters.AddWithValue("@type", desc.Text + " %");
                cmd.ExecuteNonQuery();
                ClearData();
                DisplayData();
                con.Close();
            }
        
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }
    }
}
