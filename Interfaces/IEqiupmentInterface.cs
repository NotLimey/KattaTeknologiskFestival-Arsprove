using KattaTeknologiskFestival.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KattaTeknologiskFestival.Interfaces
{
    public interface IEqiupmentInterface
    {
        Task<Equipment> GetComponentAsync(int id);

        Task<List<Equipment>> GetAllComponentsAsync();
    }
}
