using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBaseService<TDTO , TEntity>
    {
        IEnumerable<TDTO> GetAll();
        TDTO Get(int id);
        void Create(TDTO dto);
        void Update(int id , TDTO dto);
        void Delete(int id);

    }
}
