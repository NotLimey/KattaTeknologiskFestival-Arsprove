using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KattaTeknologiskFestival.Models
{
    public class Equipment
    {
        public string Name { get; set; }

        public int AvailableUnits { get; set; }
        public int TakenUnits { get; set; }

        public int Id { get; set; }
    }
}
