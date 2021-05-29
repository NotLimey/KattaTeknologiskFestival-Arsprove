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
    public class EventService : IEventInterface
    {
        private readonly kftDbContext _kftDbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public EventService(
            kftDbContext limeuLimeyfyDbContext,
            IWebHostEnvironment webHostEnvironment)
        {
            _kftDbContext = limeuLimeyfyDbContext;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<CalandarEvent> GetComponentAsync(int identifier)
        {
            return await _kftDbContext.Events.FirstOrDefaultAsync(p => p.Id.Equals(identifier));
        }

        public async Task<List<CalandarEvent>> GetAllComponentsAsync()
        {
            return await _kftDbContext.Events.ToListAsync().ConfigureAwait(false);
        }

        public async Task<bool> UpdateActivitie(CalandarEvent updateEvent)
        {
            _kftDbContext.Events.Update(updateEvent);
            await _kftDbContext.SaveChangesAsync();
            return true;
        }
    }
}
