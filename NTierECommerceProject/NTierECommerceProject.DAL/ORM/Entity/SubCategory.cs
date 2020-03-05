using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierECommerceProject.DAL.ORM.Entity
{
    public class SubCategory
    {
        public int SubCategoryID { get; set; }
        public string SubCategoryName { get; set; }
        public string Description { get; set; }
        public List<CategorySubCategory> CategorySubCategories { get; set; }
        //bir sub kategoride birden fazla ürün olabilir
        public List<Product> Products { get; set; }
    }
}
