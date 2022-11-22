using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectNEST.Admin
{
    public partial class productlogin : System.Web.UI.Page
    {
        BAL.ProdBAL OBJ = new BAL.ProdBAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               GridView1.DataSource = OBJ.ProductView();
                GridView1.DataBind();
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            OBJ.Pname = TextBox1.Text;
            OBJ.Pprice = TextBox2.Text;
            int i = OBJ.InsertProd();
            GridView1.DataSource = OBJ.ProductView();
            GridView1.DataBind();
        }

       

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = OBJ.ProductView();
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int productId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            TextBox productName = (TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0];
            TextBox productPrice = (TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0];



            OBJ.Pid = productId.ToString();

            OBJ.Pname = productName.Text;
            OBJ.Pprice = productPrice.Text;

            int i = OBJ.UpdateProducts();


            GridView1.EditIndex = -1;
            GridView1.DataSource = OBJ.ProductView();
            GridView1.DataBind();

        }

      

        protected void GridView1_RowCancelingEdit1(object sender, GridViewCancelEditEventArgs e)
        {

            GridView1.EditIndex = -1;
            GridView1.DataSource = OBJ.ProductView();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int productId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            OBJ.Pid = productId.ToString();
            int i = OBJ.DeleteProducts();
            GridView1.DataSource = OBJ.ProductView();
            GridView1.DataBind();
        }
    }
}