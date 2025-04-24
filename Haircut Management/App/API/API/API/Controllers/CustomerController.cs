using API.Entities;
using API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("[controller]")] 
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerRepository _customerRepository;
        public CustomerController(CustomerRepository customerReponsitory)
        {
            _customerRepository = customerReponsitory;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var customers = await _customerRepository.LIST();
            if (customers != null)
            {
                return Ok(customers);
            }
            else
            {
                return NotFound("Khong tim thay khach hang");
            }

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var customer = await _customerRepository.GET(id);
                return Ok(customer);
            }
            catch (KeyNotFoundException)
            {
                return NotFound("Khong tim thay khach hang");
            }               
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Customer customer)
        {
            if (customer == null)
            {
                return BadRequest("Khach hang khong hop le");
            }
            await _customerRepository.ADD(customer);
            return CreatedAtAction(nameof(Get), new { id = customer.Id }, customer);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Customer customer)
        {
            if (customer == null)
            {
                return BadRequest("Khach hang khong hop le");
            }
            var existingCustomer = await _customerRepository.GET(id);
            if (existingCustomer == null)
            {
                return NotFound("Khach hang khong ton tai");
            }
            await _customerRepository.UPDATE(customer, id);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var customer =await _customerRepository.GET(id);
            if (customer == null)
            {
                return NotFound("Khach hang khong ton tai");
            }
            await _customerRepository.DELETE(id);
            return NoContent();
        }
    }
}
