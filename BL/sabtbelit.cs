using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BL;
using DA;

namespace BL
{
    public class sabtbelit : DataAccessLayer
    {
        public int id;      //متغیرهای که در فرم استفاده میشود 
        public string firstname;
        public string lastname;
        public string title;
        public string tel;
        public string password;
        public string username;
        public string city;
        public string ostan;
        public int CustomerID;
        public string q = "";
        public string sql;

      //  public void ADDuser() //      زیر متدهای لایه دیتابیس رو میآور base// از هر کلاسی که مشتق گرفتیم میتوان از بیس استفاده کرد 
      ///  {
      //      base.conct();  // گذاشتن کلمه بیس   باعث میشه از زیر متدهای لایه بالاتر که همان دیتالیر هستش استفاده میشود
      //      string sql = "insert into users( Firstname,Lastname,Title,Tel,pass,username) values(N'{0}',N'{1}',N'{2}','{3}','{4}',N'{5}')";
      //      sql = string.Format(sql, firstname, lastname, title, tel,password,username);
      //      base.docommand(sql);
      //      base.disconnect(); 
     //   }

        public void insercus() // متد اضافه کردن مسافر 
        {
            base.conct();  // گذاشتن کلمه بیس   باعث میشه از زیر متدهای لایه بالاتر که همان دیتالیر هستش استفاده میشود
            string sqlcus = "insert into customer(cuFirstname,cuLastname,ostan,city,tel) values(N'{0}',N'{1}',N'{2}',N'{3}','{4}')";
            sqlcus = string.Format(sqlcus, firstname,lastname,ostan,city,tel );
            base.docommand(sqlcus);
            base.disconnect();
            
        }
       public DataTable select()   // نمایش کاربران 
        {
            base.conct();
             string sql = "select * from users";
             DataTable dt = base.select(sql);
            base.disconnect();
            return dt;
        }
        
        public DataTable vwselect()   //
        {
            base.conct();
            string sql = "select * from vw_bilit";
            DataTable dt = base.select(sql);
            base.disconnect();
            return dt;
        }
        public DataTable select1()
        {
            base.conct();
            string sqlcus = "select * from customer";
            DataTable dt = base.select(sqlcus);
            base.disconnect();
            return dt;
        }
        public  DataTable Login(string password)
        {
            base.conct();
            DataTable dt = new DataTable();
            q = "select * from users where pass='" + password + "'";
            dt = base.select(q);
            base.disconnect();
            return dt;

           
            
        }
        
    }
    }
