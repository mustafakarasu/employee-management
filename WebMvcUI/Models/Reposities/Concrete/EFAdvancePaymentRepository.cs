using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvcUI.Models.Entities.Concrete;
using WebMvcUI.Models.Entities.Context;

namespace WebMvcUI.Models.Reposities.Concrete
{
    public class EFAdvancePaymentRepository : EFRepositoryBase<AdvancePayment>
    {
        private ProjectContext _context;
        public EFAdvancePaymentRepository(ProjectContext context) : base(context)
        {
            _context = context;
        }
    }
}
