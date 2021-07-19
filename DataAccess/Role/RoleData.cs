using DataAccess.BaseData;
using Database.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Role
{
    public class RoleData: BaseData<Database.Models.Roles>, IRoleData
    {
        private readonly EvaluacionTecnicaContext _context;
        public RoleData(EvaluacionTecnicaContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
