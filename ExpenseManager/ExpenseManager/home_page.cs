using System;
using System.Windows.Forms;

namespace ExpenseManager
{
    public partial class home_page : Form
    {
        public home_page()
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            InitializeComponent();
        }

        private void account_Click(object sender, EventArgs e)
        {
            this.Hide();
            Account_page fm = new Account_page();
            fm.Show();
        }

        private void income_Click(object sender, EventArgs e)
        {
            this.Hide();
            Income_page fm = new Income_page();
            fm.Show();
        }

        private void expense_Click(object sender, EventArgs e)
        {
            this.Hide();
            Expense_page fm = new Expense_page();
            fm.Show();
        }

        private void owelend_Click(object sender, EventArgs e)
        {
            this.Hide();
            OweLend fm = new OweLend();
            fm.Show();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login fl = new Login();
            fl.Show();
        }
    }
}
