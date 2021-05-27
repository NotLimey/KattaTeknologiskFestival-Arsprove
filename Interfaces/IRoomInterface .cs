using KattaTeknologiskFestival.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KattaTeknologiskFestival.Interfaces
{
    public interface IRoomInterface
    {
        Task<Room> GetComponentAsync(int id);

        Task<List<Room>> GetAllComponentsAsync();
    }
}
