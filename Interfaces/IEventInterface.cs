using KattaTeknologiskFestival.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KattaTeknologiskFestival.Interfaces
{
    interface IEventInterface
    {
        Task<CalandarEvent> GetComponentAsync(int id);

        Task<List<CalandarEvent>> GetAllComponentsAsync();
        Task<bool> UpdateActivitie(CalandarEvent calandarEvent);
    }
}
