using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KattaTeknologiskFestival.Models
{
    public class Activitie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AvailableSpots { get; set; }
        public int TakenSpots { get; set; }
        public int RoomId { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
    }
}
