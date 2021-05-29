using KattaTeknologiskFestival.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KattaTeknologiskFestival.Data
{
    public class kftDbContext : DbContext
    {
        public kftDbContext(DbContextOptions<kftDbContext> options) 
            : base(options)
        {

        }

        public DbSet<Activitie> Activities { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<CalandarEvent> Events { get; set; }
    }
}
