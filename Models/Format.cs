using System.Collections.Generic;

namespace tcgy_3_bookArchive.Models
{
    public class Format
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}