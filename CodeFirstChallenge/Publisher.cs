namespace CodeFirstChallenge
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Books.Publisher")]
    public partial class Publisher
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string BookPublisher { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string PublisherAddress { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(25)]
        public string PublisherPhone { get; set; }
    }
}
