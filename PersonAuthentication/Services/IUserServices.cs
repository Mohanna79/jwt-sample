using PersonAuthentication.Entities;
using PersonAuthentication.Models;
using System.Collections.Generic;


namespace PersonAuthentication.Services
{
    public interface IUserServices
    {
        AuthenticationResponce Authenticate(AuthenticationRequests model);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
