namespace CodeFirstChallenge
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tracking.Loans")]
    public partial class Loan
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string CardNo { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "date")]
        public DateTime DateOut { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "date")]
        public DateTime DateDue { get; set; }
    }
}
