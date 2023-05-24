using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvcUI.Models.Entities.Concrete;
using WebMvcUI.Models.Entities.Context;

namespace WebMvcUI.Models.Reposities.Concrete
{
    public class EFIdeaRepository : EFRepositoryBase<Idea>
    {
        private ProjectContext _context;
        public EFIdeaRepository(ProjectContext context) : base(context)
        {
            _context = context;
        }
    }
}
