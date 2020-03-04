using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierPersonelEkleme.BLL.CreationalFactory
{
    public class Creator
    {
        public Departman FactoryMethod(AllDepartmants allDepartmants)
        {
            Departman departman = null;
            switch (allDepartmants)
            {
                case AllDepartmants.Muhasebe:
                    departman = new Muhasebe();
                    break;
                case AllDepartmants.IK:
                    departman = new IK();
                    break;
                case AllDepartmants.IT:
                    departman = new IT();
                    break;
                case AllDepartmants.Yönetim:
                    departman = new Yonetim();
                    break;
                default:
                    break;
            }
            return departman;
        }
    }
}
