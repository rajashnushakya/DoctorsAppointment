namespace com.DoctorsAppointment.Models
{
    public class Appointment
    {
        public int ID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Problem { get; set; }
        public string PatientName { get; set; }
        public string PatientContact { get; set; }

    }
}
