using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjectNEST.LoginDAL
{
    public class DAL
    {
        
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();


        public DAL()
        {
            string conn = ConfigurationManager.ConnectionStrings["rose"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }
        public SqlConnection GetCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public DataTable logincheck(BAL.loginBAL objr)
        {
            string qry = "SELECT * FROM login WHERE username='" + objr.Username + "' AND pwd='" + objr.Loginpwd + "'";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int UserConfirm(BAL.loginBAL loginbal)
        {
            string qry = "update login set status = 'confirmed' where loginid='" + loginbal.Loginid + "'";
            SqlCommand cmd = new SqlCommand(qry, GetCon());
            int i = cmd.ExecuteNonQuery();
            return i;
        }

    }
}