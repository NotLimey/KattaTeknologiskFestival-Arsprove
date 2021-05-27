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
    public class EqiupmentService : IEqiupmentInterface
    {
        private readonly kftDbContext _kftDbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public EqiupmentService(
            kftDbContext limeuLimeyfyDbContext,
            IWebHostEnvironment webHostEnvironment)
        {
            _kftDbContext = limeuLimeyfyDbContext;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<Equipment> GetComponentAsync(int identifier)
        {
            return await _kftDbContext.Equipments.FirstOrDefaultAsync(p => p.Id.Equals(identifier));
        }

        public async Task<List<Equipment>> GetAllComponentsAsync()
        {
            return await _kftDbContext.Equipments.ToListAsync().ConfigureAwait(false);
        }
    }
}
