using System;
using System.Collections.Generic;


namespace tcgy_3_bookArchive.Entities
{
    internal class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<BooksAuthors> Authors { get; set; }
        public ICollection<BooksPublishers> Publishers { get; set; }
        public DateTime PublishDate { get; set; }
        public long ISBN { get; set; }
        public Language Language { get; set; }
        public int? LanguageID { get; set; }
        public Format Format { get; set; }
        public int? FormatID { get; set; }
        public int Pages { get; set; }
        public string Edition { get; set; }
        public string Condition { get; set; }
        public string Summary { get; set; }
        public float Rating { get; set; }
    }
}
