namespace CodeFirstChallenge
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Books.Books")]
    public partial class Book
    {
        public int BookID { get; set; }

        [Required]
        [StringLength(50)]
        public string BookTitle { get; set; }

        [Required]
        [StringLength(50)]
        public string BookPublisher { get; set; }
    }
}
