using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierPersonelEkleme.DAL.ORM.Entity
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }
        public string PersonelAdi { get; set; }
        public string PersonelSoyadi { get; set; }
        public string TelefonNo { get; set; }
        public string Email { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public DateTime? İseGirisTarihi { get; set; }
      
        public string Adres { get; set; }
        
        public int TCKN { get; set; }
        public string FotografUrl { get; set; }
        public int DepartmanId { get; set; }
        public int UnvanId { get; set; }
        public virtual Departman Departman { get; set; }
        public virtual Unvan Unvan { get; set; }
    }
}
