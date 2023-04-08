using Microsoft.Build.Framework;

namespace BookInformationApp.API.DTOs
{
    public class BookDto : BookCreateDto
    {
        [Required]
        public int Id { get; set; }
        
    }
}
