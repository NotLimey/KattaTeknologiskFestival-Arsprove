using KattaTeknologiskFestival.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KattaTeknologiskFestival.Interfaces
{
    public interface IActivitiesInterface
    {
        Task<Activitie> GetComponentAsync(int id);

        Task<List<Activitie>> GetAllComponentsAsync();
        Task<bool> UpdateActivitie(Activitie updatedActivitie);
    }
}
