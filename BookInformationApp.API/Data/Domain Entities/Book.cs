namespace BookInformationApp.API.Domain_Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public string AuthorName { get; set; }
        public int Pages { get; set; }
        public DateTime PublishedDate { get; set; }

    }
}
