using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public interface LoginDAO
    {
        int Login(string username, string password);
        
    }
}
