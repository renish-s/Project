using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectNEST.Admin
{
    public partial class Admstudentdetails : System.Web.UI.Page
    {
        BAL.RegBALcs reg = new BAL.RegBALcs();
        BAL.loginBAL loginBal = new BAL.loginBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = reg.viewRegisteration();
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int userId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            loginBal.Loginid = userId.ToString();
            int i = loginBal.UserConfirmation();
            if (i == 1)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + "Confirmed Successfully" + "');", true);

            }
            GridView1.DataSource = reg.viewRegisteration();
            GridView1.DataBind();

        }
    }
}
