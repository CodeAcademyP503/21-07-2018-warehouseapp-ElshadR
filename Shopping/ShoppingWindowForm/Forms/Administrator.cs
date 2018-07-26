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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }
        public int k = 0;
        private void Administrator_Load(object sender, EventArgs e)
        {
            int index = 0;
            foreach (Warehouse shop in ShopDB.warehouses)
            {
                if (shop != null)
                {
                    foreach (User user in shop.users)
                    {
                        if(user!=null && user.Role==Role.Satici)
                        {
                            works_list.Rows.Add();
                            works_list.Rows[index].Cells[0].Value = user.Name;
                            works_list.Rows[index].Cells[1].Value = user.Surname;
                            works_list.Rows[index].Cells[2].Value = user.Salary;
                            works_list.Rows[index].Cells[3].Value = user.Role.ToString();
                            works_list.Rows[index].Cells[4].Value = shop.Name;
                            if (shop.Grade!=null)
                            {
                                works_list.Rows[index].Cells[5].Value = shop.Grade.Name;
                            }
                            index++;
                        }
                    }
                }
            }
        }

        private void hesabla_Click(object sender, EventArgs e)
        {
            bool check = true;
            for (int i = 0; i < works_list.RowCount; i++)
            {
                if (Convert.ToString(works_list.Rows[i].Cells[8].Value)== "True")
                {
                    foreach (Warehouse shop in ShopDB.warehouses)
                    {
                        if (Convert.ToString(works_list.Rows[i].Cells[5].Value) == Convert.ToString(shop.Grade.Name))
                        {

                            foreach (User user in shop.users)
                            {
                                if (user != null)
                                {
                                       
                                    if (Convert.ToString(works_list.Rows[i].Cells[0].Value).ToLower() == user.Name.ToLower())
                                    {
                                        if (user.Total.ToString() == "0")
                                        {
                                            works_list.Rows[i].Cells[7].Value = user.Salary;
                                        }
                                    }
                                }
                            }
                            if (Convert.ToString(works_list.Rows[i].Cells[5].Value)=="G01")
                            {
                                decimal yoxla = 0;
                                int l = 0;
                                foreach (User user in shop.users)
                                {
                                    if (user != null)
                                    {
                                        yoxla += user.Total;
                                        l++;
                                    }
                                }
                                if (yoxla >= 100000)
                                {
                                    works_list.Rows[i].Cells[6].Value = 100;
                                    works_list.Rows[i].Cells[7].Value = 100 + 500;
                                    check = false;
                                }
                                
                                
                            }
                            if (Convert.ToString(works_list.Rows[i].Cells[5].Value)=="G02")
                            {
                                decimal yoxla = 0;
                                int l = 0;
                                foreach (User user in shop.users)
                                {
                                    if (user != null)
                                    {
                                        yoxla += user.Total;
                                        l++;
                                    }
                                }
                                if (yoxla >= 340000)
                                {
                                    works_list.Rows[i].Cells[6].Value = yoxla/(100*l);
                                    works_list.Rows[i].Cells[7].Value = yoxla / (100 * l) + 500;
                                    check = false;
                                }
                            }
                            if (Convert.ToString(works_list.Rows[i].Cells[5].Value) == "G02M")
                            {
                                decimal yoxla = 0;
                                int l = 0;
                                foreach (User user in shop.users)
                                {
                                    if (user != null)
                                    {
                                        yoxla += user.Total;
                                        l++;
                                    }
                                }
                                if (yoxla >= 340000)
                                {
                                    works_list.Rows[i].Cells[6].Value = yoxla / (500 * l);
                                    works_list.Rows[i].Cells[7].Value = yoxla / (500 * l) + 500;
                                }
                            }
                            if (Convert.ToString(works_list.Rows[i].Cells[5].Value) == "G02NS")
                            {
                                decimal yoxla = 0;
                                int l = 0;
                                foreach (User user in shop.users)
                                {
                                    if (user != null)
                                    {
                                        yoxla += user.Total;
                                        l++;
                                    }
                                }
                                if (yoxla >= 20000)
                                {
                                    works_list.Rows[i].Cells[6].Value = yoxla / (200 * l);
                                    works_list.Rows[i].Cells[7].Value = yoxla / (200 * l) + 500;
                                }
                            }
                            if (Convert.ToString(works_list.Rows[i].Cells[5].Value) == "G03M")
                            {
                                decimal yoxla = 0;
                                int l = 0;
                                foreach (User user in shop.users)
                                {
                                    if (user != null)
                                    {
                                        yoxla += user.Total;
                                        l++;
                                    }
                                }
                                if (yoxla >= 2000000)
                                {
                                    works_list.Rows[i].Cells[6].Value = yoxla / (20 * l);
                                    works_list.Rows[i].Cells[7].Value = yoxla / (20 * l) + 500;
                                }
                            }
                            if (Convert.ToString(works_list.Rows[i].Cells[5].Value) == "G04M")
                            {
                                decimal yoxla = 0;
                                int l = 0;
                                foreach (User user in shop.users)
                                {
                                    if (user != null)
                                    {
                                        yoxla += user.Total;
                                        l++;
                                    }
                                }
                                if (yoxla >= 2000000 &&yoxla<3000000)
                                {
                                    works_list.Rows[i].Cells[6].Value = (yoxla*3) / (100 * l);
                                    works_list.Rows[i].Cells[7].Value = (yoxla * 3) / (100 * l) + 500;
                                }
                                if (yoxla >= 3000000 && yoxla < 4000000)
                                {
                                    works_list.Rows[i].Cells[6].Value = (yoxla * 5) / (100 * l);
                                    works_list.Rows[i].Cells[7].Value = (yoxla * 5) / (100 *l) + 500;
                                }
                                if (yoxla >= 5000000)
                                {
                                    works_list.Rows[i].Cells[6].Value = (yoxla * 7) / (100 * l);
                                    works_list.Rows[i].Cells[7].Value = (yoxla * 7) / (100 * l) + 500;
                                }
                            }
                            
                        }
                        
                    }
                }
            }
        }

        private void Administrator_FormClosed(object sender, FormClosedEventArgs e)
        {
            localStorage.mainform.Show();
        }
    }
}
