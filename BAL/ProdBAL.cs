using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjectNEST.BAL
{
    public class ProdBAL
    {
        DAL.ProdDAL reg4 = new DAL.ProdDAL();
        private string pid;
        private string pname;
        private string pprice;
        public string Pid
        {
            get
            {
                return pid;
            }
            set
            {
                pid = value;
            }
        }
        public string Pname
        {
            get
            {
                return pname;
            }
            set
            {
                pname = value;
            }
        }
        public string Pprice
        {
            get
            {
                return pprice;
            }
            set
            {
                pprice = value;
            }
        }
        public int InsertProd()
        {
            return reg4.ProdInsert(this);
        }
        public DataTable ProductView()
        {
            return reg4.ViewProduct();
        }
        public int UpdateProducts()
        {
            return reg4.UpdateProductDetails(this);
        }
        public int DeleteProducts()
        {
            return reg4.DeleteProductDetail(this);
        }

    }
}