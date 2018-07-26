using Shopping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingWindowForm.Forms
{
    public partial class Menecer : Form
    {
        public Menecer()
        {
            InitializeComponent();
        }
        public void groupBoxEnabled()
        {
            if (cb_users.SelectedIndex == -1)
            {
                gr_box.Enabled = false;
            }
            else
            {
                gr_box.Enabled = true;
            }
        }

        private void Menecer_Load(object sender, EventArgs e)
        {
            if (ShopDB.warehouse != null)
            {
                foreach (User item in ShopDB.warehouse.users)
                {
                    if (item != null)
                    {

                        if (item.Role == Role.Menecer)
                        {
                            l_mnc.Text = item.Name;
                        }
                        if (item.Role == Role.Satici)
                        {
                            cb_users.Items.Add(item.Name);
                        }
                    }
                }
            }
            groupBoxEnabled();
        }

        private void cb_users_SelectedValueChanged(object sender, EventArgs e)
        {
            groupBoxEnabled();

            foreach (User item in ShopDB.users)
            {
                if (item!=null && cb_users.Text == item.Name)
                {
                    txb_name.Text = item.Name;
                    txb_surname.Text = item.Surname;
                    txb_total.Text = item.Total.ToString();
                    txb_salary.Text = item.Salary.ToString();
                    txb_role.Text = item.Role.ToString();
                    txb_password.Text = item.Password;
                    txb_email.Text = item.Email;
                    txb_adress.Text = item.Adress;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (User item in ShopDB.users)
            {
                if (item != null && cb_users.Text == item.Name)
                {
                    item.Name = txb_name.Text;
                    item.Surname = txb_surname.Text;
                    item.Total = Convert.ToDecimal(txb_total.Text);
                    item.Salary = Convert.ToDecimal(txb_salary.Text);
                    item.Password = txb_password.Text;
                    item.Email = txb_email.Text;
                    item.Adress = txb_adress.Text;
                }
            }
        }

        private void Menecer_FormClosed(object sender, FormClosedEventArgs e)
        {
            localStorage.mainform.Show();
        }
    }
}
