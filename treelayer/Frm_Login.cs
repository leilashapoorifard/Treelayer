using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using DA;
using BL;

namespace treelayer
{
    public partial class Frm_Login : Form
    {
        private object username;
        private object password;
        private object q;

        public Frm_Login()
        {
            InitializeComponent();
        }
        public static bool Login(string password)
        {
            sabtbelit use = new sabtbelit();
            DataTable dt = new DataTable();
            dt = use.Login(password);
            if (dt == null)
            {
                return false;
            }
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
                return false;
        }
        private void sabtuser_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "admin" && txt_pass.Text == "123")
            {
                Frm_user  sabtkarbar = new Frm_user();
                sabtkarbar.Show();
            }
            else
            {
                MessageBox.Show("برای ثبت کاربر جدید به نام کاربری و پسورد آدمین نیاز دارید");

            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnvorod_Click(object sender, EventArgs e)
        {
            Frm_Customer cum = new Frm_Customer();
            cum.Show();
        }
    }
}
