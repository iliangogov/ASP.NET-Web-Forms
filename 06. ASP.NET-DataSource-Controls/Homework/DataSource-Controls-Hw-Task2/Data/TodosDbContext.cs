namespace Todos.Data
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using Countries.Data.Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class TodosDbContext : DbContext
    {
        public TodosDbContext()
            : base("Todos")
        {
        }

        public virtual IDbSet<Category> Categories { get; set; }

        public virtual IDbSet<Todo> Todos { get; set; }

        public static TodosDbContext Create()
        {
            return new TodosDbContext();
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