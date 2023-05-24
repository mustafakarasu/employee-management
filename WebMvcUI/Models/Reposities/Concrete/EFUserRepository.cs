using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebMvcUI.Models.Entities.Concrete;
using WebMvcUI.Models.Entities.Context;

namespace WebMvcUI.Models.Reposities.Concrete
{
    public class EFUserRepository : EFRepositoryBase<User>
    {
        private ProjectContext _context;
        public EFUserRepository(ProjectContext context) : base(context)
        {
            _context = context;
        }
    }
}
