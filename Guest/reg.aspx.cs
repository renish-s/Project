using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectNEST.User
{

    public partial class WebForm2 : System.Web.UI.Page
    {
        BAL.RegBALcs reg2 = new BAL.RegBALcs();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            reg2.Regname = TextBox2.Text;
            reg2.Regemail = TextBox3.Text;
            reg2.Regphone = TextBox4.Text;
            reg2.Reglogin= TextBox1.Text;

            int j = reg2.InsertLogin();
           
            int i = reg2.InsertUser();
            
            if(i==1)
            {
                Response.Write(" Great !Successfuly added ");
            }
        }
    }
}
