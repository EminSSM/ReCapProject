using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        IColorService _colorservice;

        public ColorsController(IColorService colorservice)
        {
            _colorservice = colorservice;
        }
  
        [HttpGet]
        public IActionResult GetAllColors()
        {
            var result = _colorservice.TGetAllColors();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetColors(int id)
        {
            var result = _colorservice.TGetBy(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost]
        public IActionResult Add(Color color)
        {
            var result = _colorservice.TAdd(color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut]
        public IActionResult Update(Color color)
        {
            var result = _colorservice.TUpdate(color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete]
        public IActionResult Delete(Color color)
        {
            var result = _colorservice.TDelete(color);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);  
        }

    }
}
