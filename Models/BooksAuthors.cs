using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcgy_3_bookArchive.Entities
{
    internal class BooksAuthors
    {
        public int BookID { get; set; }
        public Book Book { get; set; }
        public int AuthorID { get; set; }
        public Author Author { get; set; }
        public int Order { get; set; }
    }
}
