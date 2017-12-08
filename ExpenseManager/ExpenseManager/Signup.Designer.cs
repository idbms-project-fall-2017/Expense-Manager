namespace ExpenseManager
{
    partial class Signup
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(723, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(867, 90);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(325, 30);
            this.txt_Name.TabIndex = 2;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(687, 302);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(544, 72);
            this.btn_Insert.TabIndex = 4;
            this.btn_Insert.Text = "Register";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(248, 517);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1466, 282);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(867, 154);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(325, 26);
            this.txt_email.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(723, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Email";
            // 
            // txt_pwd
            // 
            this.txt_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pwd.Location = new System.Drawing.Point(867, 217);
            this.txt_pwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(325, 30);
            this.txt_pwd.TabIndex = 16;
            this.txt_pwd.UseSystemPasswordChar = true;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(687, 400);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(544, 72);
            this.back.TabIndex = 24;
            this.back.Text = "Login";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(689, 222);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Password";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1546, 708);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label7;
    }
}

