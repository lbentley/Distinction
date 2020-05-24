using System;
using System.ComponentModel.DataAnnotations;

namespace Distinction.Models
{
    public class Review
    {
        public int ID { get; set; }
        public int BookID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [Range(1,5)]
        public int Score { get; set; }
        public string Comments { get; set; }
        public Book Book { get; set; }
    }
}
