using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierECommerceProject.DAL.ORM.Entity
{
    public class CategorySubCategory
    {
        [Key]
        public int ID { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public Category Category { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}
