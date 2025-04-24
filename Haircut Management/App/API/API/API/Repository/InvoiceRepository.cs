using API.Entities;
using API.IRepository;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class InvoiceRepository : IRepository<Invoice>
    {
        private readonly HairCutManagerContext _hairCutManagerContext;
        public InvoiceRepository(HairCutManagerContext hairCutManagerContext)
        {
            _hairCutManagerContext = hairCutManagerContext;
        }
        public async Task ADD(Invoice item)
        {
            await _hairCutManagerContext.Invoices.AddAsync(item);
            await _hairCutManagerContext.SaveChangesAsync();
        }
        public async Task DELETE(int id)
        {
            var invoice = await _hairCutManagerContext.Invoices.FirstOrDefaultAsync(i => i.Id == id);
            if (invoice != null)
            {
                _hairCutManagerContext.Invoices.Remove(invoice);
                await _hairCutManagerContext.SaveChangesAsync();
            }
        }
        public async Task<Invoice> GET(int id)
        {
            var invoice = await _hairCutManagerContext.Invoices.FirstOrDefaultAsync(i => i.Id == id);
            if (invoice != null)
            {
                return invoice;
            }
            else
            {
                throw new KeyNotFoundException("Invoice not found");
            }
        }
        public async Task<List<Invoice>> LIST()
        {
            return await _hairCutManagerContext.Invoices.ToListAsync();
        }
        public async Task UPDATE(Invoice item, int id)
        {
            Invoice? invoice = await _hairCutManagerContext.Invoices.FindAsync(id);
            if (invoice != null)
            {
                invoice.AppointmentId = item.AppointmentId;
                invoice.TotalPrice = item.TotalPrice;
                invoice.CreatedAt = item.CreatedAt;
                await _hairCutManagerContext.SaveChangesAsync();
            } 
        }
    }
}
