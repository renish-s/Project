using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjectNEST.BAL
{
    public class RegBALcs
    {
        DAL.RegDAL reg1 = new DAL.RegDAL();
        private string regid;
        private string regname;
        private string regemail;
        private string regphone;
        
        private string reglogin;







        public string Regid
        {
            get
            {
                return regid;
            }
            set
            {
                regid = value;
            }
        }
        public string Regname
        {
            get
            {
                return regname;
            }
            set
            {
                regname = value;
            }
        }
        public string Regemail
        {
            get
            {
                return regemail;
            }
            set
            {
                regemail = value;
            }
        }
        public string Regphone
        {
            get
            {
                return regphone;
            }
            set
            {
                regphone = value;
            }
        }
        
        
        public string Reglogin
        {
            get
            {
                return reglogin;
            }
            set
            {
                reglogin = value;
            }
        }


        public int InsertUser()
        {
            return reg1.UserInsert(this);
        }
        public int InsertLogin()
        {
            return reg1.LoginInsert(this);
        }
        public DataTable viewRegisteration()
        {
            return reg1.registerationView();
        }

    }

}
