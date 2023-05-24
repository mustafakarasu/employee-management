using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using WebMvcUI.Models.Entities.Abstract;

namespace WebMvcUI.Models.Entities.Concrete
{
    public class AdvancePayment : BaseEntity
    {
        [DisplayName("Avans Sebebi")]
        public string Name { get; set; }
        public virtual List<PersonalAdvance> PersonalAdvances { get; set; }
        public AdvancePayment()
        {
            PersonalAdvances = new List<PersonalAdvance>();
        }
    }
}
