using System;
using System.Collections.Generic;

namespace tcgy_3_bookArchive.Models
{
    internal class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime SignupDate { get; set; }
        public List<Book> ReadBooks { get; set; }
    }
}
