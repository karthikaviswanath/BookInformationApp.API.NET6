using System.ComponentModel.DataAnnotations;

namespace BookInformationApp.API.DTOs
{
    public class BookCreateDto
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Language { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string AuthorName { get; set; }
        [Required]
        public int Pages { get; set; }
        [Required]
        public DateTime PublishedDate { get; set; }
    }
}
