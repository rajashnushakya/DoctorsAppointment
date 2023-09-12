using com.DoctorsAppointment.Models;
using Microsoft.EntityFrameworkCore;

namespace com.DoctorsAppointment.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options)
            : base(options)
        {
            
        }

        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
    }
}
