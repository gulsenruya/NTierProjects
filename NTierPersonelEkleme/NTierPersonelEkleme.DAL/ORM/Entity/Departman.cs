using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierPersonelEkleme.DAL.ORM.Entity
{
    public class Departman
    {
        [Key]
        public int DepartmanID { get; set; }
        public string DepartmanAdı { get; set; }

        public List<Personel> personels;
    }
}
