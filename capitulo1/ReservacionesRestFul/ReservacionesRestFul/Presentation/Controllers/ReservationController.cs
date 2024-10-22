using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReservacionesRestFul.Bussines.Services;
using ReservacionesRestFul.Data.DTO_s;

namespace ReservacionesRestFul.Presentation.Controllers
{
    [Route("api/[controller]")]//http://ip:port//api/Reservation
    [ApiController]


    //POST-> INSERT
    //PUT-> ACTUALIZACION
    //PATCH -> ACTUALIZACION PARCIAL
    //GET-> CONSULTAS
    //DELETE-> ELIMINAR
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
                _reservationService = reservationService;
        }

        [HttpPost]
        public IActionResult Create(ReservationDTO dto) {
            try
            {
                var result = _reservationService.Insert(dto);
                return result > 0 ? Created() : BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAll() { 
            return Ok(_reservationService.GetAll());
        }

        [HttpGet("rooms")]
        public IActionResult GetAvailableRooms()
        {
            return Ok(_reservationService.GetAvailableRooms());
        }
    }
}
