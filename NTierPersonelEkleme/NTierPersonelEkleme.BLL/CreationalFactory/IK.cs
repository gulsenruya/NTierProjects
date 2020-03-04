using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierPersonelEkleme.BLL.CreationalFactory
{
    public class IK : Departman
    {
        public override void Departman()
        {
            Console.WriteLine("ik departmanı personel alımı yapar");
        }
    }
}
