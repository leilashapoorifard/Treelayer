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
    public partial class Frm_ticket : Form
    {
        public Frm_ticket()
        {
            InitializeComponent();
        }

        private void Frm_ticket_Load(object sender, EventArgs e)
        {

            sabtbelit sabtuser = new sabtbelit();
           dgvbilit.DataSource = sabtuser.vwselect ();


           // Frm_Login userlog = new treelayer.Frm_Login();
           // txtkarbar.Text = PublicVaribal.gusername; 

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtlasmo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsabtblit_Click(object sender, EventArgs e)
        {

        }
    }
}
