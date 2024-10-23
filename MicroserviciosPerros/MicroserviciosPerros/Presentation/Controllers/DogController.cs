using MicroserviciosPerros.Bussines.Services;
using MicroserviciosPerros.Data.DTO_s;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MicroserviciosPerros.Presentation.Controllers
{
    [EnableCors("AlowAny")]
    [Route("api/[controller]")]
    [ApiController]
    public class DogController : ControllerBase
    {
        private readonly IDogService _dogService;

        public DogController(IDogService dogService)
        {
                _dogService = dogService;
        }

        [HttpPost]
        public IActionResult Insert(DogDTO dogDTO) {

            try
            {
                _dogService.Insert(dogDTO);
                return Created();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
            
        }

        [HttpGet]
        public IActionResult GetAll() { 
            return Ok(_dogService.GetAll());
        }
        [HttpDelete]
        public IActionResult Delete(int id) {
            try
            {
                _dogService.Delete(id);
                return Ok($"Perro Eliminado {id}");
            }
            catch (Exception ex)
            {

                return NotFound(ex.Message);
            }
        }
    }
}
