using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Entity
{
    public class BookCatalogue
    {
        [Key]
        [MaxLength(13)]
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Authors { get; set; }
        public DateTime PublicationDate { get; set; }

    }
}
