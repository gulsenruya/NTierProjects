using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierMovieProjectCodeFirst.DAL.MODEL.ORM.Entity
{
    public class Session
    {
        [Key]
        public int SessionID { get; set; }
        public string Sessions { get; set; }
       
    }
}
