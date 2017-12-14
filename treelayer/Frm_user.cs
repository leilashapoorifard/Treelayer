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
using DA;
using BL;

namespace treelayer
{
    public partial class Frm_user : Form
    {
        public Frm_user()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            sabtbelit sabtuser = new sabtbelit();
            dataGridViewX1.DataSource = sabtuser.select();
            dataGridViewX1.Columns[0].HeaderText = "ردیف";
            dataGridViewX1.Columns[1].HeaderText = "نام";
            dataGridViewX1.Columns[2].HeaderText = "نام خانوادگی";
            dataGridViewX1 .Columns[3].HeaderText = "سمت";
            dataGridViewX1.Columns[4].HeaderText = "تلفن ";
            dataGridViewX1.Columns[5].HeaderText = "رمز عبور";
            dataGridViewX1.Columns[6].HeaderText = "نام کاربری";
            sabtuser.password = "*";
           


        }

        private void btnuser_Click(object sender, EventArgs e)
        {
              
            sabtbelit sabtus = new sabtbelit();
      

            sabtus.firstname = txtname.Text;
            sabtus.lastname = txtfamily.Text;
            sabtus.title = txtsemat.Text;
            sabtus.tel = txttel.Text;
            sabtus.username  = txtusernam.Text;
            sabtus.password = txtpass.Text;
            txtid.Text = dataGridViewX1[0, dataGridViewX1.CurrentRow.Index].Value.ToString();
          

            sabtus.ADDuser();

            MessageBox.Show("کاربر جدید با موفقیت ثبت شد.");
           Form1_Load(null, null);
          
        }

        private void btnexi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
 