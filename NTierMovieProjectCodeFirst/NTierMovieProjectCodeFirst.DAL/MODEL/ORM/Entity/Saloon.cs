using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierMovieProjectCodeFirst.DAL.MODEL.ORM.Entity
{
    public class Saloon
    {
        [Key]
        public int SaloonID { get; set; }
        public string Saloons { get; set; }
        public int Capacity { get; set; }
       

    }
}
