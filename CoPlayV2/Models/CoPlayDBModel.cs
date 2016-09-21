using System.Data.Entity.Validation;

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
        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors
                        .SelectMany(x => x.ValidationErrors)
                        .Select(x => x.ErrorMessage);

                var fullErrorMessage = string.Join("; ", errorMessages);

                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
        }


        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Rate> Rates { get; set; }
        public virtual DbSet<SportandRec> SportandRecs { get; set; }
        public virtual DbSet<UserSportPerformance> UserSportPerformances { get; set; }
        public virtual DbSet<InternalMessage> InternalMessages { get; set; }
        public virtual DbSet<ClubModel> ClubModels { get; set; }

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
