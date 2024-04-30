using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace NewHospital.Models
{
    public class TimeDataModel
    {
        [Key]
        public int Id { get; set; } 
        public string DoctorId { get; set; }
        public string TimeRange { get; set; }

        public DateTime Day { get; set; }
        public DateTime StartTime { get; set; } 
        public DateTime EndTime { get; set; } 

    }
}
