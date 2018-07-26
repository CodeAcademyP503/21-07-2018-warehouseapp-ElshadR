namespace ShoppingWindowForm.Forms
{
    partial class Menecer
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
            this.cb_users = new System.Windows.Forms.ComboBox();
            this.l_mnc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gr_box = new System.Windows.Forms.GroupBox();
            this.txb_total = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_adress = new System.Windows.Forms.TextBox();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.txb_role = new System.Windows.Forms.TextBox();
            this.txb_salary = new System.Windows.Forms.TextBox();
            this.txb_surname = new System.Windows.Forms.TextBox();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gr_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_users
            // 
            this.cb_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_users.Location = new System.Drawing.Point(28, 65);
            this.cb_users.Name = "cb_users";
            this.cb_users.Size = new System.Drawing.Size(121, 24);
            this.cb_users.TabIndex = 0;
            this.cb_users.Text = "Saticilar";
            this.cb_users.SelectedValueChanged += new System.EventHandler(this.cb_users_SelectedValueChanged);
            // 
            // l_mnc
            // 
            this.l_mnc.AutoSize = true;
            this.l_mnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_mnc.Location = new System.Drawing.Point(24, 33);
            this.l_mnc.Name = "l_mnc";
            this.l_mnc.Size = new System.Drawing.Size(0, 20);
            this.l_mnc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // gr_box
            // 
            this.gr_box.Controls.Add(this.txb_total);
            this.gr_box.Controls.Add(this.label8);
            this.gr_box.Controls.Add(this.txb_adress);
            this.gr_box.Controls.Add(this.txb_email);
            this.gr_box.Controls.Add(this.txb_password);
            this.gr_box.Controls.Add(this.txb_role);
            this.gr_box.Controls.Add(this.txb_salary);
            this.gr_box.Controls.Add(this.txb_surname);
            this.gr_box.Controls.Add(this.txb_name);
            this.gr_box.Controls.Add(this.label7);
            this.gr_box.Controls.Add(this.label6);
            this.gr_box.Controls.Add(this.label5);
            this.gr_box.Controls.Add(this.label4);
            this.gr_box.Controls.Add(this.label3);
            this.gr_box.Controls.Add(this.label2);
            this.gr_box.Controls.Add(this.label1);
            this.gr_box.Location = new System.Drawing.Point(202, 33);
            this.gr_box.Name = "gr_box";
            this.gr_box.Size = new System.Drawing.Size(323, 314);
            this.gr_box.TabIndex = 3;
            this.gr_box.TabStop = false;
            this.gr_box.Text = "Satici";
            // 
            // txb_total
            // 
            this.txb_total.Location = new System.Drawing.Point(108, 98);
            this.txb_total.Name = "txb_total";
            this.txb_total.Size = new System.Drawing.Size(147, 20);
            this.txb_total.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total:";
            // 
            // txb_adress
            // 
            this.txb_adress.Location = new System.Drawing.Point(108, 277);
            this.txb_adress.Name = "txb_adress";
            this.txb_adress.Size = new System.Drawing.Size(147, 20);
            this.txb_adress.TabIndex = 9;
            // 
            // txb_email
            // 
            this.txb_email.Location = new System.Drawing.Point(108, 241);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(147, 20);
            this.txb_email.TabIndex = 8;
            // 
            // txb_password
            // 
            this.txb_password.Location = new System.Drawing.Point(108, 206);
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(147, 20);
            this.txb_password.TabIndex = 7;
            // 
            // txb_role
            // 
            this.txb_role.Location = new System.Drawing.Point(108, 171);
            this.txb_role.Name = "txb_role";
            this.txb_role.Size = new System.Drawing.Size(147, 20);
            this.txb_role.TabIndex = 6;
            // 
            // txb_salary
            // 
            this.txb_salary.Location = new System.Drawing.Point(108, 133);
            this.txb_salary.Name = "txb_salary";
            this.txb_salary.Size = new System.Drawing.Size(147, 20);
            this.txb_salary.TabIndex = 5;
            // 
            // txb_surname
            // 
            this.txb_surname.Location = new System.Drawing.Point(108, 60);
            this.txb_surname.Name = "txb_surname";
            this.txb_surname.Size = new System.Drawing.Size(147, 20);
            this.txb_surname.TabIndex = 3;
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(108, 25);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(147, 20);
            this.txb_name.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Adress:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Role:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salary:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(397, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menecer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gr_box);
            this.Controls.Add(this.l_mnc);
            this.Controls.Add(this.cb_users);
            this.DoubleBuffered = true;
            this.Name = "Menecer";
            this.Text = "Menecer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menecer_FormClosed);
            this.Load += new System.EventHandler(this.Menecer_Load);
            this.gr_box.ResumeLayout(false);
            this.gr_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label l_mnc;
        private System.Windows.Forms.ComboBox cb_users;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gr_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_total;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_adress;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.TextBox txb_role;
        private System.Windows.Forms.TextBox txb_salary;
        private System.Windows.Forms.TextBox txb_surname;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.Button button1;
    }
}