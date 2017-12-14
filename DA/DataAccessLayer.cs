using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DA;
 

namespace DA
{
   public  class DataAccessLayer
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter dap;
        DataTable dt;
        public DataAccessLayer ()
        {
            con= new SqlConnection(); ;
            cmd= new SqlCommand();
            dap = new SqlDataAdapter();
            dt = new DataTable();
            cmd.Connection = con;
            dap.SelectCommand = cmd;

        }

        public void conct()    // وصل شدن به دیتابیس
        {
            con.ConnectionString = "Data Source=.;Initial Catalog=sabtbelit;Integrated Security=True";
            con.Open();
        }
        public void disconnect() // بستن دیتابیس
        {
            con.Close();
        }
        public DataTable select (string sql) // نمایش اطلاعات  کاربران ثبت شده در دیتاگرید
        {
            cmd.CommandText = sql;
           DataTable  dt = new DataTable();
            dap.Fill(dt);
            return dt;
       }
        public void docommand(string sql)  // انجام عملیاتهای چون حذف ، اضافه ,انتخاب و آپ دیت ، 
        {
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

  

    }
}
