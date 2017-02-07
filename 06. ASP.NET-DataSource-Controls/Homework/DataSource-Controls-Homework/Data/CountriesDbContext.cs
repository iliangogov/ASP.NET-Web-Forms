namespace Countries.Data
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    using Microsoft.AspNet.Identity.EntityFramework;

    using Countries.Data.Models;

    public class CountriesDbContext : IdentityDbContext<User>
    {
        public CountriesDbContext()
            : base("Countries", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Town> Towns { get; set; }

        public virtual IDbSet<Country> Countries { get; set; }

        public virtual IDbSet<Continent> Continents { get; set; }

        public static CountriesDbContext Create()
        {
            return new CountriesDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>()
            //            .HasMany(u => u.Events)
            //            .WithMany(e => e.Participants)
            //            .Map(m =>
            //            {
            //                m.MapRightKey("EventId");
            //                m.MapLeftKey("ParticipantId");
            //                m.ToTable("EventsParticipants");
            //            });

            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();


            //modelBuilder.Entity<User>().HasMany(c => c.Events).WithRequired(x => x.Creator).WillCascadeOnDelete(false);

            //modelBuilder.Entity<Route>().HasRequired(c => c.StartPoint).WithMany().WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}