namespace ExpenseManager
{
    partial class Account_page
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
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.account = new System.Windows.Forms.TextBox();
            this.amt = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(701, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(701, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(664, 309);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(143, 46);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(863, 309);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(143, 46);
            this.edit.TabIndex = 3;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(1072, 309);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(143, 46);
            this.delete.TabIndex = 4;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // account
            // 
            this.account.Location = new System.Drawing.Point(863, 124);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(284, 26);
            this.account.TabIndex = 5;
            // 
            // amt
            // 
            this.amt.Location = new System.Drawing.Point(863, 187);
            this.amt.Name = "amt";
            this.amt.Size = new System.Drawing.Size(284, 26);
            this.amt.TabIndex = 6;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(1241, 59);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(85, 29);
            this.back.TabIndex = 7;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(322, 433);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1178, 378);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Account_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 719);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.amt);
            this.Controls.Add(this.account);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Account_page";
            this.Text = "Form page";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox account;
        private System.Windows.Forms.TextBox amt;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}