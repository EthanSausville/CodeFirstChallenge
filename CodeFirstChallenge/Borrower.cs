namespace CodeFirstChallenge
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tracking.Borrowers")]
    public partial class Borrower
    {
        [Key]
        [StringLength(30)]
        public string CardNo { get; set; }

        [Required]
        [StringLength(50)]
        public string BorrowerName { get; set; }

        [Required]
        [StringLength(100)]
        public string BorrowerAddress { get; set; }

        [Required]
        [StringLength(25)]
        public string BorrowerPhone { get; set; }
    }
}
