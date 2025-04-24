using API.Entities;
using API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly InvoiceRepository _InvoiceRepository;
        public InvoiceController(InvoiceRepository InvoiceReponsitory)
        {
            _InvoiceRepository = InvoiceReponsitory;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var Invoices =await _InvoiceRepository.LIST();
            if (Invoices != null)
            {
                return Ok(Invoices);
            }
            else
            {
                return NotFound("Khong tim thay hoa don");
            }

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var Invoice = await _InvoiceRepository.GET(id);
                return Ok(Invoice);
            }
            catch(KeyNotFoundException)
            {
                return NotFound("Khong tim thay hoa don");
            }                
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Invoice Invoice)
        {
            if (Invoice == null)
            {
                return BadRequest("hoa don khong hop le");
            }
            await _InvoiceRepository.ADD(Invoice);
            return CreatedAtAction(nameof(Get), new { id = Invoice.Id }, Invoice);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Invoice Invoice)
        {
            if (Invoice == null)
            {
                return BadRequest("hoa don khong hop le");
            }
            var existingInvoice =await _InvoiceRepository.GET(id);
            if (existingInvoice == null)
            {
                return NotFound("hoa don khong ton tai");
            }
            await _InvoiceRepository.UPDATE(Invoice, id);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Invoice = await _InvoiceRepository.GET(id);
            if (Invoice == null)
            {
                return NotFound("hoa don khong ton tai");
            }
            await _InvoiceRepository.DELETE(id);
            return NoContent();
        }
    }
}
