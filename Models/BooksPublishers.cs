namespace tcgy_3_bookArchive.Models
{
    public class BooksPublishers
    {
        public int BookID { get; set; }
        public Book Book { get; set; }
        public int PublisherID { get; set; }
        public Publisher Publisher { get; set; }
    }
}