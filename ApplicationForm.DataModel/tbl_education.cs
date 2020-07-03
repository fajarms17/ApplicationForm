namespace ApplicationForm.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_education
    {
        public int id { get; set; }

        [Required]
        [StringLength(10)]
        public string last_education { get; set; }
    }
}
