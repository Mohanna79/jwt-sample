using PersonAuthentication.Entities;

namespace PersonAuthentication.Models
{
    public class AuthenticationResponce
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }




        public  AuthenticationResponce(User user,string token)
        {
            Id = user.Id;
            FirstName = user.FirsName;
            LastName = user.LastName;
            Username = user.UserName;
            Token = token;
        }
    }
}
