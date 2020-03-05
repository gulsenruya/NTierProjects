using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierECommerceProject.DAL.ORM.Entity
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }        
        public bool Confirmed { get; set; }
        public int AppUserId { get; set; }
        //siparis bir kullanıcıya ait olur
        public AppUser AppUser { get; set; }
        
    }
}
