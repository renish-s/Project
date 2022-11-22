using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjectNEST.BAL
{
    public class loginBAL
    {
        internal string password;
        LoginDAL.DAL reg3 = new LoginDAL.DAL();
        private string loginid;
        private string username;
        private string loginpwd;
        private string loginrole;
        private string loginstatus;






        public string Loginid
        {
            get
            {
                return loginid;
            }
            set
            {
                loginid = value;
            }
        }
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public string Loginpwd
        {
            get
            {
                return loginpwd;
            }
            set
            {
                loginpwd = value;
            }

        }
        public string Loginrole
        {
            get
            {
                return loginrole;
            }
            set
            {
                loginrole = value;
            }
        }
        public string Loginstatus
        {
            get
            {
                return loginstatus;
            }
            set
            {
                loginstatus = value;
            }
             
        }
        public DataTable checklogin()
        {
            return reg3.logincheck(this);
        }
        public int UserConfirmation()
        {
            return reg3.UserConfirm(this);
        }
    }
}