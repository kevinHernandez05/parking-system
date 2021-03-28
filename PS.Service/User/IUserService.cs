using PS.Model.Entities;
using PS.Model.Entities.JWT;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Service
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        IEnumerable<User> GetAll();
        User GetUserById(int id);

    }
}
