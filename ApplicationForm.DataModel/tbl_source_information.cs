namespace ApplicationForm.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_source_information
    {
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string source { get; set; }
    }
}
