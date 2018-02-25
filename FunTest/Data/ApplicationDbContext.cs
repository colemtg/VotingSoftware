using Microsoft.EntityFrameworkCore;

namespace VotingSoftware
{
    //Database representational model
    public class ApplicationDbContext : DbContext
    {
        #region Public Properties
        /// <summary>
        /// settings for the application
        /// </summary>
        public DbSet<SettingsDataModel> Setting { get; set; }

        public ApplicationDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=.;Database=entityframework;Trusted_Connection=True;MultipleActiveResultSet");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        #endregion
    }
}
