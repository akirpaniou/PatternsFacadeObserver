using AuthenticationCopm;
using AuthorizationComp;
using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationComp;

namespace AppFacade
{
    public class LoginFacade : ILoginFacade
    {
        private readonly IValidationSer _validationSer;
        private readonly IAuthSer _authenticationSer;
        private readonly IAuthorSer _authorizationSer;
        public LoginFacade()
        {
            _validationSer = new ValidationSer();
            _authenticationSer = new AuthSer();
            _authorizationSer = new AuthorSer();
        }
        public bool CanLogin(string email, string password)
        {
            if(_validationSer.IsValitdated(email, password)
                && _authenticationSer.IsAuthenticated(email, password)
                && _authorizationSer.IsAuthorized(email, password))
            {
                return true;
            }
            return false;
        }
    }
}
