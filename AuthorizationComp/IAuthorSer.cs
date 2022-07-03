using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizationComp
{
    public interface IAuthorSer
    {
        bool IsAuthorized(string userName, string password);
    }
}
