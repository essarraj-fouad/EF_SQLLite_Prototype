namespace EF_SQLLite
{
    using App.Entities;
    using Microsoft.Data.Sqlite;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;

    public class MyDbContext : DbContext
    {
        #region DbSet
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Group> Groups { get; set; }
       
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
 
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var sqliteConn = new SqliteConnection(@"DataSource = traineeManager.db");
            optionsBuilder.UseSqlite(sqliteConn);
        }
    }
}