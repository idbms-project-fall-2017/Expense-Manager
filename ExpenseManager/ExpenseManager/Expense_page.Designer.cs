namespace ExpenseManager
{
    partial class Expense_page
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
            this.expense = new System.Windows.Forms.TextBox();
            this.amt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            this.txt_iname = new System.Windows.Forms.ComboBox();
            this.bal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // expense
            // 
            this.expense.Location = new System.Drawing.Point(800, 144);
            this.expense.Name = "expense";
            this.expense.Size = new System.Drawing.Size(306, 26);
            this.expense.TabIndex = 0;
            // 
            // amt
            // 
            this.amt.Location = new System.Drawing.Point(800, 196);
            this.amt.Name = "amt";
            this.amt.Size = new System.Drawing.Size(306, 26);
            this.amt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expense Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(703, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(800, 250);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(306, 26);
            this.dateTimePicker.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(724, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(696, 358);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(114, 46);
            this.add.TabIndex = 6;
            this.add.Text = "Add ";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(856, 358);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(96, 46);
            this.edit.TabIndex = 7;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(1006, 358);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(101, 46);
            this.delete.TabIndex = 8;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(700, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Account";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(393, 442);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1018, 282);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(1254, 61);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(97, 43);
            this.back.TabIndex = 12;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // txt_iname
            // 
            this.txt_iname.FormattingEnabled = true;
            this.txt_iname.Location = new System.Drawing.Point(800, 96);
            this.txt_iname.Name = "txt_iname";
            this.txt_iname.Size = new System.Drawing.Size(306, 28);
            this.txt_iname.TabIndex = 13;
            this.txt_iname.SelectedIndexChanged += new System.EventHandler(this.txt_iname_SelectedIndexChanged);
            // 
            // bal
            // 
            this.bal.Enabled = false;
            this.bal.Location = new System.Drawing.Point(800, 299);
            this.bal.Name = "bal";
            this.bal.Size = new System.Drawing.Size(306, 26);
            this.bal.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(644, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Current Balance";
            // 
            // Expense_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 669);
            this.Controls.Add(this.bal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_iname);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amt);
            this.Controls.Add(this.expense);
            this.Name = "Expense_page";
            this.Text = "Expense";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox expense;
        private System.Windows.Forms.TextBox amt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ComboBox txt_iname;
        private System.Windows.Forms.TextBox bal;
        private System.Windows.Forms.Label label5;
    }
}