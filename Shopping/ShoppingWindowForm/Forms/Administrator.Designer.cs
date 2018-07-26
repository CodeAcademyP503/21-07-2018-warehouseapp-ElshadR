namespace ShoppingWindowForm.Forms
{
    partial class Administrator
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
            this.hesabla = new System.Windows.Forms.Button();
            this.works_list = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yekun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emeliyyat = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.works_list)).BeginInit();
            this.SuspendLayout();
            // 
            // hesabla
            // 
            this.hesabla.BackColor = System.Drawing.Color.Green;
            this.hesabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hesabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hesabla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hesabla.Location = new System.Drawing.Point(554, 353);
            this.hesabla.Name = "hesabla";
            this.hesabla.Size = new System.Drawing.Size(120, 38);
            this.hesabla.TabIndex = 2;
            this.hesabla.Text = "HESABLA";
            this.hesabla.UseVisualStyleBackColor = false;
            this.hesabla.Click += new System.EventHandler(this.hesabla_Click);
            // 
            // works_list
            // 
            this.works_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.works_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.surname,
            this.salary,
            this.role,
            this.shop,
            this.grade,
            this.bonus,
            this.yekun,
            this.emeliyyat});
            this.works_list.Location = new System.Drawing.Point(12, 12);
            this.works_list.Name = "works_list";
            this.works_list.Size = new System.Drawing.Size(662, 335);
            this.works_list.TabIndex = 3;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.Width = 70;
            // 
            // surname
            // 
            this.surname.HeaderText = "Surname";
            this.surname.Name = "surname";
            this.surname.Width = 70;
            // 
            // salary
            // 
            this.salary.HeaderText = "Salary";
            this.salary.Name = "salary";
            this.salary.Width = 50;
            // 
            // role
            // 
            this.role.HeaderText = "Role";
            this.role.Name = "role";
            // 
            // shop
            // 
            this.shop.HeaderText = "Shop";
            this.shop.Name = "shop";
            // 
            // grade
            // 
            this.grade.HeaderText = "Grade";
            this.grade.Name = "grade";
            this.grade.Width = 50;
            // 
            // bonus
            // 
            this.bonus.HeaderText = "Bonus";
            this.bonus.Name = "bonus";
            this.bonus.Width = 50;
            // 
            // yekun
            // 
            this.yekun.HeaderText = "Yekun";
            this.yekun.Name = "yekun";
            this.yekun.Width = 50;
            // 
            // emeliyyat
            // 
            this.emeliyyat.HeaderText = "Emeliyyat";
            this.emeliyyat.Name = "emeliyyat";
            this.emeliyyat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.emeliyyat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.emeliyyat.Width = 60;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.works_list);
            this.Controls.Add(this.hesabla);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Administrator_FormClosed);
            this.Load += new System.EventHandler(this.Administrator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.works_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button hesabla;
        private System.Windows.Forms.DataGridView works_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn shop;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn yekun;
        private System.Windows.Forms.DataGridViewCheckBoxColumn emeliyyat;
    }
}