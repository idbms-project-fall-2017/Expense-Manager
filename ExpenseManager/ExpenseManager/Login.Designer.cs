namespace ExpenseManager
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.signin = new System.Windows.Forms.Button();
            this.signup = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(237, 124);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(666, 26);
            this.email.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(237, 166);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(666, 26);
            this.password.TabIndex = 3;
            this.password.UseSystemPasswordChar = true;
            // 
            // signin
            // 
            this.signin.Location = new System.Drawing.Point(298, 249);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(570, 42);
            this.signin.TabIndex = 4;
            this.signin.Text = "Sign In";
            this.signin.UseVisualStyleBackColor = true;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // signup
            // 
            this.signup.Location = new System.Drawing.Point(298, 314);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(570, 42);
            this.signup.TabIndex = 5;
            this.signup.Text = "Sign up";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.signup);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.signin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Location = new System.Drawing.Point(304, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1125, 513);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SignIn";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 757);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button signin;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}