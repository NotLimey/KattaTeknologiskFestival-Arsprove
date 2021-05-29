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
    public class CalendarEventsService : ICalendarEventsInterface
    {
        private readonly kftDbContext _kftDbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CalendarEventsService(
            kftDbContext limeuLimeyfyDbContext,
            IWebHostEnvironment webHostEnvironment)
        {
            _kftDbContext = limeuLimeyfyDbContext;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<CalandarEvent> GetComponentByRoomAsync(int identifier)
        {
            return await _kftDbContext.Events.FirstOrDefaultAsync(p => p.RoomId.Equals(identifier));
        }

        public async Task<CalandarEvent> GetComponentByIdAsync(int identifier)
        {
            return await _kftDbContext.Events.FirstOrDefaultAsync(p => p.Id.Equals(identifier));
        }

        public async Task<bool> AddCalendarEvent(string subject, DateTime sDate, DateTime eDate, int roomId)
        {
            var calanderObj = new CalandarEvent
            {
                Subject = subject,
                StartDate = sDate,
                EndDate = eDate,
                RoomId = roomId
            };

            await _kftDbContext.Events.AddAsync(calanderObj).ConfigureAwait(false);

            var succes = await _kftDbContext.SaveChangesAsync().ConfigureAwait(false) > 0;

            return succes;
        }

        public async Task<List<CalandarEvent>> GetAllComponentsAsync()
        {
            return await _kftDbContext.Events.ToListAsync().ConfigureAwait(false);
        }

        public async Task<List<CalandarEvent>> GetAllComponentsByRoomAsync(int roomId)
        {
            return await _kftDbContext.Events.Where(r => r.RoomId == roomId).ToListAsync();
        }

        public async Task<bool> UpdateCalandarEvent(CalandarEvent updatedCalendar)
        {
            _kftDbContext.Events.Update(updatedCalendar);
            await _kftDbContext.SaveChangesAsync();
            return true;
        }
    }
}
