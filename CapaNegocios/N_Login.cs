using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace CapaNegocios
{
    public class N_Login
    {
        private LoginDAO loginDAO;

        public N_Login(LoginDAO loginDAO)
        {
            this.loginDAO = loginDAO;
        }

        public int Login(string username, string password)
        {
            return loginDAO.Login(username, password);
        }
        
    }
}
