namespace Application.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_applicant
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(15)]
        public string mobile_phone_number { get; set; }

        [StringLength(15)]
        public string alternative_phone_number { get; set; }

        [Required]
        [StringLength(40)]
        public string email { get; set; }

        [Required]
        [StringLength(30)]
        public string place_of_birth { get; set; }

        public DateTime date_of_birth { get; set; }

        [Required]
        [StringLength(10)]
        public string last_education { get; set; }

        [Required]
        [StringLength(50)]
        public string college { get; set; }

        [Required]
        [StringLength(40)]
        public string major { get; set; }

        [Required]
        [StringLength(40)]
        public string position_apply { get; set; }

        [Required]
        [StringLength(20)]
        public string source { get; set; }

        [Column("event")]
        [StringLength(50)]
        public string _event { get; set; }

        [StringLength(50)]
        public string carrer_center { get; set; }

        [StringLength(50)]
        public string referrer_name { get; set; }

        [StringLength(15)]
        public string referrer_phone { get; set; }

        [StringLength(40)]
        public string referrer_email { get; set; }

        public bool is_active { get; set; }
    }
}
