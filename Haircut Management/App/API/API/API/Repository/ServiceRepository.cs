using API.Entities;
using API.IRepository;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class ServiceRepository : IRepository<Service>
    {
        private readonly HairCutManagerContext _hairCutManagerContext;
        public ServiceRepository(HairCutManagerContext hairCutManagerContext)
        {
            _hairCutManagerContext = hairCutManagerContext;
        }
        public async Task ADD(Service item)
        {
            await _hairCutManagerContext.Services.AddAsync(item);
            await _hairCutManagerContext.SaveChangesAsync();
        }

        public async Task DELETE(int id)
        {
            var service = await _hairCutManagerContext.Services.FirstOrDefaultAsync(i => i.Id == id);
            if (service != null)
            {
                _hairCutManagerContext.Services.Remove(service);
                await _hairCutManagerContext.SaveChangesAsync();
            }
        }

        public async Task<Service> GET(int id)
        {
            var service = await _hairCutManagerContext.Services.FirstOrDefaultAsync(i => i.Id == id);
            if (service != null)
            {
                return service;
            }
            else
            {
                throw new KeyNotFoundException("Service not found");
            }
        }

        public async Task<List<Service>> LIST()
        {
            return await _hairCutManagerContext.Services.ToListAsync();
        }

        public async Task UPDATE(Service item, int id)
        {
            Service? service = await _hairCutManagerContext.Services.FindAsync(id);
            if (service != null)
            {
                service.Name = item.Name;
                service.Price = item.Price;
                service.Duration = item.Duration;
                await _hairCutManagerContext.SaveChangesAsync();
            }
        }
    }
}
