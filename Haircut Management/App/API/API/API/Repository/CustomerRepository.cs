using API.IRepository;
using API.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class CustomerRepository : IRepository<Customer>
    {
        private readonly HairCutManagerContext _hairCutManagerContext;
        public CustomerRepository(HairCutManagerContext hairCutManagerContext) 
        {
            _hairCutManagerContext = hairCutManagerContext;
        }
        public async Task ADD(Customer item)
        {
            await _hairCutManagerContext.Customers.AddAsync(item);
            await _hairCutManagerContext.SaveChangesAsync();
        }

        public async Task DELETE(int id)
        {
            var customer = await _hairCutManagerContext.Customers.FirstOrDefaultAsync(i => i.Id == id);
            if(customer != null)
            {
               _hairCutManagerContext.Customers.Remove(customer);
               await _hairCutManagerContext.SaveChangesAsync();
            }
        }

        public async Task <Customer> GET(int id)
        {
          var customer = await _hairCutManagerContext.Customers.FirstOrDefaultAsync(i => i.Id == id);
            if(customer != null)
            {
                return customer;
            }
            else
            {
                throw new KeyNotFoundException("Customer not found");
            }
        }

        public async Task <List<Customer>> LIST()
        {
          return await _hairCutManagerContext.Customers.ToListAsync();
        }

        public async Task UPDATE(Customer item, int id)
        {
            Customer? customer = await _hairCutManagerContext.Customers.FindAsync(id);
            if (customer != null)
            { 
                customer.Name = item.Name;
                customer.Phone = item.Phone;
                customer.BirthDate = item.BirthDate;
                customer.CreateAt = item.CreateAt;
                await _hairCutManagerContext.SaveChangesAsync();
            }   
        }
    }
}
