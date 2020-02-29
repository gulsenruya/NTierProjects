using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierMovieProjectCodeFirst.DAL.MODEL.ORM.Entity
{
    public class Week
    {
        [Key]
        public int WeekID { get; set; }
        public string WeekName { get; set; }
        public string WeekFirstDay { get; set; }
        public string WeekLastDay { get; set; }
       
    }
}
