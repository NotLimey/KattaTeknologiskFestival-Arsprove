using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KattaTeknologiskFestival.Models
{
    public class CalandarEvent
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public CalandarEvent()
        {
            Color = Helpers.RandomColorHelper.GetRandomColorClass();
        }
        
        public string Subject { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Color { get; private set; }
        public int RoomId { get; set; }
    }
}
