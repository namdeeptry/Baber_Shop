using API.Entities;
using API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly StaffRepository _StaffRepository;
        public StaffController(StaffRepository StaffReponsitory)
        {
            _StaffRepository = StaffReponsitory;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var Staffs =await _StaffRepository.LIST();
            if (Staffs != null)
            {
                return Ok(Staffs);
            }
            else
            {
                return NotFound("Khong tim thay nhan vien nay ");
            }

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var Staff =await _StaffRepository.GET(id);
                return Ok(Staff);

            }
            catch (KeyNotFoundException) 
            { 
                return NotFound("Khong tim thay nhan vien nay");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Staff Staff)
        {
            if (Staff == null)
            {
                return BadRequest("nhan vien nay khong hop le");
            }
            await _StaffRepository.ADD(Staff);
            return CreatedAtAction(nameof(Get), new { id = Staff.Id }, Staff);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Staff Staff)
        {
            if (Staff == null)
            {
                return BadRequest("nhan vien nay khong hop le");
            }
            var existingStaff = await _StaffRepository.GET(id);
            if (existingStaff == null)
            {
                return NotFound("nhan vien nay khong ton tai");
            }
            await _StaffRepository.UPDATE(Staff, id);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Staff = await _StaffRepository.GET(id);
            if (Staff == null)
            {
                return NotFound("nhan vien nay khong ton tai");
            }
            await _StaffRepository.DELETE(id);
            return NoContent();
        }
    }
}
