﻿namespace tcgy_3_bookArchive.Entities
{
    internal class BooksPublishers
    {
        public int BookID { get; set; }
        public Book Book { get; set; }
        public int PublisherID { get; set; }
        public Publisher Publisher { get; set; }
    }
}