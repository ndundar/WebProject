using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Faces
{
    public interface IBusinessHelper<TEntity> where TEntity: class
    {
        void Add(TEntity entity);
        TEntity GetById(int id);
        List<TEntity> GetAll();
        void Update(TEntity entity);
        void Delete(TEntity entity);

    }
}
