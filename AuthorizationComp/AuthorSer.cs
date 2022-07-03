using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizationComp
{
    public class AuthorSer : IAuthorSer
    {
        public bool IsAuthorized(string userName, string password)
        {
            return true;
        }
    }
}
