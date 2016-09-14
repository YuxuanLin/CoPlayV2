namespace CoPlayV2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CoPlayDBModel : DbContext
    {
        public CoPlayDBModel()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Rate> Rates { get; set; }
        public virtual DbSet<SportandRec> SportandRecs { get; set; }
        public virtual DbSet<UserSportPerformance> UserSportPerformances { get; set; }
        public virtual DbSet<InternalMessage> InternalMessages { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
                .Property(e => e.StartTime)
                .IsUnicode(false);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.Rates)
                .WithRequired(e => e.Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rate>()
                .Property(e => e.Level)
                .IsFixedLength();

            modelBuilder.Entity<UserSportPerformance>()
                .Property(e => e.Level)
                .IsFixedLength();
        }
    }
}
