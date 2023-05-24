using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvcUI.Models.Entities.Concrete;
using WebMvcUI.Models.Entities.Context;

namespace WebMvcUI.Models.Reposities.Concrete
{
    public class EFPersonalExpenseRepository : EFRepositoryBase<PersonalExpense>
    {
        private ProjectContext _context;
        public EFPersonalExpenseRepository(ProjectContext context) : base(context)
        {
            _context = context;
        }
    }
}
