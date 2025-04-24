using API.Entities;
using API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly ServiceRepository _ServiceRepository;
        public ServiceController(ServiceRepository ServiceReponsitory)
        {
            _ServiceRepository = ServiceReponsitory;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var Services =await _ServiceRepository.LIST();
            if (Services != null)
            {
                return Ok(Services);
            }
            else
            {
                return NotFound("Khong tim thay dich vu nay");
            }

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var Service =await _ServiceRepository.GET(id);
                return Ok(Service);
            }
            catch (KeyNotFoundException)
            {
                return NotFound("Khong tim thay dich vu nay");
            }                   
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Service Service)
        {
            if (Service == null)
            {
                return BadRequest("dich vu nay khong hop le");
            }
            await _ServiceRepository.ADD(Service);
            return CreatedAtAction(nameof(Get), new { id = Service.Id }, Service);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Service Service)
        {
            if (Service == null)
            {
                return BadRequest("dich vu nay khong hop le");
            }
            var existingService =await _ServiceRepository.GET(id);
            if (existingService == null)
            {
                return NotFound("dich vu nay khong ton tai");
            }
            await _ServiceRepository.UPDATE(Service, id);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Service =await _ServiceRepository.GET(id);
            if (Service == null)
            {
                return NotFound("dich vu nay khong ton tai");
            }
            await _ServiceRepository.DELETE(id);
            return NoContent();
        }
    }
}
