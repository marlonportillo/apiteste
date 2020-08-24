using api_prueba.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_prueba.DAO.Interfaces
{
    public interface UsuariosDAO : CRUD<Usuarios>
    {
        Usuarios login(Usuarios user);
    }
}
