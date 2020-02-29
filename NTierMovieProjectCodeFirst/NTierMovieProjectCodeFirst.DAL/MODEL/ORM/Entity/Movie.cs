using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierMovieProjectCodeFirst.DAL.MODEL.ORM.Entity
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        [MaxLength(50)]
        public string MovieName { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        public string MovieLanguage { get; set; }
        public DateTime? ReleaseDate { get; set; }
        //public string MoviePosterPath { get; set; }
        public int? Duration { get; set; }
        //public int TheaterId { get; set; }
        //public virtual List<Category> Categories { get; set; }
        //Mapping
        //bir filmin birden fazla kategorisi olur.
        public virtual List<MovieCategory>  MovieCategories { get; set; }
        //bir filmin birden fazla oyuncusu olur.
        public virtual List<MovieActor> MovieActors { get; set; }
        public virtual List<Theater> Theaters { get; set; }
    }
}
