using KattaTeknologiskFestival.Data;
using KattaTeknologiskFestival.Interfaces;
using KattaTeknologiskFestival.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KattaTeknologiskFestival.Services
{
    public class RoomService : IRoomInterface
    {

        private readonly kftDbContext _kftDbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public RoomService(
            kftDbContext limeuLimeyfyDbContext,
            IWebHostEnvironment webHostEnvironment)
        {
            _kftDbContext = limeuLimeyfyDbContext;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<Room> GetComponentAsync(int identifier)
        {
            return await _kftDbContext.Rooms.FirstOrDefaultAsync(p => p.RoomId.Equals(identifier));
        }

        public async Task<List<Room>> GetAllComponentsAsync()
        {
            return await _kftDbContext.Rooms.ToListAsync().ConfigureAwait(false);
        }
    }
}
