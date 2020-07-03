namespace Application.DataModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<tbl_applicant> tbl_applicant { get; set; }
        public virtual DbSet<tbl_education> tbl_education { get; set; }
        public virtual DbSet<tbl_source_information> tbl_source_information { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_applicant>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_applicant>()
                .Property(e => e.mobile_phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_applicant>()
                .Property(e => e.alternative_phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_applicant>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_applicant>()
                .Property(e => e.place_of_birth)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_applicant>()
                .Property(e => e.last_education)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_applicant>()
                .Property(e => e.college)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_applicant>()
                .Property(e => e.major)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_applicant>()
                .Property(e => e.position_apply)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_applicant>()
                .Property(e => e.source)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_applicant>()
                .Property(e => e._event)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_applicant>()
                .Property(e => e.carrer_center)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_applicant>()
                .Property(e => e.referrer_name)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_applicant>()
                .Property(e => e.referrer_phone)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_applicant>()
                .Property(e => e.referrer_email)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_education>()
                .Property(e => e.last_education)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_source_information>()
                .Property(e => e.source)
                .IsUnicode(false);
        }
    }
}
