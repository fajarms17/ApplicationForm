using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationForm.ViewModel
{
    public class ApplicationViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(15)]
        public string Mobile_phone_number { get; set; }

        [StringLength(15)]
        public string Alternative_phone_number { get; set; }

        [Required]
        [StringLength(40)]
        public string Email { get; set; }

        [Required]
        [StringLength(30)]
        public string Place_of_birth { get; set; }

        public DateTime Date_of_birth { get; set; }
        public long Id_education { get; set; }

        [Required]
        [StringLength(10)]

        public string Last_education { get; set; }

        [Required]
        [StringLength(50)]
        public string College { get; set; }

        [Required]
        [StringLength(40)]
        public string Major { get; set; }

        [Required]
        [StringLength(40)]
        public string Position_apply { get; set; }

        [Required]
        [StringLength(20)]
        public string Source { get; set; }

        [Column("event")]
        [StringLength(50)]
        public string Event { get; set; }

        [StringLength(50)]
        public string Carrer_center { get; set; }

        [StringLength(50)]
        public string Referrer_name { get; set; }

        [StringLength(15)]
        public string Referrer_phone { get; set; }

        [StringLength(40)]
        public string Referrer_email { get; set; }

        public bool Active { get; set; }


    }
}
