using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierPersonelEkleme.BLL.CreationalFactory
{
    public class Muhasebe : Departman
    {
        public override void Departman()
        {
            Console.WriteLine("Muhasebe departmanı hesap kitap işlerine bakar");
        }
    }
}
