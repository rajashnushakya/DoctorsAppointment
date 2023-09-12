using System.ComponentModel.DataAnnotations;

namespace com.DoctorsAppointment.Models
{
    public class Doctor
    {
        public int ID { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Specialization { get; set; }
        [StringLength(250)]
        public string AvailableTimefrom { get; set; }
        [StringLength(250)]
        public string AvailableTimeUpto { get; set; }
        [StringLength(250)]
        public string ContactNo { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        [StringLength(250)]
        public string MECRegdNo { get; set; }



    }
}
