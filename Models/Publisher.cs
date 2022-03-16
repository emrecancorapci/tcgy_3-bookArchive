using System.Collections.Generic;

namespace tcgy_3_bookArchive.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }  
        public ICollection<BooksPublishers> Books { get; set; }

    }
}
