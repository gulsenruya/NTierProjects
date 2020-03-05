using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierECommerceProject.BLL.Repositories
{

    public interface IRepository<T> where T : class
    {
        void Add(T item);
        void Update(T item);
        void Delete(int id);
        List<T> SelectAll();
        T SelectById(int id);
    }
}
