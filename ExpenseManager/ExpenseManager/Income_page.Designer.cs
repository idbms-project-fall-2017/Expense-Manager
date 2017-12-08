namespace ExpenseManager
{
    partial class Income_page
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
            this.back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.income_label = new System.Windows.Forms.Label();
            this.amt = new System.Windows.Forms.TextBox();
            this.income = new System.Windows.Forms.TextBox();
            this.txt_iname = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(1302, 69);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(97, 43);
            this.back.TabIndex = 25;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(309, 536);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1175, 354);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(735, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Account";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(1058, 441);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(119, 57);
            this.delete.TabIndex = 21;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(877, 441);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(116, 57);
            this.edit.TabIndex = 20;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(703, 441);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(119, 57);
            this.add.TabIndex = 19;
            this.add.Text = "Add ";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(759, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(835, 302);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(294, 26);
            this.dateTimePicker.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(738, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Amount";
            // 
            // income_label
            // 
            this.income_label.AutoSize = true;
            this.income_label.Location = new System.Drawing.Point(657, 205);
            this.income_label.Name = "income_label";
            this.income_label.Size = new System.Drawing.Size(146, 20);
            this.income_label.TabIndex = 15;
            this.income_label.Text = "Income Description";
            // 
            // amt
            // 
            this.amt.Location = new System.Drawing.Point(835, 250);
            this.amt.Name = "amt";
            this.amt.Size = new System.Drawing.Size(294, 26);
            this.amt.TabIndex = 14;
            // 
            // income
            // 
            this.income.Location = new System.Drawing.Point(835, 199);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(294, 26);
            this.income.TabIndex = 13;
            // 
            // txt_iname
            // 
            this.txt_iname.FormattingEnabled = true;
            this.txt_iname.Location = new System.Drawing.Point(835, 155);
            this.txt_iname.Name = "txt_iname";
            this.txt_iname.Size = new System.Drawing.Size(294, 28);
            this.txt_iname.TabIndex = 26;
            this.txt_iname.SelectedIndexChanged += new System.EventHandler(this.txt_iname_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(679, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Current Balance";
            // 
            // bal
            // 
            this.bal.Enabled = false;
            this.bal.Location = new System.Drawing.Point(835, 356);
            this.bal.Name = "bal";
            this.bal.Size = new System.Drawing.Size(294, 26);
            this.bal.TabIndex = 28;
            // 
            // Income_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 675);
            this.Controls.Add(this.bal);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.income_label);
            this.Controls.Add(this.amt);
            this.Controls.Add(this.income);
            this.Name = "Income_page";
            this.Text = "Income_page";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label income_label;
        private System.Windows.Forms.TextBox amt;
        private System.Windows.Forms.TextBox income;
        private System.Windows.Forms.ComboBox txt_iname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bal;
    }
}