using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierPersonelEkleme.BLL.CreationalFactory
{
    public class Yonetim : Departman
    {
        public override void Departman()
        {
            Console.WriteLine("yönetim departmanı şirketi denetler");
        }
    }
}
