using api_prueba.DAL;
using api_prueba.DAO.Interfaces;
using api_prueba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace api_prueba.DAO.Implements
{
    public class UsuariosImplements : UsuariosDAO
    {
        private readonly ApplicationDBContext context;

        public UsuariosImplements(ApplicationDBContext context)
        {
            this.context = context;
        }
        public void create(Usuarios entity)
        {
            
            context.Usuarios.Add(entity);
            context.SaveChanges();
        }

        public void delete(Usuarios entity)
        {
            context.Usuarios.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<Usuarios> getAll()
        {
            IEnumerable<Usuarios> user = context.Usuarios
                .Include(u => u.rol)
                .Include(e => e.estado).Where(u => u.IdEstado == 1).ToList();
            if(user != null)
            {
                return user;
            }
            else
            {
                return user = null;
            }
           
        }

        public Usuarios getById(long Id)
        {
            Usuarios user = context.Usuarios.Where(x => x.IdUsuario == Id).FirstOrDefault();
             if (user != null)
            {
                return user;
            }
            else
            {
                return user = null;
            }
        }

        public Usuarios login(Usuarios user)
        {
            Usuarios _user = context.Usuarios.Where(x => x.Usuario == user.Usuario && x.Contrasenia == user.Contrasenia).FirstOrDefault();
            return _user;
        }

        public void update(Usuarios DBEntity, Usuarios entity)
        {
            throw new NotImplementedException();
        }
    }
}
