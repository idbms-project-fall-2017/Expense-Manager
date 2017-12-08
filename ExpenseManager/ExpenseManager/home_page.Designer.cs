namespace ExpenseManager
{
    partial class home_page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.account = new System.Windows.Forms.Button();
            this.income = new System.Windows.Forms.Button();
            this.expense = new System.Windows.Forms.Button();
            this.owelend = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // account
            // 
            this.account.BackColor = System.Drawing.SystemColors.Info;
            this.account.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.account.Location = new System.Drawing.Point(516, 321);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(824, 81);
            this.account.TabIndex = 0;
            this.account.Text = "Account";
            this.account.UseVisualStyleBackColor = false;
            this.account.Click += new System.EventHandler(this.account_Click);
            // 
            // income
            // 
            this.income.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.income.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.income.Location = new System.Drawing.Point(516, 408);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(824, 81);
            this.income.TabIndex = 1;
            this.income.Text = "Income";
            this.income.UseVisualStyleBackColor = false;
            this.income.Click += new System.EventHandler(this.income_Click);
            // 
            // expense
            // 
            this.expense.BackColor = System.Drawing.SystemColors.Desktop;
            this.expense.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.expense.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.expense.Location = new System.Drawing.Point(516, 495);
            this.expense.Name = "expense";
            this.expense.Size = new System.Drawing.Size(824, 81);
            this.expense.TabIndex = 2;
            this.expense.Text = "Expense";
            this.expense.UseVisualStyleBackColor = false;
            this.expense.Click += new System.EventHandler(this.expense_Click);
            // 
            // owelend
            // 
            this.owelend.BackColor = System.Drawing.SystemColors.Highlight;
            this.owelend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.owelend.Location = new System.Drawing.Point(516, 582);
            this.owelend.Name = "owelend";
            this.owelend.Size = new System.Drawing.Size(824, 81);
            this.owelend.TabIndex = 3;
            this.owelend.Text = "Owe / Lend";
            this.owelend.UseVisualStyleBackColor = false;
            this.owelend.Click += new System.EventHandler(this.owelend_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Location = new System.Drawing.Point(1346, 127);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(117, 40);
            this.btn_LogOut.TabIndex = 4;
            this.btn_LogOut.Text = "Logout";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // home_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 697);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.owelend);
            this.Controls.Add(this.expense);
            this.Controls.Add(this.income);
            this.Controls.Add(this.account);
            this.Name = "home_page";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button account;
        private System.Windows.Forms.Button income;
        private System.Windows.Forms.Button expense;
        private System.Windows.Forms.Button owelend;
        private System.Windows.Forms.Button btn_LogOut;
    }
}