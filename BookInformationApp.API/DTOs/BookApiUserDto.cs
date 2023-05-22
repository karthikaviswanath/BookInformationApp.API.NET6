using System.ComponentModel.DataAnnotations;

namespace BookInformationApp.API.DTOs
{
    public class BookApiUserDto : LoginDto
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}
