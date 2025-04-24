using API.Entities;
using API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly AppointmentRepository _AppointmentRepository;
        public AppointmentController(AppointmentRepository AppointmentRepository)
        {
            _AppointmentRepository = AppointmentRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var Appointments =await _AppointmentRepository.LIST();
            if (Appointments != null )
            {
                return Ok(Appointments);
            }
            else
            {
                return NotFound("Khong tim thay cuoc hen ");
            }

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var Appointment = await _AppointmentRepository.GET(id);
                return Ok(Appointment);
            }
            catch (KeyNotFoundException     )
            {
                return NotFound("Khong tim thay cuoc hen");
            }
        }

        [HttpPost]
        public async Task<IActionResult>  Add([FromBody] Appointment Appointment)
        {
            if (Appointment == null)
            {
                return BadRequest("cuoc hen khong hop le");
            }
            await _AppointmentRepository.ADD(Appointment);
            return CreatedAtAction(nameof(Get), new { id = Appointment.Id }, Appointment);
        }

        [HttpPut("{id}")]
        public async Task <IActionResult> Update(int id, [FromBody] Appointment Appointment)
        {
            if (Appointment == null)
            {
                return BadRequest("cuoc hen khong hop le");
            }
            var existingAppointment =await _AppointmentRepository.GET(id);
            if (existingAppointment == null)
            {
                return NotFound("cuoc hen khong ton tai");
            }
            await _AppointmentRepository.UPDATE(Appointment, id);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Appointment = await _AppointmentRepository.GET(id);
            if (Appointment == null)
            {
                return NotFound("cuoc hen khong ton tai");
            }
            await _AppointmentRepository.DELETE(id);
            return NoContent();
        }
    }
}
