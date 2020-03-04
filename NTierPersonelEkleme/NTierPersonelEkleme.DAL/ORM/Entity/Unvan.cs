﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierPersonelEkleme.DAL.ORM.Entity
{
    public class Unvan
    {
        [Key]
        public int UnvanID { get; set; }
        public string UnvanAdi { get; set; }
        public List<Personel> Personels { get; set; }
        public override string ToString()
        {
            return UnvanAdi;
        }
    }
}
