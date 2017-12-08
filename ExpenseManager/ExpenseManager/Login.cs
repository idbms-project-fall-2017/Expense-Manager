using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ExpenseManager
{
    public partial class Login : Form
    {

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-LNQRCD40;Initial Catalog=ExpenseManager;Integrated Security=true;");
        SqlCommand cmd;

        public Login()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void signin_Click(object sender, EventArgs e)
        {
            
            if (email.Text == "" || password.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }

            try
            {
                cmd = new SqlCommand("Select EmailId, Password from dbo.User_Profile where EmailId=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", email.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);

                con.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    cmd = new SqlCommand(" SELECT USERNAME FROM[ExpenseManager].[dbo].User_Profile WHERE EmailId = @email;", con);
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    con.Open();
                    SqlDataReader rd;

                    rd = cmd.ExecuteReader();

                    if (rd.Read()) {
                        GlobalClass.GlobalVar = rd["USERNAME"].ToString();
                    }

                    this.Hide();
                    home_page fm = new home_page();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup s = new Signup();
            s.Show();
        }
    }
}


