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
    public class ActivitiesService : IActivitiesInterface
    {
        private readonly kftDbContext _kftDbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ActivitiesService(
            kftDbContext limeuLimeyfyDbContext,
            IWebHostEnvironment webHostEnvironment)
        {
            _kftDbContext = limeuLimeyfyDbContext;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<Activitie> GetComponentAsync(int identifier)
        {
            return await _kftDbContext.Activities.FirstOrDefaultAsync(p => p.Id.Equals(identifier));
        }

        public async Task<List<Activitie>> GetAllComponentsAsync()
        {
            return await _kftDbContext.Activities.ToListAsync().ConfigureAwait(false);
        }

        public async Task<bool> UpdateActivitie(Activitie updatedActivitie)
        {
            _kftDbContext.Activities.Update(updatedActivitie);
            await _kftDbContext.SaveChangesAsync();
            return true;
        }
    }
}
