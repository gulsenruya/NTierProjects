using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierPersonelEkleme.BLL.CreationalFactory
{
    public class IT : DepartmanCreator
    {
        public override void Departman()
        {
            Console.WriteLine("IT departmanı şirketin yazılım işlerini yapar");
        }
    }
}
