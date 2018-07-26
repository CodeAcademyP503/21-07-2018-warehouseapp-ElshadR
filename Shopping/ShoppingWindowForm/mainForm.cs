using Shopping;
using ShoppingWindowForm.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingWindowForm
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            ShopDB.Initialize();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            int n=0;
     
            Warehouse newW = new Warehouse();
            foreach (User item in ShopDB.users)
            {
                if (item != null)
                {
                    if (item.Password != null)
                    {
                        if (item.Password == txb_password.Text && item.Name == txb_name.Text)
                        {
                            if (item.Role == Role.Administrator)
                            {
                                this.Hide();
                                localStorage.mainform = this;
                                n = item.showId();
                                TextBoxValueClear();
                                Administrator newAdminPanel = new Administrator();
                                newAdminPanel.ShowDialog();
                               
                            }
                            if (item.Role == Role.Menecer)
                            {
                                this.Hide();
                                localStorage.mainform = this;
                                n = item.showId();
                                TextBoxValueClear();
                                addLocalStorageShop(n);
                                Menecer newMenecer = new Menecer();
                                newMenecer.ShowDialog();
                               
                            }
                        }
                        
                    }
                }
            }
            
            
        }
        public void TextBoxValueClear()
        {
            foreach (Control ctr in Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox txb = ctr as TextBox;
                    txb.Text = "";
                }
            }
        }

        public void addLocalStorageShop(int n)
        {
            foreach (Warehouse shop in ShopDB.warehouses)
            {
                if (shop != null)
                {
                    foreach (User user in shop.users)
                    {
                        if (user != null)
                        {
                            if (user.showId() == n)
                            {
                                ShopDB.warehouse = shop;
                            }
                        }
                    }
                }
            }
        }
    }
}
