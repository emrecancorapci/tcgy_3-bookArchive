using System;
using System.Collections.Generic;

namespace tcgy_3_bookArchive.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Info { get; set; }
        public string FullName => Name + " " + LastName;
        public DateTime BirthDate { get; set; }
        public ICollection<BooksAuthors> Books { get; set; }
    }
}
