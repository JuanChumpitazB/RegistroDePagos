using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using DAO;

namespace BL
{
    public class PersonaBL
    {
        PersonaDAO personaDAO = new PersonaDAO();
        public List<PersonaE> Listado()
        {
            return personaDAO.Listado();
        }
    }
}
