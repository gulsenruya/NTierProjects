using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierMovieProjectCodeFirst.DAL.MODEL.ORM.Entity
{
    public class MovieCategory
    {
        //sql tarafında oluşturmasında, kendimiz tanımlayıp doğrudan müdahale edebilelim.
        public int MovieId { get; set; }
        public int CategoryId { get; set; }
        //composit key
        public virtual Movie Movie { get; set; }
        public virtual Category Category { get; set; }
        
    }
}
