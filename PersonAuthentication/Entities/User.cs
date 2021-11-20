using System.Text.Json.Serialization;
namespace PersonAuthentication.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
    }
}
