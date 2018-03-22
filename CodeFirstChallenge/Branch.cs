namespace CodeFirstChallenge
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tracking.Branch")]
    public partial class Branch
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchID { get; set; }

        [Required]
        [StringLength(50)]
        public string BranchName { get; set; }

        [Required]
        [StringLength(100)]
        public string BranchAddress { get; set; }
    }
}
