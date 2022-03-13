using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcgy_3_bookArchive.Entities
{
    internal class Publisher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }  
        public ICollection<BooksPublishers> Books { get; set; }

    }
}
