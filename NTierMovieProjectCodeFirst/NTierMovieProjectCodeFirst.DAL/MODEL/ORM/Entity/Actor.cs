using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierMovieProjectCodeFirst.DAL.MODEL.ORM.Entity
{
    public class Actor
    {
        [Key]
        public int ActorID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime? BirtDate { get; set; }
        public string ActorImagePath { get; set; }
        public virtual List<MovieActor> MovieActors { get; set; }
    }
}
