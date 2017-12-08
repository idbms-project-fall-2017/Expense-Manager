namespace ExpenseManager
{
    partial class OweLend
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.r_a_type = new System.Windows.Forms.ComboBox();
            this.friend_v = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sender_a_type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.desc = new System.Windows.Forms.TextBox();
            this.OweorLend = new System.Windows.Forms.ComboBox();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.amt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.r_a_type);
            this.groupBox1.Controls.Add(this.friend_v);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.sender_a_type);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.status);
            this.groupBox1.Controls.Add(this.desc);
            this.groupBox1.Controls.Add(this.OweorLend);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.amt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(366, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1082, 630);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Owe/Lend";
            // 
            // r_a_type
            // 
            this.r_a_type.FormattingEnabled = true;
            this.r_a_type.Location = new System.Drawing.Point(413, 423);
            this.r_a_type.Name = "r_a_type";
            this.r_a_type.Size = new System.Drawing.Size(453, 28);
            this.r_a_type.TabIndex = 20;
            // 
            // friend_v
            // 
            this.friend_v.FormattingEnabled = true;
            this.friend_v.Location = new System.Drawing.Point(412, 119);
            this.friend_v.Name = "friend_v";
            this.friend_v.Size = new System.Drawing.Size(453, 28);
            this.friend_v.TabIndex = 19;
            this.friend_v.SelectedIndexChanged += new System.EventHandler(this.friend_v_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Receiver Account Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sender Account Type";
            // 
            // sender_a_type
            // 
            this.sender_a_type.FormattingEnabled = true;
            this.sender_a_type.Location = new System.Drawing.Point(412, 368);
            this.sender_a_type.Name = "sender_a_type";
            this.sender_a_type.Size = new System.Drawing.Size(454, 28);
            this.sender_a_type.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Description";
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Incomplete",
            "Complete"});
            this.status.Location = new System.Drawing.Point(413, 302);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(453, 28);
            this.status.TabIndex = 11;
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(413, 243);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(453, 26);
            this.desc.TabIndex = 10;
            // 
            // OweorLend
            // 
            this.OweorLend.FormattingEnabled = true;
            this.OweorLend.Items.AddRange(new object[] {
            "Owe",
            "Lend"});
            this.OweorLend.Location = new System.Drawing.Point(413, 68);
            this.OweorLend.Name = "OweorLend";
            this.OweorLend.Size = new System.Drawing.Size(453, 28);
            this.OweorLend.TabIndex = 9;
            this.OweorLend.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(668, 509);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(106, 51);
            this.delete.TabIndex = 7;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(508, 509);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(106, 51);
            this.add.TabIndex = 6;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // amt
            // 
            this.amt.Location = new System.Drawing.Point(413, 183);
            this.amt.Name = "amt";
            this.amt.Size = new System.Drawing.Size(453, 26);
            this.amt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Owe/Lend Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Owe/Lend To";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(205, 697);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1458, 436);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1629, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Owe/Lend";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // OweLend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1796, 1007);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "OweLend";
            this.Text = "OweLend";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amt;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox OweorLend;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sender_a_type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox friend_v;
        private System.Windows.Forms.ComboBox r_a_type;
        private System.Windows.Forms.Label label7;
    }
}