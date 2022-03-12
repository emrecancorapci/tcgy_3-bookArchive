using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcgy_3_bookArchive.Entities
{
    internal class Author
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
