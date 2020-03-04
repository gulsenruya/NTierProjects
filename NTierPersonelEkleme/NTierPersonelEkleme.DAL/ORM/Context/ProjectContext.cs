using NTierPersonelEkleme.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierPersonelEkleme.DAL.ORM.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "server=.;database=NTierPersonelCF;uid=sa;pwd=123";
        }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Departman> Departmen { get; set; }
        public DbSet<Unvan> Unvans { get; set; }

    }
}
