using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierECommerceProject.DAL.ORM.Entity
{
    public class AppUser
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ImagePathUrl { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        [Compare("Password")]
        [Required(ErrorMessage = "Confirm Password is required")]
        public string ConfirmPassword { get; set; }
        public DateTime? BirthDate { get; set; }
        //kullanıcının birden fazla siparisi olabilir
        public List<Order> Orders { get; set; }

    }
}
