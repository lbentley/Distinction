using System.Collections.Generic;

namespace Distinction.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Authors { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
