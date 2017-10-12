namespace PromoPage.Models.PromoDb
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PromoDb : DbContext
    {
        public PromoDb()
            : base("name=PromoDb")
        {
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Participant> Participants { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Seminar> Seminars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
