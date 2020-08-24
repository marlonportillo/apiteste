using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_prueba.DAO.Interfaces
{
    public interface CRUD<TEntity>
    {
        IEnumerable<TEntity> getAll();
        TEntity getById(long Id);
        void update(TEntity DBEntity, TEntity entity);
        void delete(TEntity entity);
        void create(TEntity entity);
    }
}
