using System.Threading.Tasks;
using API.Entities;
using API.IRepository;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class AppointmentRepository : IRepository<Appointment>
    {
        private readonly HairCutManagerContext _hairCutManagerContext;
        public AppointmentRepository(HairCutManagerContext hairCutManagerContext)
        {
            _hairCutManagerContext = hairCutManagerContext;
        }
        public async Task ADD(Appointment item)
        {
            await _hairCutManagerContext.Appointments.AddAsync(item);
            await _hairCutManagerContext.SaveChangesAsync();
        }

        public async Task DELETE(int id)
        {
            var appointment = await _hairCutManagerContext.Appointments.FirstOrDefaultAsync(i => i.Id == id);
            if(appointment != null)
            {
                _hairCutManagerContext.Appointments.Remove(appointment);
                await _hairCutManagerContext.SaveChangesAsync();
            }
        }

        public async Task<Appointment> GET(int id)
        {
            var appointment = await _hairCutManagerContext.Appointments.FirstOrDefaultAsync(i => i.Id == id);
            if(appointment != null)
            {
                return appointment;
            }
            else
            {
                throw new KeyNotFoundException("Appointment not found");
            }
        }

        public async Task<List<Appointment>> LIST()
        {
            return await _hairCutManagerContext.Appointments.ToListAsync();
        }

        public async Task UPDATE(Appointment item, int id)
        {
           Appointment? appointment = await _hairCutManagerContext.Appointments.FindAsync(id);
            if (appointment != null)
            {
                appointment.CustomerId = item.CustomerId;
                appointment.ServiceId = item.ServiceId;
                appointment.StaffId = item.StaffId;
                appointment.DateTime = item.DateTime;
                appointment.Status = item.Status;
                await _hairCutManagerContext.SaveChangesAsync();
            }
        }
    }
}
