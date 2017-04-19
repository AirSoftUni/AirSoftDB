namespace AirSoft.Data
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AirSoftContext : DbContext
    {
        
        public AirSoftContext()
            : base("name=AirSoftContext")
        {
             Database.SetInitializer(new AirSoftDbInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>()
                .HasRequired(g => g.CreatorsTeam)
                .WithMany(t => t.CreatedGames)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Game>()
            .HasMany(g => g.ParticipatingPlayers)
            .WithMany(p => p.Games)
            .Map(pg =>
            {
                pg.MapLeftKey("GameId");
                pg.MapRightKey("PlayerId");
                pg.ToTable("GamePlayers");
            });

           
                
        }

        public virtual DbSet<Player> Players { get; set; }
         public virtual DbSet<Game> Games { get; set; }
         public virtual DbSet<Team> Teams { get; set; }
    }

    
}