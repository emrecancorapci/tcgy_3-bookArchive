namespace tcgy_3_bookArchive.Models
{
    public class BooksAuthors
    {
        public int BookID { get; set; }
        public Book Book { get; set; }
        public int AuthorID { get; set; }
        public Author Author { get; set; }
        public int Order { get; set; }
    }
}
