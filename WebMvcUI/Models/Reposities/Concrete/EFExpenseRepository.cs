using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvcUI.Models.Entities.Concrete;
using WebMvcUI.Models.Entities.Context;

namespace WebMvcUI.Models.Reposities.Concrete
{
    public class EFExpenseRepository : EFRepositoryBase<Expense>
    {
        private ProjectContext _context;
        public EFExpenseRepository(ProjectContext context) : base(context)
        {
            _context = context;
        }
    }
}
