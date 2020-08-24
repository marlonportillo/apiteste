using api_prueba.DAL;
using api_prueba.DAO.Interfaces.ADM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_prueba.DAO.Implements.ADM
{
    public class EstadosImplements : EstadosDAO
    {
        private readonly ApplicationDBContext context;
        public EstadosImplements(ApplicationDBContext context)
        {
            this.context = context;
        }
        public void create(Estados entity)
        {
            throw new NotImplementedException();
        }

        public void delete(Estados entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Estados> getAll()
        {
            throw new NotImplementedException();
        }

        public Estados getById(long Id)
        {
            throw new NotImplementedException();
        }

        public void update(Estados DBEntity, Estados entity)
        {
            throw new NotImplementedException();
        }
    }
}
