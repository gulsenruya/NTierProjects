using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierECommerceProject.DAL.ORM.Entity
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }        
        public string ImagePathProduct { get; set; }
        public int SubCategoryId { get; set; }
        //bir ürünün bir kategorisi olabilir
        public SubCategory SubCategory { get; set; }

    }
}
