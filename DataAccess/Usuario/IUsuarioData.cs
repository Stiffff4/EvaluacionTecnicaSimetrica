using DataAccess.BaseData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Usuario
{
    public interface IUsuarioData: IBaseData<Database.Models.Usuario>
    {
        bool SignIn(string username, string password);
    }
}
