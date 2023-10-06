using System;
using System.ComponentModel.DataAnnotations;

namespace ZipperMate.Models
{
    public class Zippers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public string Use { get; set; }

        public string Durabilty { get; set; }
        public decimal Price { get; set; }

        public string Colours { get; set; }

        public int Review { get; set; }

    }
}
