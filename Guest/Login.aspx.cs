using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectNEST.Guest
{
    public partial class Login : System.Web.UI.Page
    {
        BAL.loginBAL REG2 = new BAL.loginBAL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text;
            string password = TextBox2.Text;
            DataTable dt = REG2.checklogin();
            if (dt.Rows.Count > 0)
            {
                if (username == "Admin" && password == "Admin")
                {
                    Response.Redirect("../Admin/homepage.aspx");
                }
                else if (dt.Rows[0][2].ToString() == "user" && dt.Rows[0][4].ToString() == "confirmed")
                {

                    Response.Redirect("../User/userhome.aspx");
                }
                else if (dt.Rows[0][2].ToString() == "user" && dt.Rows[0][4].ToString() != "confirmed")
                {

                    Response.Redirect("../User/userhome.aspx");
                }
            }
        }
    }
}


       