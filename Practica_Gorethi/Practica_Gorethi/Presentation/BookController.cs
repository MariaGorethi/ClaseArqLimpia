using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practica_Gorethi.Bussines.Services;
using Practica_Gorethi.Data.DTO_s;

namespace Practica_Gorethi.Presentation
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService reservationService)
        {
            _bookService = reservationService;
        }

        [HttpPost]
        public IActionResult Create(BookDTO dto)
        {
            try
            {
                var result = _bookService.Insert(dto);
                return result > 0 ? Created() : BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_bookService.GetAll());
        }

        [HttpGet("ByAutor")]
        public IActionResult GetByAutor(string nombreautor)
        {
            return Ok(_bookService.GetByAutor(nombreautor));
        }
    }

}
