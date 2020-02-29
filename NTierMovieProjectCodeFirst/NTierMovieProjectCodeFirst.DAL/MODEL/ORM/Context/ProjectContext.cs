using NTierMovieProjectCodeFirst.DAL.MODEL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierMovieProjectCodeFirst.DAL.MODEL.ORM.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "server=.;database=NTierMovieProjectCodeFirst;uid=sa;pwd=123";
        }
        //Many Tables
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Actor> Actors { get; set; }
        //Many To Many
        public DbSet<MovieCategory>  MovieCategories { get; set; }
        public DbSet<MovieActor>  MovieActors { get; set; }

        public DbSet<Theater> Theaters { get; set; }
        public DbSet<Saloon> Saloons { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Week> Weeks { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieCategory>().HasKey(x => new
            {
                x.MovieId,
                x.CategoryId
            });

            modelBuilder.Entity<MovieActor>().HasKey(x => new
            {
                x.MovieId,
                x.ActorId
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
