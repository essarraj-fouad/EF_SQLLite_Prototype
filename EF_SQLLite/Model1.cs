namespace EF_SQLLite
{
    using App.Entities;
    using Microsoft.Data.Sqlite;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;

    public class Model1 : DbContext
    {
        // Votre contexte a été configuré pour utiliser une chaîne de connexion « Model1 » du fichier 
        // de configuration de votre application (App.config ou Web.config). Par défaut, cette chaîne de connexion cible 
        // la base de données « EF_SQLLite.Model1 » sur votre instance LocalDb. 
        // 
        // Pour cibler une autre base de données et/ou un autre fournisseur de base de données, modifiez 
        // la chaîne de connexion « Model1 » dans le fichier de configuration de l'application.
        public Model1()
        {
        }

        // Ajoutez un DbSet pour chaque type d'entité à inclure dans votre modèle. Pour plus d'informations 
        // sur la configuration et l'utilisation du modèle Code First, consultez http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Trainee> Trainees { get; set; }
        public virtual DbSet<Group> Groups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "test.db" };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);

            optionsBuilder.UseSqlite(connection);
        }
    }

 

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}