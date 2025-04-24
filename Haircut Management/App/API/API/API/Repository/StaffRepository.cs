using System.Threading.Tasks;
using API.Entities;
using API.IRepository;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class StaffRepository : IRepository<Staff>
    {
        private readonly HairCutManagerContext _hairCutManagerContext;
        public StaffRepository(HairCutManagerContext hairCutManagerContext)
        {
            _hairCutManagerContext = hairCutManagerContext;
        }
        public async Task ADD(Staff item)
        {
            await _hairCutManagerContext.Staffs.AddAsync(item);
            await _hairCutManagerContext.SaveChangesAsync();
        }
        public async Task DELETE(int id)
        {
            var staff = await _hairCutManagerContext.Staffs.FirstOrDefaultAsync(i => i.Id == id);
            if (staff != null)
            {
                _hairCutManagerContext.Staffs.Remove(staff);
                await _hairCutManagerContext.SaveChangesAsync();
            }
        }
        public async Task< Staff> GET(int id)
        {
            var staff = await _hairCutManagerContext.Staffs.FirstOrDefaultAsync(i => i.Id == id);
            if (staff != null)
            {
                return staff;
            }
            else
            {
                throw new KeyNotFoundException("Staff not found");
            }
        }
        public async Task<List<Staff>> LIST()
        {
            return await _hairCutManagerContext.Staffs.ToListAsync();
        }
        public async Task UPDATE(Staff item, int id)
        {
            Staff? staff = await _hairCutManagerContext.Staffs.FindAsync(id);
            if (staff != null)
            {
                staff.Name = item.Name;
                staff.Role = item.Role;
                staff.WorkingHours = item.WorkingHours;
                await _hairCutManagerContext.SaveChangesAsync();
            }

        }
    }
}
