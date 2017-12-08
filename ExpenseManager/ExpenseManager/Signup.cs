using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExpenseManager
{
    public partial class Signup : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-LNQRCD40;Initial Catalog=ExpenseManager;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public Signup()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            DisplayData();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" &&
                txt_pwd.Text != "" &&
               txt_email.Text!="")
            {
                cmd = new SqlCommand("insert into dbo.User_Profile(Username,EmailId,Password) " +
                "values(@name,@id,@pwd)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                cmd.Parameters.AddWithValue("@id", txt_email.Text);
                cmd.Parameters.AddWithValue("@pwd", txt_pwd.Text);
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

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.User_Profile", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void ClearData()
        {
            txt_Name.Text = "";
            txt_pwd.Text = "";
            txt_email.Text = "";
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_email.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_pwd.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        
        private void back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login home = new Login();
            home.Show();
        }
    }
}