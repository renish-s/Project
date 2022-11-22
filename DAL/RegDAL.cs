using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjectNEST.DAL
{
    public class RegDAL
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public RegDAL()
        {
            string conn = ConfigurationManager.ConnectionStrings["rose"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }
        public SqlConnection Getcon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public int LoginInsert(BAL.RegBALcs obj)
        {
            string s = "insert into login values('" + obj.Regname + "','" + obj.Regpwd + "','user','not confirmed')select @@IDENTITY";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public int UserInsert(BAL.RegBALcs obj)
        {
            string qry = "insert into userreg values('" + obj.Regname + "','" + obj.Regemail + "','" + obj.Regphone + "','" + obj.Regpwd + "')";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable registerationView()
        {
            string qry = "select r.*,.* from userreg r inner join login l on r.userid = l.loginid where l.role='user' and status='not confirmed'";
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }


    }
}