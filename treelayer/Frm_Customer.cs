using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using DA;
using BL;

namespace treelayer
{
    public partial class Frm_Customer : Form
    {
        public Frm_Customer()
        {
            InitializeComponent();
        }

        private void btnsabtmosafer_Click(object sender, EventArgs e)
        {
            sabtbelit sabtcustomer = new sabtbelit();
            if(txtcity.Text.Trim() =="" || txtlastmosa.Text.Trim() =="" || txtnamemosa.Text.Trim() =="" || txtostan.Text.Trim() ==""  || txttelmosa.Text.Trim() == "")
            {
                MessageBox.Show("لطفا کادرهای موردنظر را پر کنید");
                return;
            }
           // sabtcustomer.id = Convert.ToInt32(txtid.Text);
            sabtcustomer.firstname = txtnamemosa.Text;
            sabtcustomer.lastname = txtlastmosa.Text;
            sabtcustomer.ostan = txtostan.Text;
            sabtcustomer.city = txtcity.Text;
            sabtcustomer.tel = txttelmosa.Text;
            txtid.Text = dgvcus[0, dgvcus.CurrentRow.Index].Value.ToString();
            PublicVaribal.gcustomid = Convert.ToInt32(txtid.Text);
            sabtcustomer.insercus();


            MessageBox.Show("مسافر جدید با موفقیت ثبت شد.");
            Frm_Customer_Load(null, null);
             

        }

        private void Frm_Customer_Load(object sender, EventArgs e)
        {
            sabtbelit sabtcus = new sabtbelit();
            dgvcus.DataSource = sabtcus.select1( );
            dgvcus.Columns[0].HeaderText = "ردیف";
            dgvcus.Columns[1].HeaderText = "نام";
            dgvcus.Columns[2].HeaderText = "نام خانوادگی";
            dgvcus.Columns[3].HeaderText = "استان";
            dgvcus.Columns[4].HeaderText = "شهر";
            dgvcus.Columns[5].HeaderText = "تلفن";
           // dgvcus.Columns[6].HeaderText = "";
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if(dgvcus[0, dgvcus.CurrentRow.Index].Value.ToString() != null )
            { 
            string ticketcell = dgvcus[0, dgvcus.CurrentRow.Index].Value.ToString();
            int g = Convert.ToInt32(ticketcell);
            sabtbelit tickt = new sabtbelit();
            tickt.id = Convert.ToInt32(ticketcell);

            DataTable dt = tickt.vwselect ();
            Frm_ticket tick = new Frm_ticket();
            Frm_Login userlog = new treelayer.Frm_Login();
            

            for (int i = 0; i <= g; i++)
            {
                tick.txtmo.Text = dgvcus.CurrentRow.Cells[1].Value.ToString();
                tick.txtlasmo.Text = dgvcus.CurrentRow.Cells[2].Value.ToString();
                tick.txtkarbar.Text = userlog.txt_username.Text;
            }
            
            tick.Show();
            }
            else
            {
                MessageBox.Show("برای ثبت بلیط ابتدا یک ردیف را انتخاب کنید ");
            }
        }

        private void dgvcus_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvcus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
