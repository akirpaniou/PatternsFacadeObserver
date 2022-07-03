using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationCopm
{
    public class AuthSer : IAuthSer
    {
        public bool IsAuthenticated(string userName, string password)
        {
            return true;
        }
    }
}
