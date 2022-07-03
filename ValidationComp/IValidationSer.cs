using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationComp
{
    public interface IValidationSer
    {
        bool IsValitdated(string userName, string password);
    }
}
