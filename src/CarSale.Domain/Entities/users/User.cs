using System.Security.Principal;

namespace CarSale.Domain.Entities.users
{
    public class User : Auditable
    {
        public string First_name { get; set; } = String.Empty;

        public string Last_name { get; set; } = String.Empty;

        public string Phone_number { get; set; } = String.Empty;

        public string Password_hash { get; set; } = String.Empty;

        public string Salt { get; set; } = String.Empty;

        public string Role { get; set; } = String.Empty;


    }
}
