using System.ComponentModel.DataAnnotations;

namespace PersonAuthentication.Models
{
    public class AuthenticationRequests
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
