using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NTierMovieProjectCodeFirst.DAL.MODEL.ORM.Entity
{
    public class Category
    {
        
        [Key]
        public int CategoryID { get; set; }
        [MaxLength(50)]
        public string CategoryName { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
      
        public virtual List<MovieCategory> MovieCategories { get; set; }


    }
}
