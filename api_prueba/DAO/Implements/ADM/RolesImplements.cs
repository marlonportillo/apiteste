using api_prueba.DAL;
using api_prueba.DAO.Interfaces;
using api_prueba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_prueba.DAO.Implements
{
    public class RolesImplements : RolesDAO
    {
        private readonly ApplicationDBContext context;
        public RolesImplements(ApplicationDBContext context)
        {
            this.context = context;
        }
        public void create(Roles entity)
        {
            throw new NotImplementedException();
        }

        public void delete(Roles entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Roles> getAll()
        {
            throw new NotImplementedException();
        }

        public Roles getById(long Id)
        {
            throw new NotImplementedException();
        }

        public void update(Roles DBEntity, Roles entity)
        {
            throw new NotImplementedException();
        }
    }
}
