using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ProjectNEST.DAL
{
    public class ProdDAL
    {

       public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public ProdDAL()
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
        public int ProdInsert(BAL.ProdBAL obj)
        {
            string s = "insert into prreg values('" + obj.Pname + "','" + obj.Pprice + "')";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable ViewProduct()
        {
            string qry = "Select * from prreg";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int UpdateProductDetails(BAL.ProdBAL products_BAL)
        {
            string qry = "update prreg set pname = '" + products_BAL.Pname + "',pprice = '" + products_BAL.Pprice + "' where pid = '" + products_BAL.Pid + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public int DeleteProductDetail(BAL.ProdBAL products_BAL)
        {
            string qry = "delete from prreg where pid ='" + products_BAL.Pid + "' ";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }
    }
}