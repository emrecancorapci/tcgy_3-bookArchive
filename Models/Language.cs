using System.Collections.Generic;

namespace tcgy_3_bookArchive.Entities
{
    internal class Language
    {
        public int ID { get; set; }
        public string Name { get; set; } 
        public string ShortName { get; set; }
        public List<Book> Books { get; set; }
    }
}