using Microsoft.AspNetCore.Identity;

namespace BookInformationApp.API.Data.Domain_Entities
{
    public class BookApiUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
