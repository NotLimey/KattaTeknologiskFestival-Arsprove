using KattaTeknologiskFestival.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KattaTeknologiskFestival.Interfaces
{
    public interface ICalendarEventsInterface
    {
        Task<CalandarEvent> GetComponentByRoomAsync(int id);
        Task<CalandarEvent> GetComponentByIdAsync(int id);
        Task<bool> AddCalendarEvent(string subject, DateTime sDate, DateTime eDate, int roomId);
        Task<List<CalandarEvent>> GetAllComponentsAsync();
        Task<List<CalandarEvent>> GetAllComponentsByRoomAsync(int roomId);
        Task<bool> UpdateCalandarEvent(CalandarEvent updatedCalandarEvent);
    }
}
