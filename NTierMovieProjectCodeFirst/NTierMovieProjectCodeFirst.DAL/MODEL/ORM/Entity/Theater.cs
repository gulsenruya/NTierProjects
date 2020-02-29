using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierMovieProjectCodeFirst.DAL.MODEL.ORM.Entity
{
   public class Theater
    {
        [Key]
        public int ID { get; set; }
        public int MovieId { get; set; }
        public int SessionId { get; set; }
        public int SaloonId { get; set; }
        public int WeekId { get; set; }
        public Movie Movie { get; set; }
        public Session Session { get; set; }
        public Saloon Saloon { get; set; }
        public Week Week { get; set; }

        //public virtual List<Session> Sessions { get; set; }
        //public virtual List<Saloon> Saloons { get; set; }
        //public virtual List<Movie> Movies { get; set; }
        //public virtual List<Week> Weeks { get; set; }
    }
}
