using DataAccess.BaseData;
using Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Usuario
{
    public class UsuarioData: BaseData<Database.Models.Usuario>, IUsuarioData
    {
        private readonly EvaluacionTecnicaContext _context;
        public UsuarioData(EvaluacionTecnicaContext context)
            : base(context)
        {
            _context = context;
        }

        public bool SignIn(string username, string password)
        {
            try
            {
                if (_context.Usuarios.Any(x => x.Usuario_Nombre == username && x.Contrasena == password))
                    return true;
            }
            catch (Exception e)
            {
                throw e.GetBaseException();
            }
            return false;
        }
    }
}
